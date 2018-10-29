using AliensCombatSystemTest.src.Models.DamageTypes;
using AliensCombatSystemTest.src.Models.Hits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models.Weapons
{
    class CAlienWeapon:IAlienWeapon
    {
        string m_strName;
        IDamageType m_pDamageType;
        IList<IHit> m_lsHits;
        int m_uiTimeAnimation;

        public CAlienWeapon(string name, IDamageType dmgType)
        {
            SCChecker.checkStringIsNotEmpty(name);
            m_strName = name;
            SCChecker.checkObjectIsNotNull(dmgType);
            m_pDamageType = dmgType;
        }
        public string getName()
        {
            return m_strName;
        }
        public IDamageType getDamageType()
        {
            return m_pDamageType;
        }
        public byte getMaxHits()
        {
            return m_pDamageType.getMaxHits();
        }
        public IHit[] strikeHits()
        {
            return m_lsHits.ToArray();
        }
        public void addHit(IHit hit)
        {
            SCChecker.checkObjectIsNotNull(hit);
            SCChecker.checkFirstNumberMoreOrEquivalThenSecond(m_pDamageType.getMaxHits()
                , m_lsHits.Count + 1);
            hit.setHitDmgType(m_pDamageType);
            m_lsHits.Add(hit);
        }

        public void setStrikeTime(int time) {
            SCChecker.checkNumberMoreThenZero(time);
            m_uiTimeAnimation = time;
        }
        
        public int getStrikeTime() {
            return m_uiTimeAnimation;
        }
    }
}
