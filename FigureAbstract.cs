using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic
{
        public abstract class FigureAbstract // any class that contains abstract methods must be mentioned as abstract and is abstract
        
    {
        //public FigureAbstract() { } //no compulsion to make the "constructor of parent which is abstract" to public as it wont be used to create object ; abstract classes cant be instantiated directly


        public int width, height , radius; //variables that may be used by the methods
        public const float pi=3.14f;
        public abstract double GetArea(); //child must implement the abstract methods

    }

    class Rectangle : FigureAbstract
    { 
         public Rectangle(int width, int height)
        { 
                this.width=width;
                this.height=height;
        }

        public override double GetArea() //must be implemented
        {
            return width * height;
        }

    }



    class Circle: FigureAbstract
    {
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return pi * radius *radius;
        }

        public static void MainSub2()
        {
            //FigureAbstract figureAbstract=new FigureAbstract(); //this is not allowed , it should be instantiated using derived class
            FigureAbstract figureAbstract = new Circle(4);
            Console.WriteLine(figureAbstract.GetArea());
        }
    }

    


}
