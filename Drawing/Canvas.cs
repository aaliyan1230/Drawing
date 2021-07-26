using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Drawing {
    class Canvas : Panel {

        static Canvas myCanvas = new Canvas();

        public Canvas() {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            myCanvas.BackColor = System.Drawing.Color.Transparent;

        }

        public void Draw(int x, int y, MouseEventArgs e, Graphics gr) {
            Rectangle rect = new Rectangle(x, y, (int)(e.X - x), (int)(e.Y - y));
            
        }
    }
}
