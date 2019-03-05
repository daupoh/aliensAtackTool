using AliensCombatSystemTest.src.models.targets;
using AliensCombatSystemTest.src.models.weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.calculator
{
    class CAlienCalculator:ACCalculator
    {

        public CAlienCalculator(ACTarget target, ACWeapon weapon)
        {
            initializeTarget(target);
            initializeWeapon(weapon);
            m_eAccuracity = AccuracityMode.almostMiss;
        }
        public CAlienCalculator withTarget (ACTarget target)
        {
            initializeTarget(target);
            return this;
        }
        public CAlienCalculator withWeapon(ACWeapon weapon)
        {
            initializeWeapon(weapon);
            return this;
        }
        public CAlienCalculator almostMissMode()
        {
            m_eAccuracity = AccuracityMode.almostMiss;
            return this;
        }
        public CAlienCalculator lightHit()
        {
            m_eAccuracity = AccuracityMode.lightHit;
            return this;
        }
        public CAlienCalculator strongHit()
        {
            m_eAccuracity = AccuracityMode.strongHit;
            return this;
        }
        public CAlienCalculator criticalHit()
        {
            m_eAccuracity = AccuracityMode.criticalHit;
            return this;
        }

        public string TimeToKillWithFullArmor()
        {
            string timeToKill = "";
            timeToKill = TimeToKillWithVariableArmor(100);
            return timeToKill;
        }
        public string TimeToKillWithZeroArmor()
        {
            string timeToKill = "";
            timeToKill = TimeToKillWithVariableArmor(0);
            return timeToKill;
        }
        public string TimeToKillWithVariableArmor(int armor)
        {
            string timeToKill = "";

            return timeToKill;
        }
        
    }
}
