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

        //method overloading
        public void  CollegeDetail(string collegeName, string address) 
        { 
            Console.WriteLine($"{collegeName} {address}");
        }

        public void CollegeDetail(string collegeName, string address , string University)
        {
            Console.WriteLine($"{collegeName} , {address} , {University}");
        }

        //public int CollegeDetail(string collegeName, string address) //this collides as the function with similar parameter exists , it wont be count as different depending upon the "return type"
        //{
        //    return 1;
        //}

        //method overriding
        public virtual void CollegeClassShift(string classShift)
        {
            Console.WriteLine($"Class Shift is {classShift}");
        }

        //this will be shadowed by child's same named method -method hiding
        public void CollegeClassOff()
        {
            Console.WriteLine("It is Saturday only");
        }

        public void VacationSchedule()
        {
            Console.WriteLine("We have winter and summer vacation");
        }

        public void ExamSchedule() //by default access modifier is "Private"
        {
            Console.WriteLine("Student's Board Exam is coming near");
        }

        private void EmployeeInfo()
        {
            Console.WriteLine("We have 350 employees");
        }

        public void TransportInfoUsingBaseKey()
        {
            Console.WriteLine("We also have transportation service");
        }

        public void MainSub()
        {
            Console.WriteLine("*********");
            UniversityParent up = new UniversityParent("SXC");
            up.ExamSchedule();

            Console.WriteLine("*********");

            //up.CollegeDetail("SXC" , "Maitighar"); //method overloading

        }



    }
}
