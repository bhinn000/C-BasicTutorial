namespace C_Basic
{
    //delegate should be mentioned inside namespace , the delegate should have same type for return and parameters
   //defining delegate
    public delegate string NameDelegate(string yourName);
    public delegate void SumDelegate(int x, int y);


    public class EmployeeDelegate
    {

        //function
        public void addSum(int a , int b)
        {
            Console.WriteLine($"The sum is {a + b}");
        }

        public static string addName(string name)
        {
            return "Hello "+ name;
        } 

        public void MainSub()
        {
            EmployeeDelegate employeeDelegate = new EmployeeDelegate();
            employeeDelegate.addSum(1,2);//calling non static method
            string name=EmployeeDelegate.addName("Ram"); //calling static method
            Console.WriteLine(name);
            //using delegate , to call function
            SumDelegate addDelegate = new SumDelegate(employeeDelegate.addSum); //instantiate
            addDelegate.Invoke(10, 20); //addDelegate(10, 20); //calling
            NameDelegate nameDelegate=new NameDelegate(EmployeeDelegate.addName);
            Console.WriteLine(nameDelegate("RamDelegate"));
        }
    }
}