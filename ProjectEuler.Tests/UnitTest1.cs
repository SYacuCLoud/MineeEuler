using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace ProjectEuler.Tests
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper output;

        public UnitTest1(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void GetDigitsTest()
        {
            output.WriteLine(string.Join(",",
                new MineeEuler()
                .GetDigits(987654321)));
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
            new MineeEuler().SieveofEratosthenes(int.MaxValue / 500)
                .Select(x => (long)x).Sum();
        }
    }
}
