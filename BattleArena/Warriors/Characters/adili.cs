using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;

namespace BattleArena.Warriors.Characters
{
    public class adili : Warrior
    {
        public int DuraDamage { get; private set; }
        public adili(int health, int attackPower, int speed, int duraDamage, TeamType teamType)
            : base("adili", health, attackPower, speed, WarriorType.Marksman, teamType)
        {
            DuraDamage = duraDamage;
            attackPower += DuraDamage;
        }



        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "tubig", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Thread.Sleep(1000);
            Console.WriteLine($"\t->{Name}: ano lunod kana? {target.Name}");

            Thread.Sleep(1000);
            Console.WriteLine($"\t->{target.Name}: langoy ne");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"\t->{target.Name}: {target.Name} lunod ang GA. {target.Name}");



        }


    }
}