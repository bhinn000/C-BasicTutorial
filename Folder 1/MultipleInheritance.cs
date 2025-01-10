using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic
{
     interface MultipleInheritance1
    {
        void Dance(); //abstract and public , //must be implemented by child class
    }

    interface MultipleInheritance2 
    {
        void Dance();//same method name as in MultipleInheritance1
    }

    class MultipleInheritClass : MultipleInheritance1 , MultipleInheritance2
    {
        public void Dance() // now doesnt separate whose method is it implementing between two interface
        {
            Console.WriteLine("Let's dance");
        }

        //but to implement separate method for separate interface, we can do it by using, do following
        void MultipleInheritance1.Dance() //interfaceName.itsFunction()
        {
            Console.WriteLine("We are interface 1 dancing");
        }

        void MultipleInheritance2.Dance()
        {
            Console.WriteLine("We are interface 2 dancing");
        }




    }
}
