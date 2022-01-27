using System;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Unit a = new Unit("A", 20, 50);
            Unit b = new Unit("B", 10, 80);

            Console.WriteLine($" === {a.Name} vs {b.Name} === ");
            Console.WriteLine("START");
            int i = 1;
            while (true)
            {
                Console.WriteLine($"Turn {i}: ");
                Console.WriteLine($"] {a.Name} hit {b.Name} {a.AttackDmg} dmg");

                a.Attack(b);

                if (b.Health < 0)
                {
                    Console.WriteLine($"] {b.Name} is dead. {a.Name} is winner");
                    break;
                }
                else
                {
                    Console.WriteLine($"] {b.Name}'s health is now {b.Health}");
                }
                Console.WriteLine($"] {b.Name} hit {a.Name} {b.AttackDmg} dmg");

                b.Attack(a);

                if (a.Health < 0)
                {
                    Console.WriteLine($"] {a.Name} is dead. {b.Name} is winner");
                    break;
                }
                else
                {
                    Console.WriteLine($"] {a.Name}'s health is now {a.Health}");
                }

                i++;
            }
        }
    }
}