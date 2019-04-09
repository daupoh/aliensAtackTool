using System;
using AliensCombatSystemTest.src.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.parameter
{
    class CYesNoParameter : ACParameter
    {
        public CYesNoParameter(double value, string name):base(name)
        {
            SCChecker.CheckNumberBinary(value);
            m_fValue = value;
        }
        public override double Value
        {
            get
            {
                return Math.Round(m_fValue, 1);
            }
        }
       
    }
}
