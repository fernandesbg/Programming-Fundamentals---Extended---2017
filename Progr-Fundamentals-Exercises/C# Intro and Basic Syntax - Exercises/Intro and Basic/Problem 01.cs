using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_and_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            var number3 = int.Parse(Console.ReadLine());
            var number4 = int.Parse(Console.ReadLine());

            Console.Write($"{number1:D4} ");
            Console.Write($"{number2:D4} ");
            Console.Write($"{number3:D4} ");
            Console.WriteLine($"{number4:D4}");
        }
    }
}
