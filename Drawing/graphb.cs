using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
        }

        private void DrawBackGround()
        {
            int sizeX = panelGraphFunction.Size.Width;
            int sizeY = panelGraphFunction.Size.Height;


            double minX = -2;
            double maxX = 2;
            double minY = -2;
            double maxY = 2;


            g.Clear(Color.White);

            for (int i = 0; i < sizeX; i += 40)
            {
                g.DrawLine(new Pen(Color.Blue), new Point(i, 0), new Point(i, sizeY));
            }
            for (int i = 0; i < sizeY; i += 40)
            {
                g.DrawLine(new Pen(Color.Blue), new Point(0, i), new Point(sizeX, i));
            }
            g.DrawLine(new Pen(Color.Black), new Point(0, sizeY / 2), new Point(sizeX, sizeY / 2));
            g.DrawLine(new Pen(Color.Black, 2), new Point(sizeX - 10, sizeY / 2 - 10), new Point(sizeX, sizeY / 2));
            g.DrawLine(new Pen(Color.Black, 2), new Point(sizeX - 10, sizeY / 2 + 10), new Point(sizeX, sizeY / 2));
            g.DrawLine(new Pen(Color.Black), new Point(sizeX / 2, 0), new Point(sizeX / 2, sizeY));
            g.DrawLine(new Pen(Color.Black, 2), new Point(sizeX / 2 - 10, 0 + 10), new Point(sizeX / 2, 0));
            g.DrawLine(new Pen(Color.Black, 2), new Point(sizeX / 2 + 10, 0 + 10), new Point(sizeX / 2, 0));

            for (int i = 40; i < sizeX; i += 80)
            {
                if (i == sizeX / 2) continue;
                string st = (minX + i * ((maxX - minX) / sizeX)).ToString();
                g.DrawLine(new Pen(Color.Black, 2), new Point(i, sizeY / 2 + 5), new Point(i, sizeY / 2 - 5));
                g.DrawString(st, new Font("Arial", 8), new SolidBrush(Color.Black), new PointF(i - 15, sizeY / 2 + 4));
            }
            for (int i = 40; i < sizeY; i += 80)
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
        private Point comp_to_pt(ComplexPoint cmp)
        {
            Point return_pt = new Point();
            int X = Convert.ToInt32(cmp.x * 100);
            X += 200;
            int Y = Convert.ToInt32(cmp.y * 100);
            Y += 200;
            return_pt.X = X;
            return_pt.Y = Y;

            return return_pt;
        }
        
       
        private void panelGraphFunction_MouseDown(object sender, MouseEventArgs e)
        {
            pt1 = e.Location;


            pt1.X -= 200;
            double x = Convert.ToDouble(pt1.X);
            x /= 100.00;
            pt1.Y -= 200;
            double y = Convert.ToDouble(pt1.Y);
            y /= -100.00;
           

            Pen pp = new Pen(Color.Red, 2);
            Brush brush = new SolidBrush(Color.Red);
            g.FillEllipse(brush,e.X,e.Y,10,10);
            MessageBox.Show(x.ToString() + " , " + y.ToString());
            

            /* Rectangle ellipseBounds = new Rectangle(pt1.X, pt1.Y, pt1.X+5, pt1.Y+5); //like in your code sample
             using (Brush brush = new SolidBrush(Color.Red))
             {
                 g.FillPie(brush, ellipseBounds, pt1.X,pt1.Y); //for example, do it before drawing lines.
                 g.DrawEllipse(pp, ellipseBounds);

                 Rectangle r = new Rectangle();
                 r.Location = pt1;
                 //r.X = pt1.X;
                 //r.Y= pt1.Y;
                 g.DrawEllipse(pp, r);




             }
            */
        }
    }
}
