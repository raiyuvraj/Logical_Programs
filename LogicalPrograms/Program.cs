﻿namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Logical Programs");
                Console.WriteLine("1: Fibonacci Series" + "\n" + "2: Perfect Number" +"\n"+ "3: Prime Number");
                int num = Convert.ToInt32(Console.ReadLine());

                switch(num)
                {
                    case 1:
                        FibonacciSeries fs = new FibonacciSeries();
                        fs.FibbSeries();
                        break;
                    case 2:
                        PerfectNumber pn = new PerfectNumber();
                        pn.PerfectNum();
                        break;
                    case 3:
                        PrimeNumber pm = new PrimeNumber();
                        pm.PrimeNum();
                        break;

                    default: break;
                            flag = false;
                        break;

                }
            }

        }
    }
}