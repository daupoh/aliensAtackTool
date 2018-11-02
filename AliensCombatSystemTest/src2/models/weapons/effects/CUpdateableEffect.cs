using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src2.models.weapons.effects
{
    class CUpdateableEffect : IUpdateableEffect
    {
        string m_strName;
        bool m_bActive = false;
        uint m_dbTimePeriod = 0, m_dbTimeAll = 0, m_dbTimeCurrent = 0;
        public string Name
        {
            get
            {
                return m_strName;
            }
        }
        public bool EffectActive
        {
            get
            {
                return m_bActive;
            }
        }


        public CUpdateableEffect(uint allTime, uint timePeriod)
        {

        }
        public void effectStartAct()
        {
            m_bActive = true;
        }
        public void updateEffect()
        {

        }

        public double[] getEffect(double timePassed) //double[3] = {{healthDmg}, {armorDmg}, {positionChange}, {mark}} 
        {
            double[] effects = new double[4]; //magic number

            return effects;
        }
    }
}
