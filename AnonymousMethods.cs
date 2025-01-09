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
        

        static void Main()
        {
            //GreetingsDelegate greetingsDelegate = new GreetingsDelegate(Greetings);
            //String greet= greetingsDelegate("Shyam");
            //Console.WriteLine(greet);

            //instead of above we can do following: anonymous method, a method with a name
            GreetingsDelegate greetingsDelegate = delegate (string name) // the return type of this has been defined in the delegate "GreetingsDelegate" as string
                                                                         // , suitable for few lines of code
            {
                return "Hello " + name;
            };
        }
    }
}
