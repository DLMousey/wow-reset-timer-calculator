using System;

namespace WowResetTimer
{
    public class ResetTimePrinter
    {
        public void PrintResetTime(string region)
        {
            Console.WriteLine($"{region.ToUpper()} RESET TIMERS");
            Console.WriteLine("-----------");
            Console.WriteLine($"UTC time now is: {DateTime.UtcNow.ToString()}");
            Console.WriteLine($"Local time now is: {DateTime.Now.ToString()}");
            Console.WriteLine("");
            
            RegionCalculator calculator;

            switch (region)
            {
                case "eu":
                    calculator = new EuRegionCalculator();
                    break;
                case "na":
                    calculator = new NaRegionCalculator();
                    break;
                case "oce":
                    calculator = new NaRegionCalculator();
                    break;
                case "la":
                    calculator = new NaRegionCalculator();
                    break;
                default:
                    calculator = new EuRegionCalculator();
                    break;
            }

            DateTime now = DateTime.UtcNow;
            DateTime nextDailyReset;
            DateTime nextWeeklyReset;
            TimeSpan dailyResetDiff = calculator.CalculateDaily(now);
            TimeSpan weeklyResetDiff = calculator.CalculateWeekly(now);

            nextDailyReset = now + dailyResetDiff;
            nextWeeklyReset = now + weeklyResetDiff;

            Console.WriteLine("DAILY RESET");
            Console.WriteLine("-----------");
            Console.WriteLine(
                $"{nextDailyReset.ToString()} (UTC) | {dailyResetDiff.Hours} hours, {dailyResetDiff.Minutes} minutes remaining in your timezone");
            Console.WriteLine("");
            Console.WriteLine("WEEKLY RESET");
            Console.WriteLine("-----------");
            Console.WriteLine(
                $"{nextWeeklyReset.ToString()} (UTC) | {weeklyResetDiff.Days} days, {weeklyResetDiff.Hours} hours, {weeklyResetDiff.Minutes} minutes remaining in your timezone");
        }
    }
}