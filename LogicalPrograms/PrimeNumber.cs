using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public void PrimeNum() 
        {
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = num / 2;

            bool IsPrime = true;
            for(int i =2; i <= result; i++)
            {
                if(i % 2 == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if(IsPrime)
            {
                Console.WriteLine(num + " is Prime Number.");

            }
            else
            {
                Console.WriteLine(num + " is not a Prime Number.");
            }
        }
    }
}
