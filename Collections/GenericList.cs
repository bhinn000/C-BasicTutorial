using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic.Collections
{
    internal class GenericList
    {
        public bool Compare(object a, object b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CompareMe<T>(T a, T b) //when this function is called and type is defined
        {
            if (a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        static void Main()
        {
            List<int> li = new List<int>();
            li.Add(10);
            //li.Add(20.5); //cant do this because this is double but "li" is "list of int"

            GenericList genericList = new GenericList();
            //bool result=genericList.Compare(10, 10);
            bool result = genericList.Compare(10.5f, "10"); //not type safe
            //bool result = genericList.Compare(10.5f, 10.5f);//when a==b done, it will give "false" value 
            Console.WriteLine(result);

            bool resultMe = genericList.CompareMe<int>(2, 3); //now when int is sent then it sets the type for parameters too

            //we can also set the type <T> to the class as whole 



        }
    }

}
