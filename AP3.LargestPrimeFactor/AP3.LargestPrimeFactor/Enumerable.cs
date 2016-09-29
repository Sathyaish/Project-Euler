using System.Collections.Generic;

namespace AP3.LargestPrimeFactor
{
    public class Enumerable
    {
        public static IEnumerable<long> Range(long from, long count)
        {
            var to = from + count;

            while (from < to)
                yield return from++;
        }
    }
}
