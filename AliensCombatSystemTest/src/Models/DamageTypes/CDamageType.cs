using AliensCombatSystemTest.src.Models.Hits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models.DamageTypes
{
    class CDamageType:IDamageType
    {
        string m_strName;
        double m_dbDmg, m_dbAutoDmgMod;
        byte m_uiMaxHits;

        public CDamageType()
        {
            m_strName = "";
            m_uiMaxHits = 0;
            m_dbDmg = 0;
            m_dbAutoDmgMod = 0;
        }
       
        public string getName()
        {
            return m_strName;
        }
        public void setName(string name)
        {
            SCChecker.checkStringIsNotEmpty(name);
            m_strName = name;
        }
        public double getDamage()
        {
            return m_dbDmg;
        }
        public byte getMaxHits()
        {
            return m_uiMaxHits;
        }
        public void setDamage(double dmg)
        {
            SCChecker.checkNumberMoreThenZero(dmg);
            m_dbDmg = dmg;
        }
        public void setMaxHits(byte count)
        {
            SCChecker.checkNumberMoreThenZero(count);
            m_uiMaxHits = count;
        }

        public double getAutoDmg()
        {
            return m_dbAutoDmgMod;
        }

        public void setAutoDmgMod(double mod)
        {
            SCChecker.checkNumberMoreThenZero(mod);
            m_dbAutoDmgMod = mod;
        }

    }
}
