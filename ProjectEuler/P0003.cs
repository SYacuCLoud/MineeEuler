using System.Linq;

namespace ProjectEuler
{
    public class P0003 : IEuler
    {
        public long Answer()
        {
            const long num = 600851475143;

            return MineeEuler.Instance.Factorize(num).Max();
        }
    }
}