using AliensCombatSystemTest.src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.weapon
{
    class CHumanShootWeapon : CWeapon
    {
        int m_iAmmo, m_iDmgOnBullet, m_iRateOfFire, m_iAcidDmgByBullet, m_iDmgByTime, m_iDurationDmgByTime;
        double m_dbDmgOnBodyPointMod, m_dbExtraDmgByRestBodyPointMod, m_dbGuardsResist, m_dbRunnersResist, m_dbWorkersResist, 
            m_dbSoldiersResist, m_dbTimeOfOverHeat, m_dbAcidDmgMod;

        public CHumanShootWeapon(string name,int[] integerSettings, double[] floatSettings)
        {
            
            m_sName = name;
            m_iAmmo = integerSettings[0];
            m_iDmgOnBullet= integerSettings[1];
            m_iRateOfFire= integerSettings[2];
            m_iAcidDmgByBullet= integerSettings[3];            
            m_iDmgByTime = integerSettings[4];
            m_iDurationDmgByTime = integerSettings[5];
            
            m_dbDmgOnBodyPointMod = floatSettings[0];
            m_dbExtraDmgByRestBodyPointMod = floatSettings[1];
            m_dbSoldiersResist = floatSettings[2];
            m_dbGuardsResist = floatSettings[3];
            m_dbRunnersResist= floatSettings[4];
            m_dbWorkersResist= floatSettings[5];
            m_dbAcidDmgMod = floatSettings[6];
            m_dbTimeOfOverHeat = floatSettings[7];
        }
        public override string[] TableFormat
        {
            get
            {
                string[] tableFormat = new string[15];

                tableFormat[0] = m_sName;
                tableFormat[1] = m_iAmmo.ToString();
                tableFormat[2] = m_iDmgOnBullet.ToString();
                tableFormat[3] = m_iRateOfFire.ToString();                
                tableFormat[4] = m_iAcidDmgByBullet.ToString();
                tableFormat[5] = m_iDmgByTime.ToString();
                tableFormat[6] = m_iDurationDmgByTime.ToString();
                tableFormat[7] = m_dbDmgOnBodyPointMod.ToString();
                tableFormat[8] = m_dbExtraDmgByRestBodyPointMod.ToString();
                tableFormat[9] = m_dbSoldiersResist.ToString();
                tableFormat[10] = m_dbGuardsResist.ToString();
                tableFormat[11] = m_dbRunnersResist.ToString();
                tableFormat[12] = m_dbWorkersResist.ToString();
                tableFormat[13] = m_dbAcidDmgMod.ToString();
                tableFormat[14] = m_dbTimeOfOverHeat.ToString();

                return tableFormat;
            }
        }
        public int Ammo { get { return m_iAmmo; } }
        public int DmgOnBullet { get { return m_iDmgOnBullet; } }
        public int RateOfFire { get { return m_iRateOfFire; } }
        public int AcidDmgByBullet { get { return m_iAcidDmgByBullet; } }
        public int DmgByTime { get { return m_iDmgByTime; } }
        public int DurationDmgByTime { get { return m_iDurationDmgByTime; } }

        public double DmgOnBodyPointMod { get { return m_dbDmgOnBodyPointMod; } }
        public double ExtraDmgByRestBodyPointMod { get { return m_dbExtraDmgByRestBodyPointMod; } }
        public double SoldiersResist { get { return m_dbSoldiersResist; } }
        public double GuardsResist { get { return m_dbGuardsResist; } }
        public double RunnersResist { get { return m_dbRunnersResist; } }
        public double WorkersResist { get { return m_dbWorkersResist; } }
        public double AcidDmgMod { get { return m_dbAcidDmgMod; } }
        public double TimeOfOverHeat { get { return m_dbTimeOfOverHeat; } }
    }
}
