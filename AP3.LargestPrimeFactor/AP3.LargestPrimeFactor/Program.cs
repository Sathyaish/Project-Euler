using System;
using System.Diagnostics;

namespace AP3.LargestPrimeFactor
{
    /* https://projecteuler.net/problem=3
     * The prime factors of 13195 are 5, 7, 13 and 29.
     * What is the largest prime factor of the number 600851475143 ?
     */
    class Program
    {
        static void Main(string[] args)
        {
            var n = 600851475143;

            // InLinearTime(n);

            InConstantTime(n);

            Console.ReadKey();
        }

        static void InLinearTime(long n)
        {
            Console.WriteLine("LINEAR TIME OPERATION:");
            var stopwatch = Stopwatch.StartNew();
            var largestPrimeFactor = LinearTime.FindLargestPrimeFactorOf(n);
            stopwatch.Stop();
            Console.WriteLine($"The largest prime factor of {n} is: {largestPrimeFactor}.");
            Console.WriteLine($"The operation took {stopwatch.ElapsedMilliseconds} milliseconds.\n");
        }

        static void InConstantTime(long n)
        {
            Console.WriteLine("CONSTANT TIME OPERATION:");
            var stopwatch = Stopwatch.StartNew();
            var largestPrimeFactor = ConstantTime.FindLargestPrimeFactorOf(n);
            stopwatch.Stop();
            Console.WriteLine($"The largest prime factor of {n} is: {largestPrimeFactor}.");
            Console.WriteLine($"The operation took {stopwatch.ElapsedMilliseconds} milliseconds.\n");
        }
    }
}
