using System;

namespace WowResetTimer
{
    public class NaRegionCalculator : RegionCalculator
    {
        public TimeSpan CalculateDaily(DateTime now)
        {
            int daysTillReset = ((int) DayOfWeek.Tuesday - (int) now.DayOfWeek + 7) % 7;

            DateTime nextReset = now.AddDays(daysTillReset);
            TimeSpan nextResetTime = new TimeSpan(15, 0, 0);
            nextReset = nextReset.Date + nextResetTime;

            return nextReset.Subtract(now);
        }

        public TimeSpan CalculateWeekly(DateTime now)
        {
            throw new NotImplementedException();
        }
    }
}