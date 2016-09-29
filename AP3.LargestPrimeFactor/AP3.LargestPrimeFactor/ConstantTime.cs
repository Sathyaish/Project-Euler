using System;
using System.Collections.Generic;
using System.Linq;

namespace AP3.LargestPrimeFactor
{
    public class ConstantTime
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
