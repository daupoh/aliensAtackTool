using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.weapon
{
    abstract class ACWeaponGenerator
    {
        protected string m_sWeaponName;
        protected int[] m_aIntegerSettings;
        protected double[] m_aFloatSettings;
        protected string[] m_aStrSettings;
    }
}
