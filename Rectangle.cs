using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4
{
    class Rectangle : Perimeter
    {

        public Rectangle()
        {

        }
        public Rectangle(double _x, double _y, double _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
        #region With Early Binding
        //public double perimet()
        //{
        //    return (x + y) * 2;
        //}
        #endregion

        #region With Late Binding
        public override double perimet()
        {
            return (x + y) * 2;
        } 
        #endregion

    }
}
