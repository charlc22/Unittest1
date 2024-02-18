using Xunit;
using MyRootLib;

namespace MyRootLibTest
{

public class UnitTest1
{
    [Fact]
    public void TestCalculateSquareRoot()
    {
        double expectedRoot = 2.0;

        Class1 rootCalculator = newClass1();

        Console.SetIn(new System.IO.StringReader("4"));

        using (var sw = new System.IO.StringWriter())
        {
            Console.SetOut(sw);
            rootCalculator.CalculateSquareRoot();
            var result = sw.ToString().Trim();

            Assert.Contains($"The square root of 4 is {expectedRoot}", result);
        }
    }
}
}