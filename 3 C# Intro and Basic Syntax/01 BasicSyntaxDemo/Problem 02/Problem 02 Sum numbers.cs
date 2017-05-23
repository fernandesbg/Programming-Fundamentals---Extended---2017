using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOne = int.Parse(Console.ReadLine());
            var numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne+numberTwo}");
        }
    }
}
