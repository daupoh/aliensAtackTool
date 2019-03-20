using AliensCombatSystemTest.src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.targets
{
     class CHumanTargetGenerator:ACTargetGenerator
    {
        private void genericAlien(string name,int distance )
        {
            m_sClassName = name;
            m_aStrSettings = new string[1];
            m_aFloatSettings = new double[5];
            m_aIntegerSettings = new int[1];
            double[] mods = SCChecker.GetDefaultModHitBoxes();

            m_aIntegerSettings[0] = distance;
            m_aFloatSettings[0] = mods[0];
            m_aFloatSettings[1] = mods[1];
            m_aFloatSettings[2] = mods[2];
            m_aFloatSettings[3] = mods[3];
            
            m_aStrSettings[0] = "нет";
        }  
        public CHumanTarget generateWorkerClass()
        {
            CHumanTarget worker =null;
            genericAlien("Чужой-Рабочий", 100);
            m_aFloatSettings[4] = 50;
            worker = new CHumanTarget(m_sClassName, m_aStrSettings, m_aIntegerSettings, m_aFloatSettings);
            return worker;
        }
        public CHumanTarget generateBuilderClass()
        {
            CHumanTarget builder = null;
            genericAlien("Чужой-Строитель", 100);
            m_aFloatSettings[4] = 50;
            builder = new CHumanTarget(m_sClassName, m_aStrSettings, m_aIntegerSettings, m_aFloatSettings);
            return builder;
        }
        public CHumanTarget generateScoutClass()
        {
            CHumanTarget scout = null;
            genericAlien("Чужой-Разведчик", 100);
            m_aFloatSettings[4] = 40;
            scout = new CHumanTarget(m_sClassName, m_aStrSettings, m_aIntegerSettings, m_aFloatSettings);
            return scout;
        }
         CHumanTarget generateStalkerClass()
        {
            CHumanTarget stalker = null;

            return stalker;
        }
         CHumanTarget generateGuardianClass()
        {
            CHumanTarget guard = null;

            return guard;
        }
         CHumanTarget generateCrusherClass()
        {
            CHumanTarget crush = null;

            return crush;
        }
    }
}
