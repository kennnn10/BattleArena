using System;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena.Warriors
{
    public class jbsuarez : Warrior
    {
        public int Libag { get; private set; }
        public jbsuarez(int health, int attackPower, int libag)
            : base("jbsuarez", health, attackPower, WarriorType.Tank)
        {
            Libag = libag;
        }

        public override void Attack(Warrior target)
        {

            var dmginfo = new DamageInfo(AttackPower, "Sipa", _hasCriticalChance);
            TakeDamage(dmginfo);



            Console.WriteLine($"\t-> {Name}: iipitin kita ngani!! {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"\t-> {target.Name}: engkkk engot");


            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"\t-> {target.Name}: dito kita iipitin!  {target.Name}");
        }

        protected override void TakeDamage(DamageInfo damage)
        {
            var newActualDamage = damage.TotalAmountDamage - Libag;
            var newDmginfo = new DamageInfo(newActualDamage, damage.AttackType, damage.IsCritical);
            base.TakeDamage(damage);
        }

    }
}