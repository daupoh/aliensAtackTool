using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models.Hits
{
    class CHitBox:IHitBox
    {
        string m_strName;
        double m_dbModDmg;

        public CHitBox(string name,double mod)
        {
            SCChecker.checkStringIsNotEmpty(name);
            SCChecker.checkNumberMoreThenZero(mod);
            m_strName = name;
            m_dbModDmg = mod;
        }

        public double getModDmg(double dmgOfVector)
        {
            double dmg = 0;
            dmg =dmgOfVector * m_dbModDmg;
            return dmg;
        }

    
        }
    }

