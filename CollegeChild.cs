using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_Basic
{
    public class CollegeChild:UniversityParent //inheriting
    {

        //CollegeChild() //child's constructor calls "parent's constructor lets say:  abc" implicitly hence "abc" should be public ; while calling parameterized constructor "UniversityParent(string name)" ,cause a problem hence use keyword "base"  here to call "constructor of parent class-which is also parameterised"
        //{
        //    Console.WriteLine("Constructor of child class");
        //}

        //CollegeChild() : base("St.Xavier") //hard coded
        //{
        //    Console.WriteLine("Parameterised child class constructor");
        //}

        CollegeChild(string name) : base(name) //dynamic
        {
            Console.WriteLine("Parameterised child class constructor");
        }

        void RIC()
        {
            Console.WriteLine("We are going for a trip to Pokhara");
        }

        void SportsWeek()
        {
            Console.WriteLine("This is SportsWeek");
        }

        public override void CollegeClassShift(string classShift)
        {
            Console.WriteLine("It has to be defined by us , not university");
        }

        //method hiding/shadowing
        public new void CollegeClassOff() //same "method name" exists in Parent and this hides Parent class similar method , called "Method Hiding/Shadowing"
        {
            Console.WriteLine("It is Saturday and Sunday");
        }

        //using "base" key
        public void TestBaseKey()
        {
            base.TransportInfoUsingBaseKey();
        }

        

        private  static void Main() // Main function can be private too
        {

            CollegeChild cc = new CollegeChild("St.Xavier's");
            //cc.EmployeeInfo();// this method is private hence can't accessed with child's object
            cc.VacationSchedule();
            cc.CollegeClassShift("Morning Shift");
            cc.CollegeClassOff();
            cc.MainSub1();
            //base.TransportInfoUsingBaseKey();// "base" is not applicable in static method
            cc.TestBaseKey(); //calling function which is using 'base' key

            Console.WriteLine("**\nReference and Instance Concept**");
            UniversityParent upRef;
            CollegeChild ccInst = new CollegeChild("CollegeName");
            upRef = cc;//   "upRef" : is reference of parent created using child's class , this cant access child's pure class but can access overridden method of own
            upRef.CollegeClassShift("Evening"); // is overridden method so display overridden one
            upRef.CollegeClassOff(); //shows parent output as methodHiding
                                     //upRef.TestBaseKey(); // cant access child's method

            //operator overloading
            Console.WriteLine("**\nOPERATOR OVERLOADING**");
            string name = "Ram ";
            string surname = "Ayodhya";
            string fullName = name + surname; //here +  is used for concatenation
            Console.WriteLine(fullName);
            int num1 = 1;
            int num2 = 2;
            int num = num1 + num2;//here +  is used for addition
            Console.WriteLine(num);
            //we can make custom functions for operator overloading ; --check Matrix class for this--
            Matrix matrix1 = new Matrix(1, 2, 3, 4);
            Matrix matrix2 = new Matrix(1, 2, 3, 4);
            Matrix matrixResult = matrix1 + matrix2;
            Console.WriteLine(matrixResult); // by default this gives C_Basic.Matrix now , override the method in Matrix 
            Console.WriteLine("**\nABSTRACT**");
            FigureAbstract figureAbstract = new Circle(4);
            Console.WriteLine(figureAbstract.GetArea());
            Console.WriteLine("**\nINTERFACE**");
            //ITestInterface itestInterfaceInstance = new ITestInterface(); //cant create instance of an interface
          
            ITestInterface itestInterfaceRef;  //but can create reference using child class instance
            TestClass testClassInstan= new TestClass();
            itestInterfaceRef = testClassInstan;
            itestInterfaceRef.Display();//and can call the method

            ITestInterface itestInterface = new TestClass();
            itestInterface.Display();

            Console.WriteLine("**\nMULTIPLE INHERITANCE**");
            MultipleInheritClass multipleInheritClass = new MultipleInheritClass();
            multipleInheritClass.Dance();//ambigious, due to this, for both interface's method , single implementation is being executed 

            //now to access the Dance() of each interface, reference of interface has to be made
            MultipleInheritance1 mi1 = multipleInheritClass;
            MultipleInheritance2 mi2 = multipleInheritClass;
            mi1.Dance();
            mi2.Dance();

            Console.WriteLine("**\nPROPERTY1**");
            TestProperty testProperty = new TestProperty();
            testProperty.MainSub3();

            Console.WriteLine("**\nPROPERTY2**");
            TestCustomer testCustomer = new TestCustomer();
            testCustomer.MainSub();

            Console.WriteLine("**\nDELEGATE**");
            EmployeeDelegate employeeDelegate = new EmployeeDelegate();
            employeeDelegate.MainSub();// another way of calling this function is to use Delegate

        }
        //cc.EmployeeInfo(); 
        //cc.VacationSchedule();

    }
}
