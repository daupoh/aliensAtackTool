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
        IAlienWeapon getBiteWeapon();
        IAlienWeapon getHoldBiteWeapon();
        IAlienWeapon getStrikeWeapon();
        IAlienWeapon getHoldStrikeWeapon();
        IAlienWeapon getTailWeapon();

        void setBiteWeapon(IAlienWeapon weapon);
        void setHoldBiteWeapon(IAlienWeapon weapon);
        void setStrikeWeapon(IAlienWeapon weapon);
        void setHoldStrikeWeapon(IAlienWeapon weapon);
        void setTailWeapon(IAlienWeapon weapon);

        void atackByBite(ICharacter character);
        void atackByHoldBite(ICharacter character);
        void atackByStrike(ICharacter character);
        void atackByDoubleStrike(ICharacter character);
        void atackByHoldStrike(ICharacter character);
        void atackByTail(ICharacter character);
    }
}
