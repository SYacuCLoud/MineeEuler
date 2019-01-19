using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    public class P0003 : IEuler
    {
        public long Answer()
        {
            long num = 600851475143;

            return new MineeEuler().Factorize(num).Max();
        }
    }
}
