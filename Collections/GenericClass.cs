using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic.Collections
{
    public class GenericClass<T>
    {
        //T Add<T>(T a, T b)
        //{
        //    dynamic d1=a;
        //    dynamic d2=b;
        //    return d1+d2;  
        //}

        //T Sub<T>(T a, T b)
        //{
        //    dynamic d1 = a;
        //    dynamic d2 = b;
        //    return d1 - d2;
        //}

        public T Add(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return d1 + d2;
        }

        public T Sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return d1 - d2;
        }

        
        
    }

    class Program
    {
        static void Main()
        {
            //when type in the class is not defined while mentioning <T> in every methods
            //GenericClass genericClass = new GenericClass();
            //Console.WriteLine(genericClass.Add<int>(1, 2)); 

            //mentioning <T> in the class
            GenericClass<int> genericClass = new GenericClass<int>();
            Console.WriteLine($"The sum is {genericClass.Add(1, 2)}");



        }
    }
}
