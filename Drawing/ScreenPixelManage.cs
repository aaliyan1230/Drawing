using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing {

    /// <summary>
    /// ScreenPixelManage class. Handles the conversions between mathematical
    /// units and physical screen coordinates, i.e. pixel coordinates. The
    /// underlying mathematical coordinates are independent of screen resolution
    /// and size, whereas pixel coordinates are applicable to run-time screen
    /// dimensions.
    /// </summary>
    public class ScreenPixelManage {
        public int xPixel;
        public int yPixel;
        private double convConstX1;
        private double convConstX2;
        private double convConstY1;
        private double convConstY2;

        /// <summary>
        /// Simple class used to define a pixel's coordinates.
        /// </summary>
        public class PixelCoord {
            public int xPixel;
            public int yPixel;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="screenBottomLeftCorner"></param>
        /// <param name="screenTopRightCorner"></param>
        public ScreenPixelManage(Graphics graphics, ComplexPoint screenBottomLeftCorner, ComplexPoint screenTopRightCorner) {
            
            // Transform from mathematical to pixel coordinates.
            //
            // The following are long-handed calulations, now replaced with more efficient calculations
            // using convConst** values.
            //       this.xPixel = (int) ((graphics.VisibleClipBounds.Size.Width) / (screenTopRightCorner.x - screenBottomLeftCorner.x) * (cmplxPoint.x - screenBottomLeftCorner.x));
            //       this.yPixel = (int) (graphics.VisibleClipBounds.Size.Height - graphics.VisibleClipBounds.Size.Height / (screenTopRightCorner.y - screenBottomLeftCorner.y) * (cmplxPoint.y - screenBottomLeftCorner.y));

            convConstX1 = graphics.VisibleClipBounds.Size.Width / (screenTopRightCorner.x - screenBottomLeftCorner.x);
            convConstX2 = convConstX1 * screenBottomLeftCorner.x;

            convConstY1 = graphics.VisibleClipBounds.Size.Height * (1.0 + screenBottomLeftCorner.y / (screenTopRightCorner.y - screenBottomLeftCorner.y));
            convConstY2 = graphics.VisibleClipBounds.Size.Height / (screenTopRightCorner.y - screenBottomLeftCorner.y);
        }

        /// <summary>
        /// Convert from maths coordinates to pixel coordinates.
        /// </summary>
        /// <param name="cmplxPoint">Complex number (mathematical coordiantes)</param>
        /// <returns>Pixel coordinate, also a complex number but represented
        /// as an X,Y screen coordinate</returns>
        public PixelCoord GetPixelCoord(ComplexPoint cmplxPoint) {
            PixelCoord result = new PixelCoord();
            result.xPixel = (int) (convConstX1 * cmplxPoint.x - convConstX2);
            result.yPixel = (int) (convConstY1 - convConstY2 * cmplxPoint.y);
            return result;
        }

        /// <summary>
        /// Converts a pixel-coordinate increment (small change in X, Y
        /// screen coordiante) to the corresponding increment in mathematical
        /// coordinates. This is used, for example, when drawing the Mandlebrot
        /// set with chosen X, Y pixel steps, for which the cooresponding
        /// mathematical steps need to be known.
        /// 
        /// This is done using the transformation functions that convert
        /// from maths coordinates to pixel coordinates. If these are 
        /// respectively:
        /// 
        /// Fx() and Fy() for the x and y domains, then to convert in the
        /// opposite direction, from pixels to maths coordinates we need
        /// to use:
        /// 
        /// dFx()/dx and dFy()/dy (which are the derivates of each function),
        /// then multiply each by the corresponding pixel increments in
        /// either x or y.
        /// 
        /// This implementation uses pre-calculated constant scale factors
        /// for an efficient implementation.
        /// 
        /// </summary>
        /// <param name="pixelCoord">Screen coordinate</param>
        /// <returns></returns>
        public ComplexPoint GetDeltaMathsCoord(ComplexPoint pixelCoord) {
            ComplexPoint result = new ComplexPoint(
                   pixelCoord.x / convConstX1,
                   pixelCoord.y / convConstY2);
            return result;
        }

        /// <summary>
        /// Get absolute maths coordinate from pixel coordinate. This is effectively
        /// an inverse calcuate: given a pixel screen coordinate it returns the
        /// corresponding mathematical point.
        /// </summary>
        /// <param name="pixelCoord">Screen coordinate</param>
        /// <returns>Mathematical point corresponding to pixelCoord</returns>
        public ComplexPoint GetAbsoluteMathsCoord(ComplexPoint pixelCoord) {
            ComplexPoint result = new ComplexPoint(
                   (convConstX2 + pixelCoord.x) / convConstX1,
                   (convConstY1 - pixelCoord.y) / convConstY2);
            return result;
        }
    }
}
