using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4
{
    abstract class Perimeter
    {
        public double x;
        public double y;
        public double z;
        public Perimeter()
        {
            x = y = z = 10;
        }
        public Perimeter(double _x, double _y, double _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
        #region With Early Binding
        //public double perimet() { return 111; } 
        #endregion

        #region with Late Binding
        public virtual double perimet() { return 111; }  
        #endregion

    }
}
