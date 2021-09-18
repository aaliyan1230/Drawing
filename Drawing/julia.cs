using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Data.OleDb;





namespace Drawing {
  
    /// Julia class extends Form, used to render the Julia set,
    /// with user controls allowing selection of the region to plot,
    /// resolution, maximum iteration count etc.

    
    public partial class julia : Form
    {

     
        public julia() {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );
        private void MakeLabelRounded()
        {

            GraphicsPath gp = new GraphicsPath();

            gp.AddEllipse(0, 0, label1.Width, label1.Height);

            label1.Region = new Region(gp);

            label1.Invalidate();

        }


        private ScreenPixelManage myPixelManager;                   // Used for conversions between maths and pixel coordinates.
        private ComplexPoint zoomCoord1 = new ComplexPoint(-1, 1);  // First point (lower-left) of zoom rectangle.
        private ComplexPoint zoomCoord2 = new ComplexPoint(-2, 1);  // Second point (upper-right) of zoom rectangle.
        private double yMin = -2.0;                                 // Default minimum Y for the set to render.
        private double yMax = 0.0;                                  // Default maximum Y for the set to render.
        private double xMin = -2.0;                                 // Default minimum X for the set to render.
        private double xMax = 1.0;                                  // Default maximum X for the set to render.
        private int kMax = 50;                                      // Default maximum number of iterations for Mandelbrot calculation.
        private int numColours = 85;                                // Default number of colours to use in colour table.
        private int zoomScale = 7;                                  // Default amount to zoom in by.

        private Graphics g;                                         // Graphics object: all graphical rendering is done on this object.
        private Bitmap myBitmap;                                    // Bitmap used to draw images.
        private double xValue;                                      // Save x coordinate on screen click.
        private double yValue;                                      // Save y coordinate on screen click.
        private int undoNum = 0;                                    // Undo count, used when undoing user opertions in the form controls.
        private string userName;                                    // User name.
        private ColourTable colourTable = null;                     // Colour table.


        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\c#\Mandelbrot\Drawing\Julia.accdb");
        OleDbDataAdapter adap = new OleDbDataAdapter("select * from DataPts", @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\c#\Mandelbrot\Drawing\Julia.accdb");
        DataSet d1 = new DataSet();
        /// Load the main form for this application.

        private void Form1_Load(object sender, EventArgs e) {
            con.Open();
            dataGridView1.Hide();
            userName = Environment.UserName;
            // Create graphics object for Mandelbrot rendering.
                        myBitmap = new Bitmap(ClientRectangle.Width,
                                  ClientRectangle.Height,
                                  System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            g = Graphics.FromImage(myBitmap);
            // Set the background of the form to white.
            g.Clear(Color.FromArgb(46,51,73));

            // Hide controls that are not relevant until the first rendering has completed.
            zoomCheckbox.Hide();
            undoButton.Hide();
        }

        int count = 0;

        private void dbb_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            OleDbConnection connection;
            OleDbDataAdapter oledbAdapter;
            DataSet ds = new DataSet();
            string sql = null;

            connetionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\c#\Mandelbrot\Drawing\Julia.accdb";
            sql = "select * from DataPts";

            connection = new OleDbConnection(connetionString);
            try
            {
                connection.Open();
                oledbAdapter = new OleDbDataAdapter(sql, con);
                oledbAdapter.Fill(ds, "DataPts");
                oledbAdapter.Dispose();
                connection.Close();
                count = ds.Tables[0].Rows.Count + 1;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }


            OleDbCommand com = new OleDbCommand("insert into DataPts(Num, yMin, yMax, xMin, xMax, iterations, Cx, Cy) values('" + count + "','" + yMinCheckBox.Text + "','" + yMaxCheckBox.Text + "','" + xMinCheckBox.Text + "','" + xMaxCheckBox.Text + "','" + iterationCountTextBox.Text  + "','" + textBox1.Text + "','" + textBox2.Text + "' )", con);
            com.ExecuteNonQuery();
            MessageBox.Show("Points have been saved");

        }

        private void rdb_Click(object sender, EventArgs e)
        {

            DataTable d = new DataTable();

            adap.Fill(d);
            dataGridView1.DataSource = d;
            dataGridView1.Show();
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                yMinCheckBox.Text = dataGridView1.Rows[e.RowIndex].Cells["yMin"].FormattedValue.ToString();
                yMaxCheckBox.Text = dataGridView1.Rows[e.RowIndex].Cells["yMax"].FormattedValue.ToString();
                xMinCheckBox.Text = dataGridView1.Rows[e.RowIndex].Cells["xMin"].FormattedValue.ToString();
                xMaxCheckBox.Text = dataGridView1.Rows[e.RowIndex].Cells["xMax"].FormattedValue.ToString();
                iterationCountTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["iterations"].FormattedValue.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Cx"].FormattedValue.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Cy"].FormattedValue.ToString();

            }
            dataGridView1.Hide();
          
        }
        /// On-click handler for generate button. Triggers rendering of the Mandelbrot
        /// set using current configuration settings.


        private void generate_Click(object sender, EventArgs e) {
            RenderImage();
        }

        private void RenderImage() {
            try {
                statusLabel.Text = "Status: Rendering";
                if (Convert.ToBoolean(pixelStepTextBox.Text.Equals("")) ||
                    Convert.ToBoolean(pixelStepTextBox.Text.Equals("0")) ||
                    Convert.ToBoolean(iterationCountTextBox.Text.Equals("")) ||
                    Convert.ToBoolean(yMinCheckBox.Text.Equals("")) ||
                    Convert.ToBoolean(yMaxCheckBox.Text.Equals("")) ||
                    Convert.ToBoolean(xMinCheckBox.Text.Equals("")) ||
                    Convert.ToBoolean(xMaxCheckBox.Text.Equals(""))) {
                    // Choose default parameters and warn the user if the settings are all empty.
                    pixelStepTextBox.Text = "1";
                    iterationCountTextBox.Text = "85";
                    yMinCheckBox.Text = "-1";
                    yMaxCheckBox.Text = "1";
                    xMinCheckBox.Text = "-2";
                    xMaxCheckBox.Text = "1";
                    MessageBox.Show("Invalid fields detected. Using default values.");
                    statusLabel.Text = "Status: Error";
                    return;

                } else {
                    // Show zoom and undo controls.
                    zoomCheckbox.Show();
                    undoButton.Show();
                    undoNum++;
                }

                // Mandelbrot iteration count, meaning number of colours.
                kMax = Convert.ToInt32(iterationCountTextBox.Text);
                numColours = kMax;

                // If colourTable is not yet created or kMax has changed, create colourTable.
                if ((colourTable == null) || (kMax != colourTable.kMax) || (numColours != colourTable.nColour)) {
                    colourTable = new ColourTable(numColours, kMax);
                }

                // Get the x, y range (mathematical coordinates) to plot.
                yMin = Convert.ToDouble(yMinCheckBox.Text);
                yMax = Convert.ToDouble(yMaxCheckBox.Text);
                xMin = Convert.ToDouble(xMinCheckBox.Text);
                xMax = Convert.ToDouble(xMaxCheckBox.Text);

                // Zoom scale.
                zoomScale = Convert.ToInt16(zoomTextBox.Text);

                // Clear any existing graphics content.
                g.Clear(Color.White);

                // Initialise working variables.
                int height = (int)g.VisibleClipBounds.Size.Height;
                int kLast = -1;
                double modulusSquared;
                Color color;
                Color colorLast = Color.Red;

                // Get screen boundary (lower left & upper right). This is
                // used when calculating the pixel scaling factors.
                ComplexPoint screenBottomLeft = new ComplexPoint(xMin, yMin);
                ComplexPoint screenTopRight = new ComplexPoint(xMax, yMax);

                // Create pixel manager. This sets up the scaling factors used when
                // converting from mathemathical to screen (pixel units) using the
                myPixelManager = new ScreenPixelManage(g, screenBottomLeft, screenTopRight);

               
                // This increment is converted to mathematical coordinates.
                int xyPixelStep = Convert.ToInt16(pixelStepTextBox.Text);
                ComplexPoint pixelStep = new ComplexPoint(xyPixelStep, xyPixelStep);
                ComplexPoint xyStep = myPixelManager.GetDeltaMathsCoord(pixelStep);

                // Start stopwatch - used to measure performance improvements
               
                Stopwatch sw = new Stopwatch();
                sw.Start();

                // Main loop, nested over Y (outer) and X (inner) values.
                int lineNumber = 0;
                int yPix = myBitmap.Height - 1;
                for (double y = yMin; y < yMax; y += xyStep.y) {
                    int xPix = 0;
                    for (double x = xMin; x < xMax; x += xyStep.x) {
                        // Initialise complex value Zk.
                        ComplexPoint zk = new ComplexPoint(x, y);
                       // zk = new ComplexPoint(Math.Sin(zk.x) * Math.Cosh(zk.y), Math.Cos(zk.x) * Math.Sinh(zk.y)); 
                        // Create complex point C = x + i*y.
                        ComplexPoint c = new ComplexPoint(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));

                        // Do the main Julia calculation. Iterate until the equation
                        // converges or the maximum number of iterations is reached.
                        int k = 0;
                        do {
                            zk = zk.doCmplxSqPlusConst(c);
                            modulusSquared = zk.doMoulusSq();
                            k++;
                        } while ((modulusSquared <= 4.0) && (k < kMax));

                        if (k < kMax) {
                            // Max number of iterations was not reached. This means that the
                            // equation converged. Now assign a colour to the current pixel that
                            // depends on the number of iterations, k, that were done.

                            if (k == kLast) {
                                // If the iteration count is the same as the last count, re-use the
                                // last pen. This avoids re-calculating colour factors which is
                                // computationally intensive. We benefit from this often because
                                // adjacent pixels are often the same colour, especially in large parts
                                // of the Mandelbrot set that are away from the areas of detail.
                                color = colorLast;
                            } else {
                                // Calculate coluor scaling, from k. We don't use complicated/fancy colour
                                // lookup tables. Instead, the following simple conversion works well:
                                //
                                // hue = (k/kMax)**0.25 where the constant 0.25 can be changed if wanted.
                                // This formula stretches colours allowing more to be assigned at higher values
                                // of k, which brings out detail in the Mandelbrot images.

                                // The following is a full colour calculation, replaced now with colour table.
                                // Uncomment and disable the colour table if wanted. The colour table works
                                // well but supports fewer colours than full calculation of hue and colour
                                // using double-precision arithmetic.
                                double colourIndex = ((double)k) / kMax;
                                double hue = Math.Pow(colourIndex, 0.25);

                                // Colour table lookup.
                                // Convert the hue value to a useable colour and assign to current pen.
                                // The saturation and lightness are hard-coded at 0.9 and 0.6 respectively,
                                // which work well.
                                color = colourTable.GetColour(k);
                                colorLast = color;
                            }

                            // Draw single pixel
                            if (xyPixelStep == 1) {
                                // Pixel step is 1, set a single pixel.
                                if ((xPix < myBitmap.Width) && (yPix >= 0)) {
                                    myBitmap.SetPixel(xPix, yPix, color);
                                }
                            } else {
                             // Pixel step is > 1, set a square of pixels.
                                for (int pX = 0; pX < xyPixelStep; pX++) {
                                    for (int pY = 0; pY < xyPixelStep; pY++) {
                                        if (((xPix + pX) < myBitmap.Width) && ((yPix - pY) >= 0)) {
                                            myBitmap.SetPixel(xPix + pX, yPix - pY, color);
                                        }
                                    }
                                }
                            }
                        }
                        xPix += xyPixelStep;
                    }
                    yPix -= xyPixelStep;
                    lineNumber++;
                    if ((lineNumber % 120) == 0) {
                        Refresh();
                    }
                }
                // Finished rendering. Stop the stopwatch and show the elapsed time.
                sw.Stop();
                Refresh();
                stopwatchLabel.Text = Convert.ToString(sw.Elapsed.TotalSeconds);
                statusLabel.Text = "Status: Render complete";

                // Save current settings to undo file.
                StreamWriter writer = new StreamWriter(@"C:\Users\" + userName + "\\mandelbrot_config\\Undo\\undo" + undoNum + ".txt");
                writer.Write(pixelStepTextBox.Text + Environment.NewLine + iterationCountTextBox.Text + Environment.NewLine + yMinCheckBox.Text + Environment.NewLine + yMaxCheckBox.Text + Environment.NewLine + xMinCheckBox.Text + Environment.NewLine + xMaxCheckBox.Text);
                writer.Close();
                writer.Dispose();
            } catch (Exception e2) {
                MessageBox.Show("Exception Trapped: " + e2.Message, "Error");
                statusLabel.Text = "Status: Error";
            }
        }

      
        /// Convert HSL colour value to Color object.
     
        /// <param name="H">Hue</param>
        /// <param name="S">Saturation</param>
        /// <param name="L">Lightness</param>
     
        private static Color colorFromHSLA(double H, double S, double L) {
            double v;
            double r, g, b;

            r = L;   // Set RGB all equal to L, defaulting to grey.
            g = L;
            b = L;

            // Standard HSL to RGB conversion.
           
            v = (L <= 0.5) ? (L * (1.0 + S)) : (L + S - L * S);

            if (v > 0) {
                double m;
                double sv;
                int sextant;
                double fract, vsf, mid1, mid2;

                m = L + L - v;
                sv = (v - m) / v;
                H *= 6.0;
                sextant = (int)H;
                fract = H - sextant;
                vsf = v * sv * fract;
                mid1 = m + vsf;
                mid2 = v - vsf;

                switch (sextant) {
                    case 0:
                        r = v;
                        g = mid1;
                        b = m;
                        break;

                    case 1:
                        r = mid2;
                        g = v;
                        b = m;
                        break;

                    case 2:
                        r = m;
                        g = v;
                        b = mid1;
                        break;

                    case 3:
                        r = m;
                        g = mid2;
                        b = v;
                        break;

                    case 4:
                        r = mid1;
                        g = m;
                        b = v;
                        break;

                    case 5:
                        r = v;
                        g = m;
                        b = mid2;
                        break;
                }
            }

            // Create Color object from RGB values.
            Color color = Color.FromArgb((int)(r * 255), (int)(g * 255), (int)(b * 255));
            return color;
        }

      
        /// On-click handler for main form. Defines the points (lower-left and upper-right)
        /// of a zoom rectangle.
     
        private void mouseClickOnForm(object sender, MouseEventArgs e) {
            if (zoomCheckbox.Checked) {
                Pen box = new Pen(Color.Black);
                double x = Convert.ToDouble(e.X);
                xValue = x;
                double y = Convert.ToDouble(e.Y);
                yValue = y;

                try {
                    zoomScale = Convert.ToInt16(zoomTextBox.Text);
                } catch(Exception c) {
                    MessageBox.Show("Error: " + c.Message, "Error");
                }
                // Zoom scale has to be above 0, or their is no point in zooming.
                if (zoomScale < 1) {
                    MessageBox.Show("Zoom scale must be above 0");
                    zoomScale = 7;
                    zoomTextBox.Text = "7";
                    return;
                }

                ComplexPoint pixelCoord = new ComplexPoint((int)(xValue - (1005 / (zoomScale)) / 4), (int)(yValue - (691 / (zoomScale)) / 4));//
                zoomCoord1 = myPixelManager.GetAbsoluteMathsCoord(pixelCoord);
            }
        }

     
        /// Mouse-up handler for main form. The coordinates of the rectangle are
        /// saved so the new drawing can be rendered.
      
        private void mouseUpOnForm(object sender, MouseEventArgs e) {
            if (zoomCheckbox.Checked) {
                double x = Convert.ToDouble(e.X);
                double y = Convert.ToDouble(e.Y);

                ComplexPoint pixelCoord = new ComplexPoint((int)(xValue + (1005 / (zoomScale)) / 4), (int)(yValue + (691 / (zoomScale)) / 4));//
                zoomCoord2 = myPixelManager.GetAbsoluteMathsCoord(pixelCoord);

                // Swap to ensure that zoomCoord1 stores the lower-left
                // coordinate for the zoom region, and zoomCoord2 stores the
                // upper right coordinate.
                if (zoomCoord2.x < zoomCoord1.x) {
                    double temp = zoomCoord1.x;
                    zoomCoord1.x = zoomCoord2.x;
                    zoomCoord2.x = temp;
                }
                if (zoomCoord2.y < zoomCoord1.y) {
                    double temp = zoomCoord1.y;
                    zoomCoord1.y = zoomCoord2.y;
                    zoomCoord2.y = temp;
                }
                yMinCheckBox.Text = Convert.ToString(zoomCoord1.y);
                yMaxCheckBox.Text = Convert.ToString(zoomCoord2.y);
                xMinCheckBox.Text = Convert.ToString(zoomCoord1.x);
                xMaxCheckBox.Text = Convert.ToString(zoomCoord2.x);
                RenderImage();
            }
        }
       
        
        private void undo_Click(object sender, EventArgs e)
        {
            try
            {
                var fileContent = File.ReadAllText(@"C:\Users\" + userName + "\\mandelbrot_config\\Undo\\undo" + (undoNum -= 1) + ".txt");
                var array1 = fileContent.Split((string[])null, StringSplitOptions.RemoveEmptyEntries);

                pixelStepTextBox.Text = array1[0];
                iterationCountTextBox.Text = array1[1];
                yMinCheckBox.Text = array1[2];
                yMaxCheckBox.Text = array1[3];
                xMinCheckBox.Text = array1[4];
                xMaxCheckBox.Text = array1[5];
            }
            catch (Exception e3)
            {
                MessageBox.Show("Unable to Undo: " + e3.Message, "Error");
            }
        }
        /// This will apply the zoom rectangle coordinates to the
        /// yMin yMax, xMin xMax text boxes.

        private void button2_Click(object sender, EventArgs e) {
            yMinCheckBox.Text = Convert.ToString(zoomCoord1.y);
            yMaxCheckBox.Text = Convert.ToString(zoomCoord2.y);
            xMinCheckBox.Text = Convert.ToString(zoomCoord1.x);
            xMaxCheckBox.Text = Convert.ToString(zoomCoord2.x);
        }


        /// Class used for colour lookup table.
   
        private class ColourTable {
            public int kMax;
            public int nColour;
            private double scale;
            private Color[] colourTable;

          
            /// Constructor. Creates lookup table.
            
            public ColourTable(int n, int kMax) {
                nColour = n;
                this.kMax = kMax;
                scale = ((double)nColour) / kMax;
                colourTable = new Color[nColour];

                for (int i = 0; i < nColour; i++) {
                    double colourIndex = ((double) i) / nColour;
                    double hue = Math.Pow(colourIndex, 0.25);
                    colourTable[i] = colorFromHSLA(hue, 0.9, 0.5);
                }
            }

        
            /// Retrieve the colour from iteration count k.
            
            public Color GetColour(int k) {
                return colourTable[k];
            } 
        }

        // Mandelbrot_Paint handler to draw the image.
        private void Mandelbrot_Paint(object sender, PaintEventArgs e) {
            Graphics graphicsObj = e.Graphics;
            graphicsObj.DrawImage(myBitmap, 0, 0, myBitmap.Width, myBitmap.Height);
            graphicsObj.Dispose();
        }

        // Button used to save bitmap at desired location. File type is defaulted as Portable Network Graphics.
        private void saveImageButton_Click(object sender, EventArgs e) {
            //myBitmap.Save(@"C:\Users\" + userName + "\\mandelbrot_config\\Images\\" + saveImageTextBox.Text + ".png");
            myBitmap.Save(@"D:\\c#\\Mandelbrot\Drawing\\images\\" + saveImageTextBox.Text + ".png");
            MessageBox.Show("image saved!");
            saveImageTextBox.Clear();
            
        }

        // About label that shows information about author and program when clicked.
        private void aboutLabel_Click(object sender, EventArgs e) {
            MessageBox.Show("This program has been made by Muhammad Aaliyan and Syed Ehtesham");
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void iterationCountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
