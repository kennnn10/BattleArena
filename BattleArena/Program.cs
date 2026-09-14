using battleArena.Warrios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleArena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior adili = new Warrior("Rene", 100, 30, "Fireball");
            Warrior kerki = new Warrior("Bosseng", 200, 25, "Lightning Strike");
            Warrior Jjbsuarez = new Warrior("Jb", 300, 40, "Ice Blast");


            adili.DisplayStatus();
            kerki.DisplayStatus();
            Jjbsuarez.DisplayStatus();


            int round = 1;
            while (adili.IsAlive && kerki.IsAlive && Jjbsuarez.IsAlive)
            {
                Console.WriteLine("----------Round {round} ----------");
                adili.Attack(kerki);
                kerki.Attack(Jjbsuarez);
                Jjbsuarez.Attack(adili);
                Console.WriteLine("--------------------------------");
                round++;
            }

            Console.ReadKey();
        }
    }
}