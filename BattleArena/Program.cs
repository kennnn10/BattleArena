using BattleArena.Warriors;
using BattleArena.Warriors.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kerki = new kerki(100, 30, 3);
            var jbsuarez = new jbsuarez(200, 15, 10);

            kerki.DisplayStatus();
            jbsuarez.DisplayStatus();

            while (kerki.IsAlive && jbsuarez.IsAlive)
            {
                Console.WriteLine("\n\n=================================================");
                kerki.Attack(jbsuarez);
                jbsuarez.DisplayStatus();
                Console.WriteLine("-------------------------------------------------");
                Thread.Sleep(2000);
                jbsuarez.Attack(kerki);
                kerki.DisplayStatus();
                Thread.Sleep(2000);
            }

            Console.ReadKey();
        }
    }
}