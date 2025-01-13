using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic.My_folder
{
    public  class LambdaExpression
    {
        public delegate string GreetingsDelegate(string name1);
        public static void Main()
        {


            //Instead using delegate keyword use lambda expressions for anonymous method
            //GreetingsDelegate greetingsDelegate = delegate (string name) 
            //                                                             
            //{
            //    return "Hello " + name;
            //};
            //string greet = greetingsDelegate.Invoke("Nepal");
            //Console.WriteLine(greet);

            GreetingsDelegate greetingsDelegate = (name) =>                                                                        
            {
                return "Hello " + name;
            };
            string greet = greetingsDelegate.Invoke("Nepal");
            Console.WriteLine(greet);


        }
    }
}
