namespace GreatestCommonDivisorService.Test;

public class UnitTest
{
    [Theory]
    [InlineData(77, 1705, 11)]
    [InlineData(77, -2147483647, 1)]
    [InlineData(77, -2147483646, 77)]
    [InlineData(77, 2147483646, 77)]
    [InlineData(77, 2147483647, 1)]
    [InlineData(-2147483647, 1705, 1)]
    [InlineData(-2147483646, 1705, 341)]
    [InlineData(2147483646, 1705, 341)]
    [InlineData(2147483647, 1705, 1)]
    public void BoundaryValueAnalysis(int number1, int number2, int expectedResult)
    {
        Assert.Equal(expectedResult, GreatestCommonDivisorService.GreatestCommonDivisor(number1, number2));
    }

    [Theory]
    [InlineData(-100, -50, 50)]
    [InlineData(-100, 0, 100)]
    [InlineData(-100, 80, 20)]
    [InlineData(0, -50, 50)]
    [InlineData(0, 0, 0)]
    [InlineData(0, 80, 80)]
    [InlineData(75, -50, 25)]
    [InlineData(75, 0, 75)]
    [InlineData(75, 80, 5)]
    public void EquivalencePartitioning(int number1, int number2, int expectedResult)
    {
        Assert.Equal(expectedResult, GreatestCommonDivisorService.GreatestCommonDivisor(number1, number2));
    }
}