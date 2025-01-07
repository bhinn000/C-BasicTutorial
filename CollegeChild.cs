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

        
          public static void Main()
        {
            CollegeChild cc = new CollegeChild("St.Xavier's");
            //cc.EmployeeInfo();// this method is private hence can't accessed with child's object
            cc.VacationSchedule();


        }
        //cc.EmployeeInfo(); 
        //cc.VacationSchedule();
       
    }
}
