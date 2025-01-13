using System;

namespace C_Basic.Extension
{
    public class ExtensionConcept
    {
       
            //if we need to add methods in this class without accessing this class and compiling again , lets say we do have only one method here
            //use extension concept for this , refer "ExtensionUsed" class file
            public void SayName(string s)
            {
                Console.WriteLine($"My name is {s}");
            }

            public void SayBye()
            {
                Console.WriteLine("Bye") ;
            }





        
    }
}

