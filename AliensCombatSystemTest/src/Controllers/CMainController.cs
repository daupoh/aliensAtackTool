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
    class CMainController:IMainController
    {
        string[] m_astrAliensClasses, m_astrMarineClasses, m_astrAliensWeapons;
        string m_strCurrentAlien, m_strCurrentWeaponName;
        IAlienCharacter m_pAlienChar;
        IMarineCharacter m_pMarineChar;
        IAlienWeapon m_pCurrentAlienWeapon;
        IHitBox[] m_apHits;
        

        public CMainController(mainForm form)
        {
            
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
    }
}
