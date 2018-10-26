using AliensCombatSystemTest.src.Models.DamageTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models.Hits
{
     class CHit:IHit
    {
        IHitBox m_pHitBox;
        IDamageType m_pDamageType;

        
        public double getDamage()
        {
            double dmg = 0;
            if (m_pHitBox is CHitBoxMiss)
            {
                dmg = m_pHitBox.getModDmg(m_pDamageType.getAutoDmg());
            }
            else
            {
                dmg = m_pHitBox.getModDmg(m_pDamageType.getDamage());
            }
            return dmg;
        }
        public void hitOn(IHitBox atackedHitBox)
        {
            SCChecker.checkObjectIsNotNull(atackedHitBox);
            m_pHitBox = atackedHitBox;
        }

        public void setHitDmgType(IDamageType dmgType)
        {
            SCChecker.checkObjectIsNotNull(dmgType);
            m_pDamageType = dmgType;
        }

       
    }
}
