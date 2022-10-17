using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG3170A1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            var res = client.GetData(100);
            Console.WriteLine(res);
            Console.ReadLine();

            Console.WriteLine("Choose one of the activities:");
            Console.WriteLine("1. Prime number");
            Console.WriteLine("2. Sum of digits");
            Console.WriteLine("3. Reverse a string");
            Console.WriteLine("4. Print HTML tags");
            Console.WriteLine("5. Sort 5 numbers");
            Console.WriteLine("6. Exit");
            Console.WriteLine("What is your ");
        }
    }
}
