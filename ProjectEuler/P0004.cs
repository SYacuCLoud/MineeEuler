using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    class P0004 : IEuler
    {
        private MineeEuler m = new MineeEuler();

        private IEnumerable<int> AssemNumbers()
        {
            int num = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    num = i * j;
                    if (m.IsPalindrome(num))
                    {
                        yield return num;
                    }
                }
            }
        }
        public long Answer()
        {
            return AssemNumbers().Max();
        }
    }
}
