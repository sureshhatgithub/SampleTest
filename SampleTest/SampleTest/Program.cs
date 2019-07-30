using System;
using System.Diagnostics;

namespace SampleTest
{
    /// <summary>
    /// Author: Suresh Halade
    /// Sample Test for Math Pow functionality
    /// </summary>
    class Program
    {
        //Approach 1 - Recursive approach to find power of number - this is optimum way among all - provides better performance
        public static double CustomMathPowRecursive(double number, int power)
        {
            if (power == 0)
                return 1;
            else
                return number * CustomMathPowRecursive(number, power - 1);
        }

        //Approach 2 - using while loop to find power of number
        public static double CustomMathPowWhile(double number, int power)
        {
            double result = 1;
            while (power != 0)
            {
                result = result * number;
                --power;
            }
            return result;
        }

        //Approach 3 - using for loop - this is something we discussed during call as well
        public static double CustomMathPowFor(double number, int power)
        {
            double result = 1;
            for (int x = 1; x <= power; x++)
            {
                result *= number;
            }
            return result;
        }

        static void Main(string[] args)
        {
            double number = 2, result = 1;
            int power = 100;
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            var result2 = CustomMathPowRecursive(number, power);        //Custom recusrive approach - this is optimum way among all - provides better performance
            stopwatch.Stop();
            Console.WriteLine("Result = {0}, Time taken = {1}", result2, stopwatch.ElapsedTicks);

            stopwatch.Start();
            result = CustomMathPowWhile(number, power);                //Custom approach While loop
            stopwatch.Stop();
            Console.WriteLine("Result = {0}, Time taken = {1}", result, stopwatch.ElapsedTicks);

            stopwatch.Start();
            result = CustomMathPowFor(number, power);                 //Custom approach For loop - we discussed this in call
            stopwatch.Stop();
            Console.WriteLine("Result = {0}, Time taken = {1}", result, stopwatch.ElapsedTicks);

            stopwatch.Start();
            var result1 = Math.Pow(number, power);                      //built-in .NET approach
            stopwatch.Stop();
            Console.WriteLine("Result = {0}, Time taken = {1}", result1, stopwatch.ElapsedTicks);

            Console.ReadLine();
        }
    }
}
