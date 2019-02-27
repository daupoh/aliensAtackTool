using AliensCombatSystemTest.src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.targets
{
    class CHumanTarget : ACTarget
    {
        int m_iDistance;
        string m_sBuilderEffect;
        public CHumanTarget(string name, string[] strSettings, int[] integerSettings, double[] floatSettings)
        {
            SCChecker.checkSettings(name, strSettings, integerSettings, floatSettings);

            m_sName = name;
            m_dbHeadHitBoxMod = floatSettings[0];
            m_dbBodyHitBoxMod = floatSettings[1];
            m_dbArmsHitBoxMod = floatSettings[2];
            m_dbLegsHitBoxMod = floatSettings[3];
            m_iDistance = integerSettings[0];            
            m_sBuilderEffect = strSettings[0];

        }
        public override string[] TableFormat
        {
            get
            {
                string[] tableFormat = new string[7];
                tableFormat[0] = m_sName;
                tableFormat[1] = m_dbHeadHitBoxMod.ToString(); 
                tableFormat[2] = m_dbBodyHitBoxMod.ToString(); 
                tableFormat[3] = m_dbArmsHitBoxMod.ToString(); 
                tableFormat[4] = m_dbLegsHitBoxMod.ToString(); 
                tableFormat[5] = m_iDistance.ToString(); 
                tableFormat[6] = m_sBuilderEffect; 

                return tableFormat;
            }
        }
    }
}
