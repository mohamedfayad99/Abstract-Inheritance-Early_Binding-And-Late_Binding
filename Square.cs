using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4
{
    class Square : Perimeter
    {


        public Square() : base(100, 0, 0)
        { }

        public Square(double _x, double _y, double _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        #region With Early Binding
        //public double perimet()
        //{
        //    return x * 4;
        //} 
        #endregion

        #region With Late Binding
        public override double perimet()
        {
            return x * 4;
        } 
        #endregion
    }
}
