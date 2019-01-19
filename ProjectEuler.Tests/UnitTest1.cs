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
        public void Test1()
        {
            output.WriteLine(string.Join(",",
                new MineeEuler()
                .GetDigits(987654321)));
        }
    }
}
