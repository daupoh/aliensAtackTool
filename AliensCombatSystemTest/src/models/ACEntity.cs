using AliensCombatSystemTest.src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models
{
     abstract class ACEntity
    {
        protected string m_sName = "";

        public string Name { get { return m_sName; } }

        protected ACEntity(string name)
        {
            SCChecker.CheckStringIsNotEmpty(name);
            m_sName = name;
        }
        
        
    }
}
