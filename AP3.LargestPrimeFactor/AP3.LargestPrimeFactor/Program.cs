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

            InFractionalPowerTime(n);

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

        // Please see the following links for a definition of the Fractional Power time
        // http://stackoverflow.com/questions/39830714/what-would-you-call-the-time-complexity-of-an-algorithm-of-this-sort
        // https://en.wikipedia.org/wiki/Time_complexity
        // O(nc) where 0 < c < 1
        static void InFractionalPowerTime(long n)
        {
            Console.WriteLine("FRACTIONAL POWER TIME OPERATION:");
            var stopwatch = Stopwatch.StartNew();
            var largestPrimeFactor = FractionalPowerTime.FindLargestPrimeFactorOf(n);
            stopwatch.Stop();
            Console.WriteLine($"The largest prime factor of {n} is: {largestPrimeFactor}.");
            Console.WriteLine($"The operation took {stopwatch.ElapsedMilliseconds} milliseconds.\n");
        }
    }
}
