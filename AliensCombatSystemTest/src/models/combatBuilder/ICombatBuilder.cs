using AliensCombatSystemTest.src.models.weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.combatBuilder
{
    interface ICombatBuilder
    {
        IList<ICombatEntity> CombatEntities { get; }
        
    }
}
