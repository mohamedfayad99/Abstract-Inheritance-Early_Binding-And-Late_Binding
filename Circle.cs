using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace day_4
{
    class Circle : Perimeter
    {
        public Circle() { }

        public Circle(double _x, double _y, double _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
        #region With Early Binding
        //public double perimet()
        //{
        //    return Math.PI * x * 2;
        //} 
        #endregion

        #region With Late Binding
        public override double perimet()
        {
            return Math.PI * x * 2;
        }
        #endregion
    }
}
