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

        private ACCombatBuilder (string name):base(name)
        {
            m_lsCombatEntities = new List<ICombatEntity>();
        }

        public IList<ICombatEntity> CombatEntities
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
