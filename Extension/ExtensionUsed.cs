using System;

namespace C_Basic.Extension
{
	public static  class ExtensionUsed //class must be static too
	{

	

			//this is extension method for "ExtensionConcept" class file
			//the extension method must be "static" , the first parameter is for binding with targeted class using "this" keyword
			//to check if it is working, refer to "TestExtension" class file
			public static void SayAddress(this ExtensionConcept ec, string s)
			{
				Console.WriteLine($"I live in {s}");
			}

			//same method name in extension but the method from original class is executed
			public static void SayBye(this ExtensionConcept ec)
			{
				Console.WriteLine("Bye Bye");
			}


    }
}
