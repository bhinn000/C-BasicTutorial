using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace C_Basic.Multithreading
{
    internal class MultiThreadConcept
    {
        static void Test1()
        {
            Console.WriteLine("Thread 1 started");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Test 1 : " + i + "\n");
            }
            Console.WriteLine("Thread 1 completed");
        }

        static void Test2()
        {
            Console.WriteLine("Thread 2 started");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Test 2 : " + i + "\n");
                if (i == 15)
                { 
                    Console.WriteLine("Thread 2 is going to sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("Thread 2 just woke up");
                }
            }
            Console.WriteLine("Thread 2 completed");
        }

        static void Test3(object n) //for this use parameterized threadstart
        {
            int n1 = Convert.ToInt32(n);
            Console.WriteLine("Thread 3 started");
            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine("Test 3 : " + i + "\n");
            }
            Console.WriteLine("Thread 3 completed");
        }
        static void Main()
        {
            //number of threads here is 3 including t1, t2 and Main thread; Main Thread runs first
            ThreadStart obj=new ThreadStart(Test1); //creating delegate explicitly ; 1st way
            //ThreadStart obj = Test; //2nd way
            Thread t1 = new Thread(obj); //1st way
            //Thread t1 = new Thread(Test1);//3rd way
            //ThreadStart obj = () => Test1();//4th way

            t1.Start();
            Thread t2 = new Thread(Test2);//in this way, delegate of "ThreadStart" is created implicitly by clr
            t2.Start(); 

            Console.WriteLine("I am Main Thread");
            Thread.Sleep(15000);
            Console.WriteLine("Main Thread just woke up");
            Console.WriteLine("Main thread is exiting");

            //for parameterized function, use this type of thread delegate
            ParameterizedThreadStart pobj = new ParameterizedThreadStart(Test3);
            Thread t3 = new Thread(pobj);
            t3.Start(30);


            
          
        }
    }
}
