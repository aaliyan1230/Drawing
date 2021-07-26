using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing {
    /// <summary>
    /// ComplexPoint class is used encapsulate a single complex point
    /// Z = x + i*y where x and y are the real and imaginary parts respectively.
    /// A number of complex arithmetic utility methods are provided.
    /// </summary>
    public class ComplexPoint {
        public double x;
        public double y;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="x">real part of complex point</param>
        /// <param name="y">imaginary part of complex point</param>
        public ComplexPoint(double x, double y) {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Calculate the modulus |Z| = Sqrt(x*x + y*y).
        /// </summary>
        /// <returns>Modulus of complex point</returns>
        public double doModulus() {
            return Math.Sqrt(x * x + y * y);
        }

        /// <summary>
        /// Calculate modulus squared |Z|**2 = X*x + y*y.
        /// </summary>
        /// <returns>Modulus squared</returns>
        public double doMoulusSq() {
            return x * x + y * y;
        }

        /// <summary>
        /// Calculate the square of complex point, Z**2. The
        /// result is another complex number: (x*x - y*y) + i*2*x*y.
        /// </summary>
        /// <returns>Square of complex point</returns>
        public ComplexPoint doCmplxSq() {
            ComplexPoint result = new ComplexPoint(0, 0);
            result.x = x * x - y * y;
            result.y = 2 * x * y;

            return result;
        }

        /// <summary>
        /// Add complex value, arg, to this complex point, Z. The result is
        /// another complex number.
        /// </summary>
        /// <param name="arg">Complex number to add</param>
        /// <returns>Z + arg</returns>
        public ComplexPoint doCmplxAdd(ComplexPoint arg) {
            x += arg.x;
            y += arg.y;

            return this;
        }

        /// <summary>
        /// Calculate complex square plus complex constant. The result
        /// is another complex number.
        /// </summary>
        /// <param name="arg"></param>
        /// <returns>Z**2 + arg</returns>
        public ComplexPoint doCmplxSqPlusConst(ComplexPoint arg) {
            ComplexPoint result = new ComplexPoint(0, 0);
            result.x = x * x - y * y;
            result.y = 2 * x * y;
            result.x += arg.x;
            result.y += arg.y;
            return result;
        }
    }
}
