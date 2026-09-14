using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;

namespace BattleArena.Warriors.Characters
{
    public class adili : Warrior
    {
        public int SuboDamage { get; private set; }
        public adili(int health, int attackPower, int speed, int suboDamage, TeamType teamType)
            : base("adili", health, attackPower, speed, WarriorType.Marksman, teamType)
        {
            SuboDamage = suboDamage;
            attackPower += SuboDamage;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Subo", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: lunod ka no  {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: langoy nga");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: Buti nabuhay ako sa lalim {target.Name}");
        }
    }

}