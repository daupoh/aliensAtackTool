using AliensCombatSystemTest.src.Models.Hits;
using AliensCombatSystemTest.src.Models.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models.Characters.Aliens
{
    class CAlienCharacter:IAlienCharacter
    {
        IAlienWeapon m_pWeaponBite, m_pWeaponHoldBite, m_pWeaponStrike, 
            m_pWeaponHoldStrike, m_pWeaponTail;
        string m_strName;

        public CAlienCharacter(string name)
        {
            SCChecker.checkStringIsNotEmpty(name);
            m_strName = name;
        }
        public string getName()
        {
            return m_strName;
        }
        public IAlienWeapon getBiteWeapon()
        {
            return m_pWeaponBite;
        }
        public IAlienWeapon getHoldBiteWeapon() { return m_pWeaponHoldBite; }
        public IAlienWeapon getStrikeWeapon() { return m_pWeaponStrike; }
        public IAlienWeapon getHoldStrikeWeapon() { return m_pWeaponHoldStrike; }
        public IAlienWeapon getTailWeapon() { return m_pWeaponTail; }

        public void getsDamage(IWeapon weapon) { }

        public void setBiteWeapon(IAlienWeapon weapon) {
            SCChecker.checkObjectIsNotNull(weapon);
            m_pWeaponBite = weapon;
        }
        public void setHoldBiteWeapon(IAlienWeapon weapon)
        {
            SCChecker.checkObjectIsNotNull(weapon);
            m_pWeaponHoldBite = weapon;
        }
        public void setStrikeWeapon(IAlienWeapon weapon) {
            SCChecker.checkObjectIsNotNull(weapon);
            m_pWeaponStrike = weapon;
        }
        public void setHoldStrikeWeapon(IAlienWeapon weapon) {
            SCChecker.checkObjectIsNotNull(weapon);
            m_pWeaponHoldStrike = weapon;
        }
        public void setTailWeapon(IAlienWeapon weapon) {
            SCChecker.checkObjectIsNotNull(weapon);
            m_pWeaponTail = weapon;
        }

        public void atackByBite(ICharacter character) {
            SCChecker.checkObjectIsNotNull(character);
            character.getsDamage(m_pWeaponBite);
        }
        public void atackByHoldBite(ICharacter character) {
            SCChecker.checkObjectIsNotNull(character);
            character.getsDamage(m_pWeaponHoldBite);
        }
        public void atackByStrike(ICharacter character) {
            SCChecker.checkObjectIsNotNull(character);
            character.getsDamage(m_pWeaponStrike);
        }
        public void atackByDoubleStrike(ICharacter character) {
            SCChecker.checkObjectIsNotNull(character);
            character.getsDamage(m_pWeaponBite);
        }
        public void atackByHoldStrike(ICharacter character) {
            SCChecker.checkObjectIsNotNull(character);
            character.getsDamage(m_pWeaponHoldStrike);
        }
        public void atackByTail(ICharacter character) {
            SCChecker.checkObjectIsNotNull(character);
            character.getsDamage(m_pWeaponTail);
        }
    }
}
