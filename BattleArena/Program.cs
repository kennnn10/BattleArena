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
            Warrior Adili = new Warrior();
            Adili.Name = "Rene";
            Adili.Health = 100;
            Adili.AttackPower = 30;

            Warrior kerki = new Warrior();
            kerki.Name = "Bosseng";
            kerki.Health = 200;
            kerki.AttackPower = 25;

            Warrior jbsuarez = new Warrior();
            jbsuarez.Name = "Jb";
            jbsuarez.Health = 300;
            jbsuarez.AttackPower = 40;

            Console.WriteLine($"{Adili.Name} has  " +
                $"{Adili.Health} health and {Adili.AttackPower} " + $"attack power.");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"{kerki.Name} has" +
                $" {kerki.Health} health and {kerki.AttackPower} " + $"attack power.");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"{jbsuarez.Name} has" +
               $" {jbsuarez.Health} health and {jbsuarez.AttackPower} " + $"attack power.");
            Console.WriteLine("--------------------------------");

            Console.ReadKey();
        }
    }
}