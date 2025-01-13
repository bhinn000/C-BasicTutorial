using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//need of generic delegate ; instead of doing in this way you can refer to GenericDelegates2
namespace C_Basic.My_folder
{
    public delegate double Sum1Delegate(int x, float y, double z);
    public delegate void Sum2Delegate(int x, float y, double z);
    public delegate bool CheckMeDelegate(int value);

    internal class GenericDelegates
    {
        //func, action, predicates => with return value , without return value , with bool as return value

        public static double sum1(int x , float y , double z)
        {
            return x+ y + z;    
        }

        public static void sum2(int x, float y, double z)
        {
            Console.WriteLine($"The sum is { x + y + z }");
        }

        public static bool checkMe(int value)
        {
            return true;
        }

        static void Main()
        {
            Sum1Delegate sum1Delegate = new Sum1Delegate(sum1);
            double sum = sum1Delegate.Invoke(1, 2.4f, 2.5);
            Console.WriteLine(sum);

            Sum2Delegate sum2Delegate = new Sum2Delegate(sum2);
            sum2Delegate.Invoke(1, 2.4f, 2.5);

            CheckMeDelegate checkMeDelegate = new CheckMeDelegate(checkMe);
            sum2Delegate.Invoke(1, 2.4f, 2.5);
            bool isTrue = checkMeDelegate.Invoke(4);
            Console.WriteLine(isTrue);


        }


    }
}
