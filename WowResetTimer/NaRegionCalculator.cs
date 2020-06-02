using System;

namespace WowResetTimer
{
    public class NaRegionCalculator : RegionCalculator
    {
        public TimeSpan CalculateWeekly(DateTime now)
        {
            int daysTillReset = ((int) DayOfWeek.Tuesday - (int) now.DayOfWeek + 7) % 7;

            DateTime nextReset = now.AddDays(daysTillReset);
            TimeSpan nextResetTime = new TimeSpan(15, 0, 0);
            nextReset = nextReset.Date + nextResetTime;

            return nextReset.Subtract(now);
        }

        public TimeSpan CalculateDaily(DateTime now)
        {
            DateTime nextReset;
            TimeSpan nextResetTime = new TimeSpan(15, 0, 0);

            if (now.Hour < 15)
            {
                nextReset = now.Add(nextResetTime);
                nextReset = nextReset.Date + nextResetTime;

                return nextReset.Subtract(now);
            }

            nextReset = now.Date.AddDays(1).Date;
            nextReset = nextReset.Date + nextResetTime;

            return nextReset.Subtract(now);
        }
    }
}