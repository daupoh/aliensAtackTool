using AliensCombatSystemTest.src.models.targets;
using AliensCombatSystemTest.src.models.weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.calculator
{
    abstract class ACCalculator
    {
        protected enum AccuracityMode
        {
            almostMiss, lightHit, strongHit, criticalHit
        }
        protected AccuracityMode m_eAccuracity;
        protected ACTarget m_pTarget;
        protected ACWeapon m_pWeapon;
        protected void initializeTarget(ACTarget target)
        {
            m_pTarget = target;           
        }
        protected void initializeWeapon(ACWeapon weapon)
        {           
            m_pWeapon = weapon;
        }
         


    }
}
