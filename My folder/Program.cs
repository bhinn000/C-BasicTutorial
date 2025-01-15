
namespace C_Basic
{
    class Program
    {
        int x = 10;//instance has to be created
        static int y = 20; //memory for this allocates when  class executes ; static variable is initialised only once in the lifecycle of the class

        //using instance, we can keep different value for the variable whereas in the case of static , it overwrites the previous value

        //constant variables can't be modified after declaration;and should be initialised at the time of declaration ; initialised only once in the lifecycle of the class and does not need instance
        const float pi = 3.14f;
        //const float pi2;//we cant just declare here , need to initialise too

        readonly bool flag; //readonly: cant be modified after initialisation , not mandatory to initialise at the time of declaration ; can be initialised under constructor; need instance of the class to be initialised
       
        public Program()
        {
            this.flag = false;
        }
        static void Main()
        {
            //Console.WriteLine(x);//not possible
            Console.WriteLine(y);//static 
            Console.WriteLine(pi);//constant 
        }

    }
}

//instance var can be modified but readonly cant be
//constant var is fixed for whole class but readonly var is fixed to instance of the class
