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
        private double getAllDmg()
        {
            double allDmg = 0;
            string alienClass = m_pTarget.NameOfClass;
            double resist = 0, hitMode=0;
            switch (alienClass)
            {
                case "Чужой-Рабочий":
                    resist = (m_pWeapon as CHumanShootWeapon).WorkersResist;
                    break;
                case "Чужой-Строитель":
                    resist = (m_pWeapon as CHumanShootWeapon).WorkersResist;
                    break;
                case "Чужой-Разведчик":
                    resist = (m_pWeapon as CHumanShootWeapon).RunnersResist;
                    break;
                default: break;
            }
            switch (m_eAccuracity)
            {
                case AccuracityMode.almostMiss:
                    hitMode = 0.65;
                    break;
                case AccuracityMode.lightHit:
                    hitMode = 0.8;
                    break;
                case AccuracityMode.strongHit:
                    hitMode = 1.0;
                    break;
                case AccuracityMode.criticalHit:
                    hitMode = 1.7;
                    break;
            }
            allDmg = (1 - resist) * (m_pWeapon as CHumanShootWeapon).DmgOnBullet * hitMode;
            return allDmg;
        }
        private double getAllTimeShooting()
        {
            double allTime = 0;
            allTime =(m_pWeapon as CHumanShootWeapon).Ammo / ((m_pWeapon as CHumanShootWeapon)
                                                                    .RateOfFire / 60);
            return allTime;
        }
       
    }
}
