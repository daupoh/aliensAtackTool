using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AliensCombatSystemTest.src.models.weapon;

namespace AliensCombatSystemTest.src.models.combatBuilder
{
     abstract class ACCombatBuilder : ACEntity, ICombatBuilder
    {
        protected IList<ICombatEntity> m_lsCombatEntities;
        protected ICombatEntity m_pCurrentCombatEntity;
        protected string[] m_asTypesCodes, m_asCombatsNames;
        protected ACCombatBuilder (string name):base(name)
        {
            m_lsCombatEntities = new List<ICombatEntity>();
        }

        public IList<ICombatEntity> CombatEntities
        {
            get
            {
                IList<ICombatEntity> result;
                if (m_lsCombatEntities.Count!=0)
                {
                    result = m_lsCombatEntities;
                }
                else
                {
                    throw new FormatException();
                }
                return result;
            }
        }
        protected void AddCombat()
        {
            int index = 0;
            foreach (string s in m_asTypesCodes)
            {
                m_pCurrentCombatEntity = new CCombatEntity(m_asCombatsNames[index]);
                AddAtack(s);
                m_lsCombatEntities.Add(m_pCurrentCombatEntity);
                index++;
            }
        }
        protected abstract void AddAtack(string typeCode);
        
    }
}
