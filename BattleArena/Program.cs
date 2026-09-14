using BattleArena.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{

    internal class Program
    {
        static void Main(string[] args) 
        {
            int round = 1;
            var adili = new Marksman("adili", 100, 30);
            var kerki = new Mage("kerki", 200, 15);
            var Jjbsuarez = new Tank("jbsuarez", 150, 30);

            adili.DisplayStats();
            kerki.DisplayStats();
            Jjbsuarez.DisplayStats();

            while (adili.IsAlive && kerki.IsAlive && Jjbsuarez.IsAlive)
            {

                adili.Attack(kerki);
                Console.WriteLine("----------------------------------------------");
                Jjbsuarez.Attack(adili);
                Console.WriteLine("----------------------------------------------");
                round++;
            }

            Console.ReadKey();
        }
    }
}