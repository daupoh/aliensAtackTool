using AliensCombatSystemTest.src.Models.Armor;
using AliensCombatSystemTest.src.Models.DamageTypes;
using AliensCombatSystemTest.src.Models.Hits;
using AliensCombatSystemTest.src.Models.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models.Characters.Marines
{
    class CMarineCharacter:IMarineCharacter
    {
        byte m_uiHealthCurrentPoints, m_uiHealthMaxPoints;
        IArmor m_pArmor;
        string m_strName;
        string m_strStatus;

        public CMarineCharacter(string name,byte maxHP)
        {
            SCChecker.checkNumberMoreThenZero(maxHP);
            SCChecker.checkStringIsNotEmpty(name);

            m_strName = name;
            m_uiHealthMaxPoints = maxHP;
            m_uiHealthCurrentPoints = maxHP;
            m_strStatus = SCMarineStatus.standStatus;
        }
        public void setHealthPoint(byte hp)
        {
            m_uiHealthCurrentPoints = hp;
        }
        public void setArmorPoints(byte ap)
        {
            m_pArmor.setArmorMaxPoints(ap);
        }
        public string getName()
        {
            return m_strName;
        }
        public void restoreArmorhPoints(byte restorePoints)
        {
            m_pArmor.restoreArmorPoints(restorePoints);
        }
        public void getsDamage(IWeapon weapon)
        {
            IList<IHit> hits = weapon.strikeHits();           
            double allDmg = 0;
            IDamageType dmgType = weapon.getDamageType();
            foreach (IHit hit in hits)
            {
                allDmg += hit.getDamage();

            }
            getsDamaged(allDmg, dmgType);
        }

        public byte getHealthPoint() {
            return m_uiHealthCurrentPoints;
        }
        public byte getArmorPoints() {
            return (byte)m_pArmor.getsArmorPoints();
        }
        private void getsDamaged(double dmg, IDamageType dmgType) {
            byte healthDmg = 0;
            healthDmg = (byte)m_pArmor.getsHealthDamage(dmg, dmgType);
            healthGetsDamage(healthDmg);
        }

        public void setArmor(IArmor armor)
        {
            SCChecker.checkObjectIsNotNull(armor,"Невозможно в качестве брони использовать Null");
            m_pArmor = armor;
        }
        public string getStatus()
        {
            return m_strStatus;
        }

        public void restoreHealthPoints(byte restorePoints)
        {
            SCChecker.checkNumberMoreThenZero(restorePoints);
            m_uiHealthCurrentPoints += restorePoints;
            if (m_uiHealthCurrentPoints>m_uiHealthMaxPoints)
            {
                m_uiHealthCurrentPoints = m_uiHealthMaxPoints;
            }
        }

        private void healthGetsDamage(byte dmg)
        {
            m_uiHealthCurrentPoints = (byte)(m_uiHealthCurrentPoints - dmg);
            if (m_uiHealthCurrentPoints <= 0)
            {
                m_uiHealthCurrentPoints = 0;
                m_strStatus = SCMarineStatus.deadStatus;
            }
        }
    }
}
