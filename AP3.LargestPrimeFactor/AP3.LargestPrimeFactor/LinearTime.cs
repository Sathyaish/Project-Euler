using System;
using System.Collections.Generic;
using System.Linq;

namespace AP3.LargestPrimeFactor
{
    public class LinearTime
    {
        public static long FindLargestPrimeFactorOf(long n)
        {
            return FindPrimeFactorsOf(n).Last();
        }

        public static IEnumerable<long> FindPrimeFactorsOf(long n)
        {
            var primesTillTwenty = new List<long> { 2, 3, 5, 7, 11, 13, 17, 19 };

            if (n < 20)
                return primesTillTwenty.Where(p => (p < n) && (n % p == 0));

            var primeFactorsTillTwenty = primesTillTwenty.Where(p => n % p == 0);

            var sqrRoot = (long)Math.Sqrt(n);

            if (sqrRoot <= 20) return primeFactorsTillTwenty;

            var multiplesOfPrimesTillTwenty = MathUtil.GetMultiplesOf(primesTillTwenty, 21, sqrRoot);

            var primeFactorsLargerThanTwenty = Enumerable.Range(21, sqrRoot - 21)
                .Except(multiplesOfPrimesTillTwenty)
                .Where(num =>
                {
                    var sroot = (int)Math.Sqrt(num);

                    if (sroot <= 20) return n % num == 0;

                    var isPrime = !(Enumerable.Range(21, sroot - 21)
                    .Except(multiplesOfPrimesTillTwenty)
                    .Any(x => num % x == 0));

                    return isPrime && (n % num == 0);
                });

            return primeFactorsTillTwenty.Concat(primeFactorsLargerThanTwenty);
        }
    }
}