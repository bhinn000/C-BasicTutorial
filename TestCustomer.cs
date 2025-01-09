using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_Basic
{
    internal class TestCustomer

    {
        public void MainSub()
        {
            Customer customer = new Customer("Client123" ,true, "Ram" , 2000 , Cities.Pokhara, "fNepal"); //we cant use Cities.Butwal as not defined in Enum
            Console.WriteLine($"Customer code is {customer.custID}");
            //customer.custID = "Client000"; //is read-only so cant modify it
            Console.WriteLine($"Original name is  is {customer.cname}");
            customer.cname += "Bahadur";
            Console.WriteLine($"Name is modified to {customer.cname}");

            if (customer.status == true)
            {
                Console.WriteLine($"Customer status: Active");
            }
            else 
            {
                Console.WriteLine($"Customer status: In-Active");
            }

            Console.WriteLine($"Current balance: {customer.balance}");
            customer.balance -= 1800;
            Console.WriteLine($"Modified balance: {customer.balance}");

            //allow to update the city with given options only , we are using "enum" here
            Console.WriteLine($"City : {customer.City}");
           


        }
    }
}
