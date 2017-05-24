using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            Console.WriteLine($"Name: {name}");

            var health = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            Console.WriteLine("Health: " + '|' + new string('|', health) + new string('.', maxHealth-health) + '|');

            var energy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());
            Console.WriteLine("Energy: " + '|' + new string('|', energy) + new string('.', maxEnergy - energy) + '|');
        }
    }
}
