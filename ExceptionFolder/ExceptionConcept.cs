using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic.ExceptionFolder
{
    public class ExceptionConcept
    {
        static void Main()
        {
            try
            {
                int a, b;
                Console.WriteLine("Enter value of a: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter value of b: ");
                b = int.Parse(Console.ReadLine());
                if (b == 1)
                {
                    return; //even when this is satisfied, "finally" is executed
                }
                if (b % 2 != 0)//Application Exception
                {
                    //Application Exception has "readonly virtual property"
                    throw new ApplicationException("You can only allow even value in divisor");
                }
                int c = a / b;
                Console.WriteLine($"The result is : {c}");
                Console.WriteLine("Let me end the line"); // when b is 0 , this is not executed , abnormal execution
                //if try does not work this line wont be executed
            }
            catch(DivideByZeroException de)
            {
                Console.WriteLine("Can't divide by zero");
            }
            catch(FormatException fe)
            {
                Console.WriteLine("Give numerical value");
            }
            catch(Exception ex)//the exception which both of "catch" could not handled by this  is handled here
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("End of the line");//at any cost this line is executed , either try or catch
            }
          

        }

    }
}
