using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.weapon
{
   abstract class ACWeapon
    {
        protected string m_sName = "";
        public string Name {
            get
            {
                return m_sName;
            }
        }

        public abstract string[] TableFormat { get; }
    }
}
