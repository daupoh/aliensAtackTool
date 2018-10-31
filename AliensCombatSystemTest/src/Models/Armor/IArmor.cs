using AliensCombatSystemTest.src.Models.DamageTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models.Armor
{
    interface IArmor
    {        
        double getsHealthDamage (double allDmg, IDamageType dmgType);
        double getsArmorPoints();
        void setArmorType(SCDescriptors.marinesArmorTypes typeOfArmor);
        void setArmorMaxPoints(byte maxPoints);
        void restoreArmorPoints(byte restorePoints);
    }
}
