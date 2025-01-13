using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//need of generic delegate ; instead of doing in this way you can refer to GenericDelegates2
namespace C_Basic.My_folder
{
  

    internal class GenericDelegates2
    {
        //func, action, predicates => with return value , without return value , with bool as return value

        //public static double sum1(int x , float y , double z)
        //{
        //    return x+ y + z;    
        //}

        //public static void sum2(int x, float y, double z)
        //{
        //    Console.WriteLine($"The sum is { x + y + z }");
        //}

        //public static bool checkMe(int value)
        //{
        //    return true;
        //}

        static void Main()
        {
            ////no need to use delegates now instead do following
            //Func<int, float, double , double> sum1Delegate = sum1; //takes parameter int, float, double and double is the return type
            //double sum=sum1Delegate.Invoke(1, 2.4f , 2.5);
            //Console.WriteLine(sum);

            //Action<int, float, double> sum2Delegate = sum2;
            //sum2Delegate.Invoke(1, 2.4f, 2.5);

            //Predicate<int> checkMeDelegate = checkMe;
            //bool isTrue=checkMeDelegate.Invoke(4);
            //Console.WriteLine(isTrue);

            //doing above login using lambda ,

            //no need to use delegates now instead do following
            Func<int, float, double, double> sum1Delegate = (x,y,z) =>
            {
                return x + y + z;
            }; //takes parameter int, float, double and double is the return type
            double sum = sum1Delegate.Invoke(1, 2.4f, 2.5);
            Console.WriteLine(sum);

            Action<int, float, double> sum2Delegate = (x, y, z) =>
            {
                Console.WriteLine($"The sum is {x + y + z}");
            }; 
            sum2Delegate.Invoke(1, 2.4f, 2.5);

            Predicate<int> checkMeDelegate = x =>{ return true; };
            bool isTrue = checkMeDelegate.Invoke(4);
            Console.WriteLine(isTrue);


        }


    }
}
