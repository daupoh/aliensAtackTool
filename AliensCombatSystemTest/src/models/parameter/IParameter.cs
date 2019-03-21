using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.parameter
{
    interface IParameter
    {
        string NameParameter
        { get; }
        double Value { get; }
        string View { get; }
    }
}
