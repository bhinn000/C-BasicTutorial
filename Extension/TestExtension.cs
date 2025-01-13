using System;

namespace C_Basic.Extension
{
    public class TestExtension
    {

            static void Main()
            {
                ExtensionConcept ec = new ExtensionConcept();
                ec.SayName("Bhintuna");
                ec.SayAddress("Nepal");
                ec.SayBye();
            }
        
    }
}
