using FluentAssertions;
using Kata1Console;

namespace Kata1Tests
{
    public class UnitTest1
    {
        Calculator calc = new Calculator();

        public UnitTest1()
        {

        }

        [Fact]
        public void Test1()
        {
            calc.Add("1,2").Should().Be(1);
        }
    }
}