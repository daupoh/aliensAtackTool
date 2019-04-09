using AliensCombatSystemTest.src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.parameter
{
    class CIntNumbParameter : ACParameter
    {
        public CIntNumbParameter(double value, string name):base(name)
        {
            SCChecker.CheckNumberMoreOrEqualThenZero(value);
            m_fValue = value;
        }
        public override double Value
        {
            get
            {
                return Math.Round(m_fValue);
            }
        }
      
    }
}
