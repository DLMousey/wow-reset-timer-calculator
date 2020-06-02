using System;
using System.Reflection;

namespace WowResetTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                String versionString = Assembly.GetEntryAssembly()
                    .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                    ?.InformationalVersion
                    .ToString();

                Console.WriteLine($"WoWResetTimerCLI v{versionString}");
                Console.WriteLine("----------");
                Console.WriteLine("\nUsage:");
                Console.WriteLine(" wowreset <region> (eu|na)");
                
                Environment.Exit(1);
            }

            ResetTimePrinter printer = new ResetTimePrinter();
            printer.PrintResetTime(args[0].ToLower());

            Environment.Exit(0);
        }
    }
}