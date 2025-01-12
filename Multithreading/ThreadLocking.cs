using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic.Multithreading
{
    internal class ThreadLocking
    {
        void Display()
        {
            Console.Write("Ram is ");
            Thread.Sleep(2000);
            Console.WriteLine("Nepali");

        }

        void DisplayLock()
        {
            lock (this)
            {
                Console.Write("Shyam is ");
                Thread.Sleep(2000);
                Console.WriteLine("Nepali");
            }

        }
        static void Main()
        {
            ThreadLocking threadLocking=new ThreadLocking();
            threadLocking.Display(); //single thread
            threadLocking.Display(); //single thread
            //above executes after completing one

            //following, depend upon the thread executing , also there is Thread.Sleep hence may not run the whole logic inside function first hence we have lock the logic of the function so that the function's logic completes and make sense
            Thread t1 = new Thread(threadLocking.Display);
            Thread t2 = new Thread(threadLocking.Display);
            Console.WriteLine("Main Thread here");
            t1.Start();
            t2.Start();
            Console.WriteLine("I am also Main thread");

            Thread t3 = new Thread(threadLocking.DisplayLock);
            Thread t4 = new Thread(threadLocking.DisplayLock);
            t3.Start();
            t4.Start();

            t1.Join();
            t2.Join();
            t3.Join(3000); //main thread wait this thread for 3 ms 
            t4.Join();


            //To make the main thread at last only , we have to use Join() , otherwise it would run anytime
            Console.WriteLine("This is run by Main Thread: I will run at the end of the program this is because of t.join()"); 

            





        }
    }
}
