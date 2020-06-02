using System;

namespace WowResetTimer
{
    public interface RegionCalculator
    {
        TimeSpan CalculateDaily(DateTime now);
        TimeSpan CalculateWeekly(DateTime now);
    }
}