using AliensCombatSystemTest.src.models.parameter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.parametersPool
{
     interface IParametersPool:IEntity
    {
        string TableView { get; }
        void AddParameter(IParameter parameter);
        double getValueByParameter(string name);
    }
}
