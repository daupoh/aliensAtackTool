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
        public abstract string[] getCalculate();
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
        protected ACCalculator withTarget(ACTarget target)
        {
            initializeTarget(target);
            return this;
        }
        protected ACCalculator withWeapon(ACWeapon weapon)
        {
            initializeWeapon(weapon);
            return this;
        }
        protected ACCalculator almostMissMode()
        {
            m_eAccuracity = AccuracityMode.almostMiss;
            return this;
        }
        protected ACCalculator lightHit()
        {
            m_eAccuracity = AccuracityMode.lightHit;
            return this;
        }
        protected ACCalculator strongHit()
        {
            m_eAccuracity = AccuracityMode.strongHit;
            return this;
        }
        protected ACCalculator criticalHit()
        {
            m_eAccuracity = AccuracityMode.criticalHit;
            return this;
        }


    }
}
