using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    public class P0009 : IEuler
    {
        /*
        // A = m^2 - n^2
        // B = 2mn;
        // C = m^2 + n^2
        public long Way1()
        {
            IEnumerable<int> mRange = Enumerable.Range(1, 32);
            var triplet = mRange.SelectMany(m => mRange.Where(n => (2 * (m * m)) + (2 * (m * n)) == 1000)
                .Select(n => new { A = m * m - n * n, B = 2 * m * n, C = m * m + n * n }))
                .FirstOrDefault();
            return triplet.A * triplet.B * triplet.C;
        }
        */
        /*
        public long Way2()
        {
            IEnumerable<int> range = Enumerable.Range(1, 1000);
            var triplets = range.SelectMany(a => range.Where(b => a < b)
                .Select(b => new { A = a, B = b, C = (1000 - a - b) }));
            var triplet = triplets.FirstOrDefault(t => t.A * t.A + t.B * t.B == t.C * t.C);
            return triplet.A * triplet.B * triplet.C;
        }
        */
        /*
        public long Way3()
        {
            int a, b, c;
            int k = 1000;
            int m = k * k / 2;
            for (int i = 1; i < m; i++)
            {
                if (m % i == 0)
                {
                    b = k - i;
                    c = m / i - b;
                    a = k - b - c;

                    if ((a > 1) && (b > 1) && (c > 1))
                    {
                        return a * b * c;
                    }
                }
            }
            return 0;
        }
        */

        public long Answer()
        {
            IEnumerable<int> mRange = Enumerable.Range(1, 32);
            var triplet = mRange.SelectMany(m => mRange.Where(n => (2 * (m * m)) + (2 * (m * n)) == 1000)
                .Select(n => new { A = m * m - n * n, B = 2 * m * n, C = m * m + n * n }))
                .FirstOrDefault();
            return triplet.A * triplet.B * triplet.C;
        }
    }
}
