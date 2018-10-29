using AliensCombatSystemTest.src.Models.CharacterGenerator;
using AliensCombatSystemTest.src.Models.Characters;
using AliensCombatSystemTest.src.Models.Characters.Aliens;
using AliensCombatSystemTest.src.Models.Characters.Marines;
using AliensCombatSystemTest.src.Models.Hits;
using AliensCombatSystemTest.src.Models.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Controllers
{
    class CFormController:IFormController
    {
        string[] m_astrAliensClasses, m_astrMarineClasses, m_astrAliensWeapons;
        string m_strCurrentAlien, m_strCurrentWeaponName,m_strCurrentMarineName;

        IAlienCharacter m_pAlienCharCurrent; IList<ICharacter> m_lstAliens, m_lstMarines;
        IMarineCharacter m_pMarineCharCurrent;
        IAlienWeapon m_pCurrentAlienWeaponCurrent; IList<IAlienWeapon> m_lstAliensWeapons;

        IHitBox[] m_apHits;
        ICharacterGenerator m_pCharacterGenerator;

        public CFormController(mainForm form)
        {
            m_pCharacterGenerator = new CCharacterGenerator();
            m_lstAliens = new List<ICharacter>();
            m_lstAliensWeapons = new List<IAlienWeapon>();
            m_lstMarines = new List<ICharacter>();

            prepareListsOfAliensAndMarines();

            setCurrentAlien();
            setCurrentMarine();
           
            setWeaponsOfCurrentAlienAndCurrentWeapon();

        }

        public string[] getAliensClasses()
        {
            string[] aliensClasses = new string[2];

            return aliensClasses;
        }
        public string[] getAliensWeapons()
        {
            string[] aliensClasses = new string[2];

            return aliensClasses;
        }
        public string[] getMarinesClasses()
        {
            string[] aliensClasses = new string[2];

            return aliensClasses;
        }
        public byte getCountOfVectors()
        {
            byte count = 0;

            return count;
        }
        public double getDamageOfVector()
        {
            double count = 0;

            return count;
        }
        public double getAutoDamageMod()
        {
            double count = 0;

            return count;
        }
        public double getTimeOnAnimation()
        {
            double count = 0;

            return count;
        }
        public byte getMarineHealthPoints()
        {
            byte count = 0;

            return count;
        }
        public byte getMarineArmorPoints()
        {
            byte count = 0;

            return count;
        }
        public string getMarineStatus()
        {
            string s = "";

            return s;
        }

        public void setHits(byte headCount, byte bodyCount, byte armsCount, byte legsCount) { }
        public void setHitBoxes(double headMod, double bodyMod, double armsMod, double legsMod) { }


        public void selectAlien(byte index) { }
        public void selectMarine(byte index) { }
        public void selectAlienWeapon(byte index) { }
        public void setCurrentWeapon() { }

        public void atackByBite() { }
        public void atackByHoldBite() { }
        public void atackByStrike() { }
        public void atackByHoldStrike() { }
        public void atackByTailStrike() { }

        public void restoreHP() { }
        public void restoreAP() { }

        public void startFight() { }
        public void endFight() {
            
        }

        private void setWeaponsOfCurrentAlienAndCurrentWeapon()
        {
            m_lstAliensWeapons.Clear();

            m_lstAliensWeapons.Add(m_pAlienCharCurrent.getBiteWeapon());
            m_lstAliensWeapons.Add(m_pAlienCharCurrent.getHoldBiteWeapon());
            m_lstAliensWeapons.Add(m_pAlienCharCurrent.getStrikeWeapon());
            m_lstAliensWeapons.Add(m_pAlienCharCurrent.getHoldStrikeWeapon());
            m_lstAliensWeapons.Add(m_pAlienCharCurrent.getTailWeapon());

            m_pCurrentAlienWeaponCurrent = m_lstAliensWeapons[0];
            m_strCurrentWeaponName = m_pCurrentAlienWeaponCurrent.getName();
        }

       private void setCurrentAlien()
        {
            m_pAlienCharCurrent = m_lstAliens[0] as IAlienCharacter;
            m_strCurrentAlien = m_pAlienCharCurrent.getName();
        }
        private void setCurrentMarine()
        {
            m_pMarineCharCurrent = m_lstMarines[0] as IMarineCharacter;
            m_strCurrentMarineName = m_pMarineCharCurrent.getName();
        }
        private void prepareListsOfAliensAndMarines()
        {
            m_lstAliens.Add(m_pCharacterGenerator.createAlienWorker());

            m_astrAliensClasses = new string[m_lstAliens.Count];

            foreach(IAlienCharacter alien in m_lstAliens)
            {

            }

            m_lstMarines.Add(m_pCharacterGenerator.createMarineLeader());

            m_astrMarineClasses = new string[m_lstMarines.Count];
        }
    }
}
