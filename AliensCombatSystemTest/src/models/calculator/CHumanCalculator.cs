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
        public override string[] getCalculate()
        {
            string[] results = new string[22];
            for (int i = 0; i < results.Length; i++)
            {
                results[i] = "0.000";
            }
            results[0] = m_pWeapon.Name;
            results[1] = m_pTarget.NameOfClass;

            m_eAccuracity = AccuracityMode.criticalHit;
            int countFull = countOfHitsToKillWithFullBodyPoints(),
            countZero = countOfHitsToKillWithZeroBodyPoints();
            results[2] = (countFull / ((m_pWeapon as CHumanShootWeapon).RateOfFire / 60)).ToString();
            results[3] = (countZero*1.0 / ((m_pWeapon as CHumanShootWeapon).RateOfFire / 60)).ToString();

            m_eAccuracity = AccuracityMode.strongHit;
            countFull = countOfHitsToKillWithFullBodyPoints();
            countZero = countOfHitsToKillWithZeroBodyPoints();
            results[7] = (countFull / ((m_pWeapon as CHumanShootWeapon).RateOfFire / 60)).ToString();
            results[8] = (countZero * 1.0 / ((m_pWeapon as CHumanShootWeapon).RateOfFire / 60)).ToString();

            m_eAccuracity = AccuracityMode.lightHit;
            countFull = countOfHitsToKillWithFullBodyPoints();
            countZero = countOfHitsToKillWithZeroBodyPoints();
            results[12] = (countFull / ((m_pWeapon as CHumanShootWeapon).RateOfFire / 60)).ToString();
            results[13] = (countZero * 1.0 / ((m_pWeapon as CHumanShootWeapon).RateOfFire / 60)).ToString();

            m_eAccuracity = AccuracityMode.almostMiss;
            countFull = countOfHitsToKillWithFullBodyPoints();
            countZero = countOfHitsToKillWithZeroBodyPoints();
            results[17] = (countFull / ((m_pWeapon as CHumanShootWeapon).RateOfFire / 60)).ToString();
            results[18] = (countZero * 1.0 / ((m_pWeapon as CHumanShootWeapon).RateOfFire / 60)).ToString();

            return results;

        }

      
        private int countOfHitsToKillWithVarBodyPoints(int bodyPoints)
        {
            int countOfHits = 0;
            double hp = 200.0, bp = 2.0 * bodyPoints, dmgOnVector = getAllDmg(), 
                bonusDmg= getBonusDmg(dmgOnVector,bp);
            while (hp>=0.0)
            {
                bonusDmg = getBonusDmg(dmgOnVector, bp);
                double hpDmg = dmgOnVector + bonusDmg, 
                    bpDmg = hpDmg*(m_pWeapon as CHumanShootWeapon).DmgOnBodyPointMod;
                bp -= bpDmg;
                if (bp < 0.0)
                {
                    bp = 0.0;
                }
                hp -= hpDmg;
                countOfHits++;
            }
            return countOfHits;
        }
        
       private double getBonusDmg(double allDmg,double currentBP)
        {
            double bonusDmg = 0, bpDifference = 200.0-currentBP;
            if (Math.Round(bpDifference,2)!=0.00)
            {
                bonusDmg = (m_pWeapon as CHumanShootWeapon).ExtraDmgByRestBodyPointMod * allDmg
                    * (bpDifference / 100.0);
            }
            return bonusDmg;
        }
        private double getAllAcidDmg(int countHits)
        {
            double acidDmg = 0;

            return acidDmg;

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
        private int countOfHitsToKillWithFullBodyPoints()
        {
            int countOfHits = 0;
            countOfHits = countOfHitsToKillWithVarBodyPoints(100);
            return countOfHits;
        }
        private int countOfHitsToKillWithZeroBodyPoints()
        {
            int countOfHits = 0;
            countOfHits = countOfHitsToKillWithVarBodyPoints(0);
            return countOfHits;
        }

    }
}
