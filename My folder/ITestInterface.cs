using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic
{
     interface ITestInterface // by default , the access modifier is public
                              //only contains abstract "methods body"  which its child must implement
    {
       static int a;//interface can't contain non-static field 
       void Display();//by default the method is public and it is abstract
       
    }

    interface ITestChildInterface : ITestInterface
    {
        void Hide();//it is also abstract and public
        //dont implement the abstract method of "parent interface" in "child interface" but have to do same in "child class" of the "parent interfac"e
    }

    class TestClass : ITestInterface 
    {
        public void Display()//while implementing in the child class, not to  mention keyword 'override' 
        {
            Console.WriteLine("Test Class which is child of interface");
        }
    }
}
