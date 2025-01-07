using System;
using System.Collections.Generic;
using System.Linq;
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


        public static void Main()
        {
            CollegeChild cc = new CollegeChild("St.Xavier's");
            //cc.EmployeeInfo();// this method is private hence can't accessed with child's object
            cc.VacationSchedule();
            cc.CollegeClassShift("Morning Shift");
            cc.CollegeClassOff();
            cc.MainSub();
            //base.TransportInfoUsingBaseKey();// "base" is not applicable in static method
            cc.TestBaseKey(); //calling function which is using 'base' key

            Console.WriteLine("****Reference and Instance Concept****");
            UniversityParent upRef;
            CollegeChild ccInst = new CollegeChild("CollegeName");
            upRef = cc;//   "upRef" : is reference of parent created using child's class , this cant access child's pure class but can access overridden method of own
            upRef.CollegeClassShift("Evening"); // is overridden method so display overridden one
            upRef.CollegeClassOff(); //shows parent output as methodHiding
            //upRef.TestBaseKey(); // cant access child's method

        }
        //cc.EmployeeInfo(); 
        //cc.VacationSchedule();

    }
}
