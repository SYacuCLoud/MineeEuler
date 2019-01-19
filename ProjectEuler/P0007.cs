using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class P0007 : IEuler
    {
        public long Answer()
        {
            return new MineeEuler()
                .PrimeNumbers().Skip(10000).First();
        }
    }
}
