using AliensCombatSystemTest.src.Models.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models.Characters.Aliens
{
    interface IAlienCharacter:ICharacter
    {
        void setBiteWeapon(IWeapon weapon);
        void setHoldBiteWeapon(IWeapon weapon);
        void setStrikeWeapon(IWeapon weapon);
        void setHoldStrikeWeapon(IWeapon weapon);
        void setTailWeapon(IWeapon weapon);

        void atackByBite(ICharacter character);
        void atackByHoldBite(ICharacter character);
        void atackByStrike(ICharacter character);
        void atackByDoubleStrike(ICharacter character);
        void atackByHoldStrike(ICharacter character);
        void atackByTail(ICharacter character);
    }
}
