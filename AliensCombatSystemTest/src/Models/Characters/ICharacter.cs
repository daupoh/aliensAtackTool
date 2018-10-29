using AliensCombatSystemTest.src.Models.DamageTypes;
using AliensCombatSystemTest.src.Models.Hits;
using AliensCombatSystemTest.src.Models.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models.Characters
{
    interface ICharacter
    {
        void getsDamage(IWeapon weapon);
        string getName();
    }
}
