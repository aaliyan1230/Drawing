using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace Drawing
{


    public partial class graphb : Form
    {
        Graphics g;

        public graphb()
        {
            InitializeComponent();
            Graphics f = panelGraphFunction.CreateGraphics();
            g = f;
            this.WindowState = FormWindowState.Maximized;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            DrawBackGround();
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

        private void DrawBackGround()
        {
             
            int sizeX = panelGraphFunction.Size.Width;
            int sizeY = panelGraphFunction.Size.Height;


            double minX = -2;
            double maxX = 2;
            double minY = -2;
            double maxY = 2;


            g.Clear(Color.White);

            for (int i = 0; i < sizeX; i += 60)
            {
                g.DrawLine(new Pen(Color.Blue), new Point(i, 0), new Point(i, sizeY));
            }
            for (int i = 0; i < sizeY; i += 60)
            {
                g.DrawLine(new Pen(Color.Blue), new Point(0, i), new Point(sizeX, i));
            }
            g.DrawLine(new Pen(Color.Black), new Point(0, sizeY / 2), new Point(sizeX, sizeY / 2));
            g.DrawLine(new Pen(Color.Black, 2), new Point(sizeX - 10, sizeY / 2 - 10), new Point(sizeX, sizeY / 2));
            g.DrawLine(new Pen(Color.Black, 2), new Point(sizeX - 10, sizeY / 2 + 10), new Point(sizeX, sizeY / 2));
            g.DrawLine(new Pen(Color.Black), new Point(sizeX / 2, 0), new Point(sizeX / 2, sizeY));
            g.DrawLine(new Pen(Color.Black, 2), new Point(sizeX / 2 - 10, 0 + 10), new Point(sizeX / 2, 0));
            g.DrawLine(new Pen(Color.Black, 2), new Point(sizeX / 2 + 10, 0 + 10), new Point(sizeX / 2, 0));
            //for x axis
            for (int i = 30; i < sizeX; i += 60)
            {
                if (i == sizeX / 2) continue;
                string st = (minX + i * ((maxX - minX) / sizeX)).ToString();
                g.DrawLine(new Pen(Color.Black, 2), new Point(i, sizeY / 2 + 5), new Point(i, sizeY / 2 - 5));
                g.DrawString(st, new Font("Arial", 8), new SolidBrush(Color.Black), new PointF(i - 15, sizeY / 2 + 4));
            }
            //for y axis
            for (int i = 30; i < sizeY; i += 60)
            {
                if (i == sizeY / 2) continue;
                string st = (minX + (sizeY - i) * ((maxY - minY) / sizeY)).ToString();
                g.DrawLine(new Pen(Color.Black, 2), new Point(sizeX / 2 + 5, i), new Point(sizeX / 2 - 5, i));
                g.DrawString(st, new Font("Arial", 8), new SolidBrush(Color.Black), new PointF(sizeX / 2 - 15, i + 4));
            }
            string point = "(" + (minX + (maxX - minX) / 2) + "; " + (minX + (maxY - minY) / 2) + ")";
            g.DrawString(point, new Font("Arial", 8), new SolidBrush(Color.Black), new PointF(sizeX / 2 - 15, sizeY / 2 + 4));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawBackGround();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Point pt1 = new Point();
        ComplexPoint initial = new ComplexPoint(0.0, 0.0);
        ComplexPoint const_comp = new ComplexPoint(0.0, 0.0);
        private Point comp_to_pt(ComplexPoint cmp)
        {
            Point return_pt = new Point();
            int X = Convert.ToInt32(cmp.x * 150);
            X += 300;
            int Y = Convert.ToInt32(cmp.y * 150);
            Y += 300;
            return_pt.X = X;
            return_pt.Y = Y;

            return return_pt;

        }

        private ComplexPoint pt_to_comp(Point pt)
        {
            ComplexPoint cmp_pt = new ComplexPoint(0.0, 0.0);
            pt.X -= 300;
            double x = Convert.ToDouble(pt.X);
            x /= 150.00;
            pt.Y -= 300;
            double y = Convert.ToDouble(pt.Y);
            y /= 150.00;
            cmp_pt.x = x;
            cmp_pt.y = y;

            return cmp_pt;
        }

        
        private void panelGraphFunction_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                this.Refresh();
                DrawBackGround();

                pt1 = e.Location;
                ComplexPoint comp = pt_to_comp(pt1);//c
                                                    //z


                Pen pp = new Pen(Color.Red, 1);
                Brush brush = new SolidBrush(Color.Black);
               


               // g.FillEllipse(brush, e.X - 2, e.Y - 2, 5, 5);
              
                initial = new ComplexPoint(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                Point initial_pt = comp_to_pt(initial);
                g.DrawLine(pp, 300, 300, pt1.X, pt1.Y);
               


                    for (int i = 0; i < Convert.ToInt32(textbox1.Text); i++)
                    {
                    if (i==0)
                    {
                        brush = new SolidBrush(Color.Gold);
                    }
                    else if (i==1)
                    {
                        brush = new SolidBrush(Color.DeepPink);
                    }
                    else
                    {
                        brush = new SolidBrush(Color.Black);
                    }
                    
                        initial_pt = comp_to_pt(initial);
                        g.FillEllipse(brush, initial_pt.X - 2, initial_pt.Y - 2, 5, 5);
                        g.DrawLine(pp, initial_pt.X, initial_pt.Y, pt1.X, pt1.Y);
                        pt1 = initial_pt;
                        initial = initial.doCmplxSq();
                        initial = initial.doCmplxAdd(comp);

                    }
                
                
            }


            catch (System.OverflowException)
            {

               
                MessageBox.Show("points out of the boundary of graph, please enter plottable points");
                this.Refresh();
                panelGraphFunction.Refresh();
                Graphics f = panelGraphFunction.CreateGraphics();
                g = f;

                this.Refresh();
                DrawBackGround();
                
            }
        }

        private void panelGraphFunction_Click(object sender, EventArgs e)
        {
           
        }

        private void panelGraphFunction_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
