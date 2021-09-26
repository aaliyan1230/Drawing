using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing {
   
    /// ComplexPoint class is used encapsulate a single complex point
    /// Z = x + i*y where x and y are the real and imaginary parts respectively.
    
    public class ComplexPoint {
        public double x;
        public double y;

       
        public ComplexPoint(double x, double y) {
            this.x = x;
            this.y = y;
        }

     
        public double doModulus() {
            return Math.Sqrt(x * x + y * y);
        }

       
        public double doMoulusSq() {
            return x * x + y * y;
        }

      
        public ComplexPoint doCmplxSq() {
            ComplexPoint result = new ComplexPoint(0, 0);
            result.x = x * x - y * y;
            result.y = 2 * x * y;

            return result;
        }

       
        public ComplexPoint doCmplxAdd(ComplexPoint arg) {
            x += arg.x;
            y += arg.y;

            return this;
        }

      
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
