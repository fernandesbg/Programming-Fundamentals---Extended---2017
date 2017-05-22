
namespace SoftUni_Karaoke
{
    using System;
    using System.Linq;

    public class Karaoke
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine()
                .Split(new[] {',' }, StringSplitOptions)
                .RemoveEmptyEntries
                .Select(p => p.Trim())
                .ToArray();
        }
    }
}
