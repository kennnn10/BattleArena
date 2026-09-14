using BattleArena.Abilities;
using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;

namespace BattleArena.Warriors.Characters
{
    public class jbsuarez : Warrior, IDefender
    {
        public int Shield { get; private set; }

        public jbsuarez(int health, int attackPower, int speed, int shield, TeamType teamType)
            : base("jbsuarez", health, attackPower, speed, WarriorType.Tank, teamType)
        {
            Shield = shield;
        }
        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Sipa", HasCriticalChance, this);
            Console.WriteLine($"\t->{Name}: iipitin kita ngani!! {target.Name}");

            Thread.Sleep(1000);
            Console.WriteLine($"\t->{target.Name}: engkk engott");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"\t->{target.Name}: {target.Name} dito kita iipitin {target.Name}");
        }

        protected override void TakeDamage(DamageInfo damage)
        {
            var newActualDamage = damage.TotalAmountDamage - Shield;

            var blockChance = _random.Next(0, 100);
            var isBlocked = blockChance < 50;
            _damageTaken = damage;

            if (isBlocked) Block();
            else
            {

                var newDmgInfo = new DamageInfo(newActualDamage, damage.AttackType, damage.IsCritical, damage.From);
                base.TakeDamage(newDmgInfo);
            }
        }

        public void Block()
        {
            Console.WriteLine($"Uyyyy Dodge Blocked {_damageTaken.TotalAmountDamage} damage from {_damageTaken.From.Name}!");
        }


    }
}