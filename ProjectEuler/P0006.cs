using System;
using System.Linq;

namespace ProjectEuler
{
    public class P0006 : IEuler
    {
        public long Answer()
        {
            long left = (long)Math.Pow(Enumerable.Range(1, 100)
                .Sum(), 2);
            long right = Enumerable.Range(1, 100)
                .Select(i => i * i)
                .Sum();
            return left - right;
        }
    }
}