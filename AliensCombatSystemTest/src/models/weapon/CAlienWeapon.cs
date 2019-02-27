using AliensCombatSystemTest.src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.weapon
{
    class CAlienWeapon:ACWeapon
    {
        int m_iVectorsOnAtack, m_iDmgOnAtack, m_iStrikesOnAtack,m_iDmgByTime, m_iDurationDmgByTime;
        double m_dbAutoDmgOnAtack, m_dbTimeOnStrike, m_dbHumanResist, m_dbSynthResist,m_dbDmgOnArmorMod,m_dbNockdownHealthThreshold;
        public CAlienWeapon(string name,int[] integerSettings,double[] floatSettings)
        {
            SCChecker.CheckStringIsNotEmpty(name);
            foreach(int i in integerSettings)
            {
                SCChecker.CheckNumberMoreThenZero(i);
            }
            foreach (double f in floatSettings)
            {
                SCChecker.CheckNumberMoreThenZero(f);
            }
            m_sName = name;
            m_iVectorsOnAtack = integerSettings[0];
            m_iDmgOnAtack= integerSettings[1];
            m_iStrikesOnAtack= integerSettings[2];
            m_iDmgByTime = integerSettings[3];
            m_iDurationDmgByTime = integerSettings[4];
            m_dbAutoDmgOnAtack = floatSettings[0];
            m_dbTimeOnStrike = floatSettings[1];
            m_dbHumanResist = floatSettings[2];
            m_dbSynthResist= floatSettings[3];
            m_dbDmgOnArmorMod = floatSettings[4];
            m_dbNockdownHealthThreshold = floatSettings[5];
        }
        public override string[] TableFormat
        {
            get
            {
                string[] tableFormat = new string[14];
                tableFormat[0] = m_sName;
                tableFormat[1] = m_iVectorsOnAtack.ToString();
                tableFormat[2] = m_iDmgOnAtack.ToString();
                tableFormat[3] = m_iStrikesOnAtack.ToString();
                tableFormat[4] = m_iDmgByTime.ToString();
                tableFormat[5] = m_iDurationDmgByTime.ToString();
                tableFormat[6] = m_dbAutoDmgOnAtack.ToString();
                tableFormat[7] = m_dbTimeOnStrike.ToString();
                tableFormat[8] = m_dbDmgOnArmorMod.ToString();
                tableFormat[9] = m_dbTimeOnStrike.ToString();
                tableFormat[10] = m_dbHumanResist.ToString();
                tableFormat[11] = m_dbSynthResist.ToString();
                tableFormat[12] = m_dbDmgOnArmorMod.ToString();
                tableFormat[13] = m_dbNockdownHealthThreshold.ToString();

                return tableFormat;
            }
        }
    }
}
