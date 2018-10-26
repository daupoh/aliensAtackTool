using AliensCombatSystemTest.src.Models.DamageTypes;
using AliensCombatSystemTest.src.Models.Hits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models.Weapons
{
    public interface IAlienWeapon:IWeapon
    {
        
        void addHit(IHit hit);
        void setStrikeTime(int time);
        IHit[] strikeHits();
        int getStrikeTime();
    }
}
