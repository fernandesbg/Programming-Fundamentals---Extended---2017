using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Problem02
    {
        static void Main(string[] args)
        {
            var lenght = double.Parse(Console.ReadLine());
            var hight = double.Parse(Console.ReadLine());

            Console.WriteLine($"{lenght*hight:f2}");
        }
    }
}
