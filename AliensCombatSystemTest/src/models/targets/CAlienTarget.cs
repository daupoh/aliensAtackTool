using AliensCombatSystemTest.src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.targets
{
    
    class CAlienTarget : ACTarget
    {
        string m_sTypeOfWeapon, m_sBarricadeEffect;
     

        public CAlienTarget(string name,string[] strSettings, int[] integerSettings, double[] floatSettings)
        {
            SCChecker.checkSettings(name, strSettings, integerSettings, floatSettings);

            m_sName = name;
            m_dbHeadHitBoxMod = floatSettings[0];
            m_dbBodyHitBoxMod = floatSettings[1];
            m_dbArmsHitBoxMod = floatSettings[2];
            m_dbLegsHitBoxMod = floatSettings[3];
            m_sTypeOfWeapon = strSettings[0];
            m_sBarricadeEffect= strSettings[1];
            m_sBuilderEffect = strSettings[2];

        }
        public override string[] TableFormat
        {
            get
            {
                string[] tableFormat = new string[8];
                tableFormat[0] = m_sName;
                tableFormat[1] = m_dbHeadHitBoxMod.ToString(); ;
                tableFormat[2] =m_dbBodyHitBoxMod.ToString(); ;
                tableFormat[3] =m_dbArmsHitBoxMod.ToString(); ;
                tableFormat[4] =m_dbLegsHitBoxMod.ToString(); ;
                tableFormat[5] =m_sTypeOfWeapon;
                tableFormat[6] =m_sBarricadeEffect;
                tableFormat[7] =m_sBuilderEffect;
                return tableFormat;
            }
        }
        public string TypeOfWeapon { get { return m_sTypeOfWeapon; } }
        public string BarricadeEffect { get { return m_sBarricadeEffect; } }
        public string BuilderEffect { get { return m_sBuilderEffect; } }
        public double HeadHitBoxMod { get { return m_dbHeadHitBoxMod; } }
        public double BodyHitBoxMod { get { return m_dbBodyHitBoxMod; } }
        public double ArmsHitBoxMod { get { return m_dbArmsHitBoxMod; } }
        public double LegsHitBoxMod { get { return m_dbLegsHitBoxMod; } }
    }
}
