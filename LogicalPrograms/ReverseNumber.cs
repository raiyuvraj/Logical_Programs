using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public void ReverseNum()
        {
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;

            while(num !=0)
            {
                int remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num /= 10;

            }
            Console.WriteLine("Reverse of the givrn number: " +reverse);
        }
    }
}
