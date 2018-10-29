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
        IHit[] strikeHits();
        void addHit(IHit hit);
        byte getMaxHits();
        int getStrikeTime();
        IDamageType getDamageType();
        string getName();

    }
}
