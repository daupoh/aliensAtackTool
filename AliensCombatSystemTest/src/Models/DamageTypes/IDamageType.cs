using AliensCombatSystemTest.src.Models.Hits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models.DamageTypes
{
   public  interface IDamageType
    {
        string getName();
        double getDamage();
        byte getMaxHits();
        double getAutoDmg();
        void setDamage(double dmg);
        void setMaxHits(byte count);
        void setAutoDmgMod(double mod);
        void setName(string name);
        
    }
}
