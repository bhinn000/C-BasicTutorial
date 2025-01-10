using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic.Collections
{
    public class Collection1
    {
        static void Main()
        {
            ////Array : type safe
            //int[] arr = new int[3];//can change its size, access and remove from the middle 
            //Console.WriteLine("Enter the numbers");
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    arr[i]=int.Parse(Console.ReadLine());
            //}

            //Array.Resize(ref arr, 5); //we can change the size using this but this will destroy the previous array
            //Console.WriteLine("After resizing it");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //ArrayList : variable length , can insert and remove from the middle , is not type safe
            ArrayList al= new ArrayList();//by default , the capacity is 0
            Console.WriteLine(al.Capacity);
            al.Add(100);
            Console.WriteLine(al.Capacity); //now size is 4  , then 8 then 16 ; doubles
            al.Add(100);
            al.Add(200);
            al.Add(300);
            Console.WriteLine(al.Capacity);//still 4
            al.Add(400);
            Console.WriteLine(al.Capacity);//now 8
            foreach (object obj in al)
                Console.Write(obj + " ");

            al.Remove(500);
            al.RemoveAt(1);

            Console.WriteLine("\nAfter removing: ");
            foreach (object obj in al)
                Console.Write(obj + " ");

            ArrayList al1 = new ArrayList(10);//now 10

            al1 = ["Ram", "Hari", "Shyam", true]; //any type can be sent so is "not type safe" but resizable, collection(non generic)s
            Console.WriteLine("\nCapacity of al1: ", al1.Capacity);
            Console.WriteLine("\nWe have following in al1:");
            foreach (object obj in al1)
                Console.Write(obj + " ");
            Console.WriteLine($"\nAt index 0 , we have {al[0]}");//in the case of ArrayList , it is key/value but key is an index

            //instead of this , there is "Key/value" where key is not limit to index
            //Hashtable
            Hashtable ht = new Hashtable(); //not type safe ; collection(non generic)
            ht.Add("Name", "Shyam");
            ht.Add("Job", "Musician");
            ht.Add("Location", "Gokul");
           
            Console.WriteLine(ht["Job"]); //we can access the value with key
            foreach (object key in ht.Keys)
                Console.WriteLine(key + " : " + ht[key] + "\n"); //display on the basis of hashCode
                //Console.WriteLine(ht : ht[key] + "\n");


        }
    }
}
