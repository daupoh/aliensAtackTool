using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models.Weapons
{
    public interface IAlienWeaponBuilder
    {
        IAlienWeaponBuilder withMaxHits(byte maxHits);
        IAlienWeaponBuilder withStrikeTime(uint miliseconds);
        IAlienWeaponBuilder withDamageOnHit(double dmg);
        IAlienWeaponBuilder withAutoDmgMod(double autoDmgMod);
        IAlienWeaponBuilder withName(string name);
        IAlienWeaponBuilder withMetaClass(SCDamageTypeDescriptor.aliensMetaClasses metaClass);
        IAlienWeaponBuilder withWeaponKey(string key);

        void restore();
        IAlienWeapon build();
    }
}
