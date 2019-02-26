using AliensCombatSystemTest.src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.weapon
{
    class CHumanShootWeapon : ACWeapon
    {
        int m_iAmmo, m_iDmgOnBullet, m_iRateOfFire, m_iAcidDmgByBullet;
        double m_dbDmgOnBodyPointMod, m_dbExtraDmgByRestBodyPointMod, m_dbGuardsResist, m_dbRunnersResist, m_dbWorkersResist, m_dbSoldiersResist, m_dbTimeOfOverHeat;

        public CHumanShootWeapon(string name,int[] integerSettings, double[] floatSettings)
        {
            SCChecker.CheckStringIsNotEmpty(name);
            foreach (int i in integerSettings)
            {
                SCChecker.CheckNumberMoreThenZero(i);
            }
            foreach (double f in floatSettings)
            {
                SCChecker.CheckNumberMoreThenZero(f);
            }
            m_sName = name;
            m_iAmmo = integerSettings[0];
            m_iDmgOnBullet= integerSettings[1];
            m_iRateOfFire= integerSettings[2];
            m_iAcidDmgByBullet= integerSettings[3];
            m_dbSoldiersResist = floatSettings[0];
            m_dbDmgOnBodyPointMod = floatSettings[1];
            m_dbExtraDmgByRestBodyPointMod= floatSettings[2];
            m_dbGuardsResist= floatSettings[3];
            m_dbRunnersResist= floatSettings[4];
            m_dbWorkersResist= floatSettings[5];
            
            
        }
        public override string[] TableFormat
        {
            get
            {
                string[] tableFormat = new string[11];

                tableFormat[0] = m_sName;
                tableFormat[1] = m_iAmmo.ToString();
                tableFormat[2] = m_iDmgOnBullet.ToString();
                tableFormat[3] = m_iRateOfFire.ToString();                
                tableFormat[4] = m_iAcidDmgByBullet.ToString();
                tableFormat[5] = m_dbTimeOfOverHeat.ToString();
                tableFormat[6] = m_dbDmgOnBodyPointMod.ToString();
                tableFormat[7] = m_dbExtraDmgByRestBodyPointMod.ToString();
                tableFormat[8] = m_dbGuardsResist.ToString();
                tableFormat[9] = m_dbRunnersResist.ToString();
                tableFormat[10] = m_dbWorkersResist.ToString();
                tableFormat[11] = m_dbSoldiersResist.ToString();
                
                return tableFormat;
            }
        }
    }
}
