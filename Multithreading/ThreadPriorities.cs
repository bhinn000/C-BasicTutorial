using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace C_Basic.Multithreading
{
    internal class ThreadPriorities
    {
        static long count1, count2;
        
        public static void IncrementCount1()
        {
            while (true)
            {
                count1 += 1;
            }
        }

        public static void IncrementCount2()
        {
            while (true)
            {
                count2 += 1;
            }
        }

        static void Main()
        {
            Thread t1 = new Thread(IncrementCount1);
            Thread t2 = new Thread(IncrementCount2);

            t1.Priority= ThreadPriority.Lowest;//uses lesser CPU resourcess
            t2.Priority=ThreadPriority.Highest;

            t1.Start();
            t2.Start();

            Console.WriteLine($"Count 1 is {count1}");
            Console.WriteLine($"Count 2 is {count2}");
        }
    }
}
