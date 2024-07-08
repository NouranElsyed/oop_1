using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_1
{
    internal struct point01
    {
        public double x;    
        public double y;
        public point01(int _x , int _y) { 
        
        x=_x; y= _y;
        }
        public point01(int Number)
        {
            x=y=Number; 
        }
        public override string ToString()
        {
            return $"({this.x},{this.y})";
        }
    }
}
