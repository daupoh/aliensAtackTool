using AliensCombatSystemTest.src.Models.Armor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models.Characters.Marines
{
    interface IMarineCharacter:ICharacter
    {
        byte getHealthPoint();
        byte getArmorPoints();      

        void setArmor(IArmor armor);
        string getStatus();
        void restoreHealthPoints(byte restorePoints);
        void restoreArmorhPoints(byte restorePoints);
    }
}
