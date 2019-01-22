using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    public class P0010 : IEuler
    {
        public long Answer()
        {
            return new MineeEuler()
                .SieveofEratosthenes(2_000_000)
                .Select(x => (long)x)
                .Sum();
        }
    }
}
