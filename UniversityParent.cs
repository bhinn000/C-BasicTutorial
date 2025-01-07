using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic
{
    public class UniversityParent
    {

        //public UniversityParent()   //constructor , -implicit- , -parameterless-
        //{
        //    Console.WriteLine("Constructor of parent class");
        //}

        public UniversityParent(string name)
        { //parameterised constructor
            Console.WriteLine($"My name is {name}");
        }
        public void VacationSchedule()
        {
            Console.WriteLine("We have winter and summer vacation");
        }

        public void ExamSchedule() //by default access modifier is "Private"
        {
            Console.WriteLine("Board Exam is coming near");
        }

        private void EmployeeInfo()
        {
            Console.WriteLine("We have 350 employees");
        }

        //static void Main()
        //{
        //    UniversityParent up=new UniversityParent();
        //    up.ExamSchedule();
        //}



    }
}
