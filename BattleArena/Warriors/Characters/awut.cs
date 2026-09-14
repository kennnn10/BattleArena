using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena.Warriors
{

    public class awut : Warrior
    {
        public int PunchDamage { get; private set; }
        public awut(int health, int attackPower, int speed, int punchDamage, TeamType teamType)
           : base("awut", health, attackPower, speed, WarriorType.Fighter, teamType)
        {
            PunchDamage = punchDamage;
            attackPower += punchDamage;
        }

        public awut(string name, int health, int attackPower)
            : base(name, health, attackPower, WarriorType.Fighter, TeamType.A)
        {
            PunchDamage = PunchDamage;
        }


        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Sapak", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"\t->{Name}: ano ne? {target.Name}");
            Thread.Sleep(1000);

            Console.WriteLine($"\t->{target.Name}: ray mo proman");
            Thread.Sleep(1000);

            if (target.IsAlive)
                Console.WriteLine($"\t->{target.Name}: {target.Name} birada! {target.Name}");

        }


    }
}