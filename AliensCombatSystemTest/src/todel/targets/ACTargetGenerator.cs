using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.targets
{
    abstract class ACTargetGenerator
    {
         protected string[] m_aStrSettings;
        protected int[] m_aIntegerSettings;
        protected double[] m_aFloatSettings;
        protected string m_sClassName = "";
    }
}
