namespace _4GFieldTestTool.Services
{
    public static class FrequencyCalculator
    {
        public static decimal DownlinkFrequency(decimal lowestDownlinkFrequency, decimal downlinkEarfcn,
            decimal downlinkEarfcnOffset)
        {
            var downlinkFrequency = lowestDownlinkFrequency
                                    + (0.1m * (downlinkEarfcn - downlinkEarfcnOffset));

            return downlinkFrequency;
        }

        public static decimal UplinkFrequency(decimal lowestUplinkFrequency, decimal uplinkEarfcn, decimal uplinkEarfcnOffset)
        {
            var uplinkFrequency = lowestUplinkFrequency
                                    + (0.1m * (uplinkEarfcn - uplinkEarfcnOffset));

            return uplinkFrequency;
        }
    }
}
