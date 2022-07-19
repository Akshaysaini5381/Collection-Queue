using System;
using System.Collections;
using System.Collections.Generic;
namespace Collection__Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue obj = new Queue() ;
            obj.Enqueue(12);
            obj.Enqueue("akshay");
            obj.Enqueue(true);
            obj.Enqueue(12.790);

            foreach (var item in obj)
            {
                Console.WriteLine("Value : "+item);
            }
            Console.WriteLine(obj.Count);
            Console.WriteLine(obj.Peek());
            
            

        }
    }
}
