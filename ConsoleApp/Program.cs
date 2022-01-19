using System;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Unit a = new()
            {
                Name = "A",
                Health = 1000,
                AttackDmg = 100,
            };

            Unit b = new()
            {
                Name = "B",
                Health = 800,
                AttackDmg = 20,
            };

            Battle.Fight(a, b);
        }
    }
}