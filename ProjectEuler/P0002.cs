using System.Linq;

namespace ProjectEuler
{
    public class P0002 : IEuler
    {
        //public IEnumerable<int> FibonacciSlow()
        //{
        //    yield return 1;
        //    yield return 2;
        //    foreach(int i in FibonacciSlow().Zip(FibonacciSlow().Skip(1), (a, b) => a + b))
        //    {
        //        yield return i;
        //    }
        //}

        //public List<int> FibonacciOldWay()
        //{
        //    var list = new List<int>();
        //    int a = 1;
        //    int b = 2;
        //    int c = a + b;

        //    list.Add(a);
        //    list.Add(b);
        //    list.Add(c);

        //    while (true)
        //    {
        //        a = b;
        //        b = c;
        //        c = a + b;
        //        if (c > 4000000)
        //        {
        //            break;
        //        }
        //        list.Add(c);
        //    }
        //    return list;
        //}

        public long Answer()
        {
            return MineeEuler.Instance.Fibonacci().Where(x => x % 2 == 0).TakeWhile(x => x < 4000000).Sum();
        }
    }
}