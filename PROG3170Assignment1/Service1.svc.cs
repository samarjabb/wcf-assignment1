using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PROG3170Assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void PrimeNumber(int number)
        {
            if (number == 0 || number == 1)
            {
                Console.WriteLine(number + " is not prime number");
                Console.ReadLine();
            }
            else
            {
                for (int a = 2; a <= number / 2; a++)
                {
                    if (number % a == 0)
                    {
                        Console.WriteLine(number + " is not a prime number");
                        break;
                    }

                }
                Console.WriteLine(number + " is a prime number");
                Console.ReadLine();
            }
        }

        public void PrintHTMLTag(string tag, string data)
        {
            Console.WriteLine("<" + tag + ">" + data + "<" + tag + "/>");
        }

        public void ReverseString(string input)
        {
            string reverse = "";
            string[] stringarray = input.Split();
            for (int i = stringarray.Length - 1; i > -1; i--)
            {
                reverse += stringarray[i];
            }
            Console.WriteLine(reverse);
        }

        public void Sort5Numbers(string sortType, int[] data)
        {
            if(sortType == "Ascending")
            {
                Array.Sort(data, 0, 5);
            }
        }

        public int SumDigits(int number)
        {
            throw new NotImplementedException();
        } 
        
        //public string GetData(int value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}
    }
}
