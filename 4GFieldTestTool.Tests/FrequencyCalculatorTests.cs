using _4GFieldTestTool.Services;

namespace _4GFieldTestTool.Tests;

public class FrequencyCalculatorTests
{
    [Fact]
    public void CalculateDownlinkFrequency_WithValidValue_ReturnsCorrectDownlinkFrequency()
    {
        var downlinkEarfcn = 400;
        var downlinkEarfcnOffset = 0;
        var lowestDownlinkFrequency = 2110;

        var downlinkFrequency = FrequencyCalculator.DownlinkFrequency(lowestDownlinkFrequency, downlinkEarfcn, downlinkEarfcnOffset);

        Assert.Equal(2150m, downlinkFrequency);
    }

    [Fact]
    public void CalculateUplinkFrequency_WithValidValue_ReturnsCorrectDownlinkFrequency()
    {
        var uplinkEarfcn = 18800;
        var uplinkEarfcnOffset = 18600;
        var lowestUplinkFrequency = 1850;

        var uplinkFrequency = FrequencyCalculator.UplinkFrequency(lowestUplinkFrequency, uplinkEarfcn, uplinkEarfcnOffset);

        Assert.Equal(1870m, uplinkFrequency);
    }
}
