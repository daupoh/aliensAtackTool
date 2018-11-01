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

        double atackByBite(ICharacter character);
        double atackByHoldBite(ICharacter character);
        double atackByStrike(ICharacter character);
        double atackByDoubleStrike(ICharacter character);
        double atackByHoldStrike(ICharacter character);
        double atackByTail(ICharacter character);
    }
}
