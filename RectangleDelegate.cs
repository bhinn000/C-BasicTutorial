using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic
{
    public delegate void ThisDelegate(int x, int y);//defining
    internal class RectangleDelegate
    {
        void GetArea(int width, int height)
        {
            Console.WriteLine($"The area is {width* height}");
        }

        void GetPerimeter(int width, int height)
        {
            Console.WriteLine($"The area is {2 * (width + height)}");
        }

        public void MainSub()
        {
            RectangleDelegate rectDelegate = new RectangleDelegate();
            ThisDelegate obj = new ThisDelegate(rectDelegate.GetArea); //instantiating
            obj += rectDelegate.GetPerimeter;//instantiating for another method

            obj.Invoke(2, 3); // now this will call both methods : area and perimeter for same params

        }
    }

}
