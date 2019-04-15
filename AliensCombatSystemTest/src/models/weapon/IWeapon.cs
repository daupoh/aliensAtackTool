using AliensCombatSystemTest.src.models.parameter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.weapon
{
    interface IWeapon:IEntity
    {
       
        double getParameterValueByName(string name);
    
    }
}
