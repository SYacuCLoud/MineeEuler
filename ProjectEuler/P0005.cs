using System.Linq;

namespace ProjectEuler
{
    public class P0005 : IEuler
    {
        public long Answer()
        {
            return MineeEuler.Instance.Lcm(Enumerable.Range(1, 19)
                .Select(i => (long)i)
                .ToArray());
        }
    }
}