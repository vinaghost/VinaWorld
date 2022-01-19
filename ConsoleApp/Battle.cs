using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class Battle
    {
        public static void Fight(Unit a, Unit b)
        {
            Console.WriteLine($" === {a.Name} vs {b.Name} === ");
            Console.WriteLine("START");
            int i = 1;
            while (true)
            {
                Console.WriteLine($"Turn {i}: ");
                Console.WriteLine($"] {a.Name} hit {b.Name} {a.AttackDmg} dmg");
                b.Health -= a.AttackDmg;
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
                a.Health -= b.AttackDmg;
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