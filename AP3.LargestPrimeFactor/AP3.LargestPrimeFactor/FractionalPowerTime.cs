using System;
using System.Collections.Generic;
using System.Linq;

namespace AP3.LargestPrimeFactor
{
    // Please see the following links for a definition of the Fractional Power time
    // http://stackoverflow.com/questions/39830714/what-would-you-call-the-time-complexity-of-an-algorithm-of-this-sort
    // https://en.wikipedia.org/wiki/Time_complexity
    // O(nc) where 0 < c < 1
    public class FractionalPowerTime
    {
        public static long FindLargestPrimeFactorOf(long n)
        {
            var primesTillTwenty = new List<long> { 2, 3, 5, 7, 11, 13, 17, 19 };

            var sqrRoot = (long)Math.Sqrt(n);

            var multiplesOfPrimesTillTwenty = MathUtil.GetMultiplesOf(primesTillTwenty, 21, sqrRoot);

            var divisors = Enumerable.Range(21, sqrRoot - 21)
                .Except(multiplesOfPrimesTillTwenty);

            for (long i = sqrRoot; i >= 2; i--)
                if (n % i == 0)
                    return i;

            return 1L;
        }
    }
}
