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
        public awut(int health, int attackPower, int punchDamage)
            : base("awut", health, attackPower, WarriorType.Fighter)
        {
            PunchDamage = punchDamage;
            attackPower += PunchDamage;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Sapak", HasCriticalChance);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: Sasapakin kita {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: Aray ko po!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: Buhay pa ko bebe {target.Name}");
        }
    }

}