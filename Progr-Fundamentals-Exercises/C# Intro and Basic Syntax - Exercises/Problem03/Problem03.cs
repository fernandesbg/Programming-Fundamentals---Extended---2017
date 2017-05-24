using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class Problem03
    {
        static void Main(string[] args)
        {
            var km = double.Parse(Console.ReadLine());
            Console.WriteLine($"{km* 1.60934:f2}");
        }
    }
}
