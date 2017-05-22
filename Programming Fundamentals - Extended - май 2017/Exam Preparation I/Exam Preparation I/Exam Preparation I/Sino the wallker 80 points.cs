using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exam_Preparation_I
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeFormat = "HH:mm:ss";

            var timeLeaving = DateTime.ParseExact(Console.ReadLine(), timeFormat, CultureInfo.InvariantCulture);
            var numberOfSteps = int.Parse(Console.ReadLine());
            var secondsPerStep = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfSteps; i++)
            {
                timeLeaving = timeLeaving.AddSeconds(secondsPerStep);
            }

            var result = timeLeaving.ToString(timeFormat);

            Console.WriteLine($"Time Arrival: {result}");
        }
    }
}
