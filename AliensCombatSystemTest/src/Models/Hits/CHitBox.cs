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
        public string getName()
        {
            return m_strName;
        }
        public double getDmgMod()
        {
            return m_dbModDmg;
        }
        public void setModDmg(double mode)
        {
            m_dbModDmg = mode;
        }
        public double getModedDmg(double dmgOfVector)
        {
            double dmg = 0;
            dmg =dmgOfVector * m_dbModDmg;
            return dmg;
        }

    
        }
    }

