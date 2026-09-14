using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena.Warriors.Characters
{
    public class kerki : Warrior
    {
        public kerki (int health, int attackPower, int v)
            : base("kerki", health, attackPower, WarriorType.Magery)
        {

        }

        public override void Attack(Warrior target)
        {
            throw new NotImplementedException();
        }
    }
}