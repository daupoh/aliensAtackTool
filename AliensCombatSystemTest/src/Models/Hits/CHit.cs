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
            dmg = m_pHitBox.getModedDmg(m_pDamageType.getDamage());            
            return dmg;
        }
        public string getName()
        {
            return m_pHitBox.getName();
        }
        public void hitOn(IHitBox atackedHitBox)
        {
            SCChecker.checkObjectIsNotNull(atackedHitBox,"Невозможно атаковать пустой хит-бокс.");
            m_pHitBox = atackedHitBox;
        }

        public void setHitDmgType(IDamageType dmgType)
        {
            SCChecker.checkObjectIsNotNull(dmgType,"Невозможно установить пустой тип урона");
            m_pDamageType = dmgType;
        }

       
    }
}
