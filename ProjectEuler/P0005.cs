using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ProjectEuler
{
    class P0005 : IEuler
    {
        public long Answer()
        {
            return new MineeEuler().Lcm(Enumerable.Range(1, 19)
                .Select(i => (long)i)
                .ToArray());
        }
    }
}
