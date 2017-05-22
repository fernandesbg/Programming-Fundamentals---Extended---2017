using System;
using System.Globalization;
using System.Numerics;

namespace SinoTheWallker
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeFormat = "HH:mm:ss";

            var timeLeaving = DateTime.ParseExact(Console.ReadLine(), timeFormat, CultureInfo.InvariantCulture);
            var numberOfSteps = int.Parse(Console.ReadLine());
            var secondsPerStep = int.Parse(Console.ReadLine());

            long initialSeconds = timeLeaving.Hour * 60 * 60 + timeLeaving.Minute * 60 + timeLeaving.Second;

            ulong secondsToAdd = (ulong)numberOfSteps * (ulong)secondsPerStep;

            ulong totalSeconds = (ulong)initialSeconds + secondsToAdd;

            var seconds = totalSeconds % 60;
            var totalMinutes = totalSeconds / 60;
            var minutes = totalMinutes % 60;
            var totalHours = totalMinutes / 60;
            var hours = totalHours % 24;

            Console.WriteLine($"Time Arrival: {hours:00}:{minutes:00}:{seconds:00}");
        }
    }
}
