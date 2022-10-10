namespace GreatestCommonDivisorService.Test;

public class UnitTest
{
    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(0, 1, 1)]
    [InlineData(25, 15, 5)]
    [InlineData(-25, 15, 5)]
    public void BoundaryValueAnalysis(int number1, int number2, int expectedResult)
    {
        Assert.Equal(expectedResult, GreatestCommonDivisorService.GreatestCommonDivisor(number1, number2));
    }

    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(0, 1, 1)]
    [InlineData(25, 15, 5)]
    [InlineData(-25, 15, 5)]
    public void EquivalencePartitioning(int number1, int number2, int expectedResult)
    {
        Assert.Equal(expectedResult, GreatestCommonDivisorService.GreatestCommonDivisor(number1, number2));
    }
}