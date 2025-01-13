using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic.Collections
{
    public class Student : IComparable<Student>
    {
        int sid;
        string name;
        int marks;

        public Student(int sid, string name, int marks)
        {
            this.name = name;
            this.sid = sid;
            this.marks = marks;
        }

        public static int CompareNames(Student s1, Student s2)
        {
            return s1.name.CompareTo(s2.name);
        }

        static void Main()
        {
            Student s1 = new Student(101, "Sita", 34);
            Student s2 = new Student(111, "Gita", 54);
            Student s3 = new Student(121, "Rita", 24);
            Student s4 = new Student(11, "Ram", 30);

            List<Student> students = new List<Student>() { s1 , s2 , s3 , s4};
            //students.Sort();//can't perform this so use interface IComparable<> so that we can do Sort()
            students.Sort();

          

            AnotherClass ac=new AnotherClass();
            students.Sort(ac);//from other class

            //using delegates --[C] ; this can be done in [D] way
            //Comparison<Student> comparison = new Comparison<Student>(CompareNames);
            //students.Sort(comparison);

            //--[D] instead of this [C] , we can only do 
            students.Sort(CompareNames); //because it implicitly calls Delegate here

            foreach (Student s in students)
            {
                Console.WriteLine(s.name + " " + s.sid + " " + s.marks + "\n");
            }
        }

        //from same class
        public int CompareTo(Student? other)
        {
            if (this.sid > other.sid) return 1;
            else if (this.sid < other.sid) return -1;
            else return 0;
        }

        //from another class
        class AnotherClass : IComparer<Student>
        {
            public int Compare(Student? x, Student? y)
            {
                if (x.marks > y.marks) return 1;
                else if (x.marks < y.marks) return -1;
                else return 0;
            }


        }
    }
}
