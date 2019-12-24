using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    public class P0004 : IEuler
    {
        private readonly MineeEuler _m = MineeEuler.Instance;

        private IEnumerable<int> AssemNumbers()
        {
            return Enumerable.Range(100, 900)
                .SelectMany(_ => Enumerable.Range(100, 900), (i, j) => i * j)
                .Where(num => _m.IsPalindrome(num));
        }

        public long Answer()
        {
            return AssemNumbers().Max();
        }
    }
}