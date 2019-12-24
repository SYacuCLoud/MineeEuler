using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace ProjectEuler.Tests
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper _output;

        public UnitTest1(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void GetFactorize()
        {
            _output.WriteLine(string.Join(",",
                MineeEuler.Instance
                .Factorize(72)));
        }
        [Fact]
        public void NumberOfdivisors()
        {
            _output.WriteLine(string.Join(",",
                MineeEuler.Instance
                    .NumberOfdivisors(8)));
        }

        [Fact]
        public void GetDigitsTest()
        {
            _output.WriteLine(string.Join(",",
                MineeEuler.Instance
                .GetDigits(-987654321)));
        }

        [Fact]
        public void TestP0009Way1()
        {
            //new P0009().Way1();
        }

        [Fact]
        public void TestP0009Way2()
        {
            //new P0009().Way2();
        }

        [Fact]
        public void SieveofEratosthenes()
        {
            _output.WriteLine(MineeEuler.Instance.SieveofEratosthenes(int.MaxValue / 500)
                .Select(x => (long)x).Sum().ToString());
        }

        [Fact]
        public void GcdTriangleNum()
        {
            new P0012().Answer();
        }
    }
}