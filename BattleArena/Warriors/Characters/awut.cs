using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;

namespace BattleArena.Warriors.Characters
{
    public class awut : Warrior
    {
        public int BayoDamage { get; private set; }
        public awut(int health, int attackPower, int speed, int bayoDamage, TeamType teamType)
            : base("awut", health, attackPower, speed, WarriorType.Fighter, teamType)
        {
            BayoDamage = bayoDamage;
            attackPower += BayoDamage;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Bayo", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: Babayuhin kita {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: Aray ko po!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: grabe ka ne {target.Name}");
        }
    }

}