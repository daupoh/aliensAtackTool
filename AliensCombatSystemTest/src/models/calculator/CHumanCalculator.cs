using AliensCombatSystemTest.src.models.targets;
using AliensCombatSystemTest.src.models.weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.calculator
{
    class CHumanCalculator:ACCalculator
    {

        public CHumanCalculator(ACTarget target, ACWeapon weapon)
        {
            initializeTarget(target);
            initializeWeapon(weapon);
            m_eAccuracity = AccuracityMode.almostMiss;
        }
        public string TimeToKillWithFullBodyPoints()
        {
            string timeToKill = "";
            timeToKill = TimeToKillWithVariableBodyPoints(100);
            return timeToKill;
        }
        public string TimeToKillWithZeroBodyPoints()
        {
            string timeToKill = "";
            timeToKill = TimeToKillWithVariableBodyPoints(0);
            return timeToKill;
        }
        public string TimeToKillWithVariableBodyPoints(int bodyPoints)
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
