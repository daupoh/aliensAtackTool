using AliensCombatSystemTest.src.models.parameter;
using AliensCombatSystemTest.src.models.parametersPool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.weapon
{
     interface ICombatEntity : IEntity
    {

        double getParameterValueByName(string namePool, string nameParameter);
        string getParameterPoolViewByName(string name);
        
        void AddParameterPool(IParametersPool parametersPool);

    }
}
