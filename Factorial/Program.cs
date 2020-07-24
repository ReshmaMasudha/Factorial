using System;

namespace Factorial
{
    class Program
    {
        class functions
        {
            public static long factorial(long num)
            {
                if (num < 0 || num > 20)
                    return -1;
                //factorial condition

                long value = 1;

                for (int i = 1; i <=num; i++)
                {
                    value *= i;
                }
                return value;
            }
        }
        static int Main(string[] args)  // value of arguments is passed under the debug tab of the project
        {

            //checking length of args passed 
            if (args.Length == 0)
            {
                Console.WriteLine("Enter a valid Numerical value");
                return 1;
            }

            //Checking whether passed argument is a numerical value

            int num;
            bool val = Int32.TryParse(args[0], out num);
            if(!val)
            {
                Console.WriteLine("Enter a valid Numerical value ");
                return 1;
            }

            var result = functions.factorial(num);

            //checking if the resukt of factorial is having value or it any condition break
            if (result == -1)
                Console.WriteLine("Enter the numbers within the limit greater than 0 and lesser than 20");
            else
                Console.WriteLine($"The factorial of {num} is {result}");
            return 0;
        }
    }
}
