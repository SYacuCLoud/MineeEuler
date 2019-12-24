using System.Linq;

namespace ProjectEuler
{
    public class P0010 : IEuler
    {
        public long Answer()
        {
            return MineeEuler.Instance
                .SieveofEratosthenes(2_000_000)
                .Select(x => (long)x)
                .Sum();
        }
    }
}