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
        uint m_uiTimeAnimation;

        public CAlienWeapon(string name, IDamageType dmgType)
        {
            SCChecker.checkStringIsNotEmpty(name);
            m_strName = name;
            SCChecker.checkObjectIsNotNull(dmgType, "Невозможно установить пустой тип урона");
            m_lsHits = new List<IHit>();
            m_pDamageType = dmgType;
        }
        public void clearHits()
        {
            m_lsHits.Clear();
        }
        public void setDamage(double dmg)
        {
            SCChecker.checkObjectIsNotNull(m_pDamageType, "Невозможно установить пустой тип урона");
            m_pDamageType.setDamage(dmg);
        }
        public void setMaxHits(byte count)
        {
            SCChecker.checkObjectIsNotNull(m_pDamageType, "Невозможно установить пустой тип урона");
            m_pDamageType.setMaxHits(count);
        }
        public void setAutoDmgMod(double mod)
        {
            SCChecker.checkObjectIsNotNull(m_pDamageType, "Невозможно установить пустой тип урона");
            m_pDamageType.setAutoDmgMod(mod);
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
        public IList<IHit> strikeHits()
        {           
            return m_lsHits;
        }
        public void addHit(IHit hit)
        {
            SCChecker.checkObjectIsNotNull(hit,"Невозможно добавить пустое Попадание");
            SCChecker.checkFirstNumberMoreOrEquivalThenSecond(m_pDamageType.getMaxHits()
                , m_lsHits.Count + 1);
            hit.setHitDmgType(m_pDamageType);
            m_lsHits.Add(hit);
        }

        public void setStrikeTime(uint time) {
            SCChecker.checkNumberMoreThenZero(time);
            m_uiTimeAnimation = time;
        }
        
        public uint getStrikeTime() {
            return m_uiTimeAnimation;
        }
    }
}
