using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.targets
{
    abstract class ACTarget
    {
        protected string m_sName, m_sBuilderEffect;
        protected double m_dbHeadHitBoxMod, m_dbBodyHitBoxMod, m_dbArmsHitBoxMod, m_dbLegsHitBoxMod;
        public string NameOfClass { get { return m_sName; } }
        public abstract string[] TableFormat { get; }
    }
}
