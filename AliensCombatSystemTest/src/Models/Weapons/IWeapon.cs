using AliensCombatSystemTest.src.Models.DamageTypes;
using AliensCombatSystemTest.src.Models.Hits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models.Weapons
{
    public interface IWeapon
    {
        IList<IHit> strikeHits();
        void addHit(IHit hit);
        byte getMaxHits();

        void setDamage(double dmg);
        void setMaxHits(byte count);
        void setAutoDmgMod(double mod);       

        

        IDamageType getDamageType();
        string getName();

    }
}
