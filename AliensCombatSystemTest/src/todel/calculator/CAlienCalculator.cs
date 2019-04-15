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

        public CAlienCalculator(ACTarget target, CWeapon weapon)
        {
            initializeTarget(target);
            initializeWeapon(weapon);
            m_eAccuracity = AccuracityMode.almostMiss;
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

        public override string[] getCalculate()
        {
            throw new NotImplementedException();
           
        }
    }
}
