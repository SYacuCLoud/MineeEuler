using System.Linq;

namespace ProjectEuler
{
    public class P0001 : IEuler
    {
        public long Answer()
        {
            return Enumerable.Range(1, 999).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
        }
    }
}
