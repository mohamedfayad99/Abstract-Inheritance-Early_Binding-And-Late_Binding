using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4
{
    class Triangle : Perimeter
    {
        public Triangle()
        {

        }
        public Triangle(double _x, double _y, double _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        #region with  Early Binding
        //public double perimet()
        //{
        //    return x + y + z;
        //} 
        #endregion

        #region With Late Binging
        public override double perimet()
        {
            return x + y + z;
        } 
        #endregion


    }
}
