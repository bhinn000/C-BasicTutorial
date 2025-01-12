using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace C_Basic.Multithreading
{
    internal class ThreadPerformance
    {
        static void func1()
        {
            long count = 0;
            for (long i = 0; i < 10000000000; i++)
            {
                count++;
            }
            Console.WriteLine($"Count 1 is {count} ");
        }

        static void func2()
        {
            long count = 0;
            for (long i = 0; i < 10000000000; i++)
            {
                count++;
            }
            Console.WriteLine($"Count 2 is {count} ");
        }

        static void Main()
        {

            //--using thread
            Thread t1= new Thread(func1);
            Thread t2 = new Thread(func2);

            Stopwatch s1=new Stopwatch();
            s1.Start();
            t1.Start();
            t2.Start();
            s1.Stop();

            Console.WriteLine($"Time taken using thread is {s1.ElapsedMilliseconds}");
            //--using thread

            //--without using thread
            Stopwatch s2 = new Stopwatch();
            s2.Start();
            func1();
            func2();
            s2.Stop();

            Console.WriteLine($"Time taken without using thread is {s2.ElapsedMilliseconds}");
            //--without using thread

        }
    }
}
