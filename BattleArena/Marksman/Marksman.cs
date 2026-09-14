using BattleArena.Warriors;
using System;
using System.Threading;
using System.Xml.Linq;

namespace BattleArena.Warriors
{
    public class Marksman : Warrior
    {
        public int ArrowDamage { get; private set; }
        public Marksman(string name, int health, int attackPower, int arrowDamage)
            : base(name, health, attackPower)
        {
            ArrowDamage = arrowDamage;
            attackPower += arrowDamage;
        }

        public Marksman(string name, int health, int attackPower)
            : base(name, health, attackPower)
        {

        }

        public override void Attack(Warrior target)
        {
            var totalDamage = target.AttackPower + ArrowDamage;
            TakeDamage(totalDamage);
            Console.WriteLine($"\t-> {Name}: Ano bai kaya pa? {target.Name}!");
            Thread.Sleep(1000);

            Console.WriteLine($"\t-> {target.Name}: Run baby run!");
            Thread.Sleep(1000);

            if (target.IsAlive)
                Console.WriteLine($"\t-> {target.Name}: ahhhhh giatay! {target.Name}");
            Thread.Sleep(1000);

            Console.WriteLine($"\t------ {target.Name} --------");
            Console.WriteLine($"\t  *Damage Taken: {totalDamage} *");
            Console.WriteLine($"\t  *Health Remaining: {target.Health} *");



        }
    }
}