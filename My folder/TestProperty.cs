using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic
{
    public class TestProperty
    {
        //TestProperty() { 
        //}

        //heightProperty._myHeight;
        void Display()
        {

            HeightProperty heightProperty = new HeightProperty();
            Console.WriteLine($"The height is  {heightProperty.myHeight}");
            //heightProperty.myHeight = 4.9; //cant do this as it is get only(read only)
            heightProperty.myWidth = 15; //as both set and get is allowed 
            Console.WriteLine($"After update , now your height is {heightProperty.myWidth}");
        }

        public  void MainSub3()
        {
            TestProperty testProperty = new TestProperty();
            testProperty.Display(); 
        }
    }
}
