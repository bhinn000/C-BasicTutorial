using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic
{
    internal class HeightProperty
    {
        public double ourHeight; //if made public , this can be both access and modify by other classes
                                 //so as a solution, properties can be used

        double _myHeight=5.6;//way to represent , the level of accessing and modifying is maintained by property "myHeight"
        int _myWidth;
        public double myHeight
        {
            get { return _myHeight; }
            //set { _myHeight = value; } //value is implicit and also of same type as _myHeight
        }

        public int myWidth
        {
            get { return _myWidth; }
            set { 
                if(value> _myWidth)  // we can also check the condition to verify before modifying "myWidth"
                {
                    _myWidth = value;
                }
            }
               
        }
    }
}
