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
            Warrior adili = new Warrior("Rene", 100, 30);


            Warrior kerki = new Warrior("Bosseng", 200, 25);


            Warrior jbsuarez = new Warrior("Jb", 300, 40);



            Console.WriteLine($"{adili.Name} has  " +
                $"{adili.Health} health and {adili.AttackPower} " + $"attack power.");
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