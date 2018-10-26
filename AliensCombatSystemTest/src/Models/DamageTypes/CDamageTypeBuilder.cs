using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models.DamageTypes
{
    class CDamageTypeBuilder:IDamageTypeBuilder
    {
        string m_strName;
        double m_dbDmg, m_dbAutoDmgMod;
        byte m_uiMaxHits;

        IDamageType m_pDamageType;

        public CDamageTypeBuilder ()
        {
            prepareDamageType();
        }

        public IDamageTypeBuilder withName(string name)
        {
            m_strName = name;
            return this;
        }
        public IDamageTypeBuilder withDamage(double dmg)
        {
            m_dbDmg = dmg;
            return this;
        }
        public IDamageTypeBuilder withAutoDamageMod(double autoDmgMod)
        {
            m_dbAutoDmgMod = autoDmgMod;
            return this;
        }
        public IDamageTypeBuilder withMaxHits(byte maxHits)
        {
            m_uiMaxHits = maxHits;
            return this;
        }

        public void restore()
        {
            prepareDamageType();
        }
        public IDamageType build()
        {
            m_pDamageType.setAutoDmgMod(m_dbAutoDmgMod);
            m_pDamageType.setDamage(m_dbDmg);
            m_pDamageType.setMaxHits(m_uiMaxHits);
            m_pDamageType.setName(m_strName);

            return m_pDamageType;
        }

        private void prepareDamageType()
        {
            m_pDamageType = new CDamageType();
            m_strName = "";
            m_uiMaxHits = 0;
            m_dbDmg = 0;
            m_dbAutoDmgMod = 0;
        }
    }
}
