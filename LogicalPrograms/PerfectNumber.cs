using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public void PerfectNum() 
        {
            Console.WriteLine("Enter the Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            double sum = 0;

            for(int i=0; i<num; i++)
            {
                if(num%1 == 0)
                {
                    sum = sum + 1;
                }
            }
            if(sum == num)
            {
                Console.WriteLine(num + " is a Perfect Number.");
            }
            else
            {
                Console.WriteLine(num + " is not a Perfect Number.");
            }
        }
    }
}
