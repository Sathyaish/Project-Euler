using System;
using System.Collections.Generic;

namespace AP3.LargestPrimeFactor
{
    public class MathUtil
    {
        public static IEnumerable<long> GetMultiplesOf(IEnumerable<long> primesTillTwenty, long from, long to)
        {
            if (from > to)
                throw new ArgumentException("The argument 'from' must be less than or equal to the argument 'to'.");

            for (long i = from; i <= to; i++)
                foreach (var prime in primesTillTwenty)
                    if (i % prime == 0)
                        yield return i;
        }
    }
}
