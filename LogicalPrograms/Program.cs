namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Logical Programs");
                Console.WriteLine("1: Fibonacci Series" + "\n"+ "2: Exit");
                int num = Convert.ToInt32(Console.ReadLine());

                switch(num)
                {
                    case 1:
                        FibonacciSeries fs = new FibonacciSeries();
                        fs.FibbSeries();
                        break;
                    default: break;
                            flag = false;
                        break;

                }
            }

        }
    }
}