using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BattleArena.Enums;
using BattleArena.Warriors;
using BattleArena.Warriors.Characters;

namespace BattleArena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var adili = new adili(100, 30, 25, 10, TeamType.A);
            var jbsuarez = new jbsuarez(200, 15, 10, 30, TeamType.B);
            var kerki = new kerki(150, 20, 15, 10, TeamType.A);
            var awut = new awut(200, 15, 10, 30, TeamType.B);

            BattleArena.AddWarrior(adili);
            BattleArena.AddWarrior(jbsuarez);
            BattleArena.AddWarrior(kerki);
            BattleArena.AddWarrior(awut);

            BattleArena.StartBattle();
        }
    }
}