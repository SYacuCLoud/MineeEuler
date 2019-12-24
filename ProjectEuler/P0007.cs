using System.Linq;

namespace ProjectEuler
{
    public class P0007 : IEuler
    {
        public long Answer()
        {
            return MineeEuler.Instance
                .PrimeNumbers().Skip(10000).First();
        }
    }
}