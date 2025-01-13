using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic
{
    public delegate string GreetingsDelegate(string name1);
    public class AnonymousMethods
    {
        //--[A] : instead of writing this function and binding into delegate and invoking , we can [B] method called as Anonymous methods
        //public string Greetings(string name)
        //{
        //    return "Hello " + name;
        //}

        public static void Main()
        {
            //--[A]
            //GreetingsDelegate greetingsDelegate = new GreetingsDelegate(Greetings);
            //String greet= greetingsDelegate("Shyam");
            //Console.WriteLine(greet);

            // --[B] : instead of above we can do following: anonymous method, a method with a name
            GreetingsDelegate greetingsDelegate = delegate (string name) // the return type of this has been defined in the delegate "GreetingsDelegate" as string
                                                                         // , suitable for few lines of code
            {
                return "Hello " + name;
            };
            string greet=greetingsDelegate.Invoke("Nepal");
            Console.WriteLine(greet);

        }
    }
}
