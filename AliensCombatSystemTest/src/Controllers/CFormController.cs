using AliensCombatSystemTest.src.Models;
using AliensCombatSystemTest.src.Models.Armor;
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
    class CFormController : IFormController
    {
        string[] m_astrAliensClasses, m_astrMarineClasses, m_astrAliensWeapons;
        string m_strCurrentAlien, m_strCurrentWeaponName, m_strCurrentMarineName;

        IAlienCharacter m_pAlienCharCurrent; IList<ICharacter> m_lstAliens, m_lstMarines;
        IMarineCharacter m_pMarineCharCurrent;
        IAlienWeapon m_pCurrentAlienWeaponCurrent; IList<IAlienWeapon> m_lstAliensWeapons;

        IHitBox m_pHeadHitBox,
                m_pBodyHitBox,
                m_pArmsHitBox,
                m_pLegsHitBox,
                m_pMissHitBox;

        ICharacterGenerator m_pCharacterGenerator;

        public CFormController()
        {
            m_pCharacterGenerator = new CCharacterGenerator();
            m_lstAliens = new List<ICharacter>();
            m_lstAliensWeapons = new List<IAlienWeapon>();
            m_lstMarines = new List<ICharacter>();


            prepareListsOfAliensAndMarines();

            setCurrentAlien(0);
            setCurrentMarine(0);

            setWeaponsOfCurrentAlienAndCurrentWeapon();

        }

        public string[] getAliensClasses()
        {
            return m_astrAliensClasses;
        }
        public string[] getAliensWeapons()
        {
            return m_astrAliensWeapons;
        }
        public string[] getMarinesClasses()
        {
            return m_astrMarineClasses;
        }
        public byte getCountOfVectors()
        {
            byte count = m_pCurrentAlienWeaponCurrent.getMaxHits();

            return count;
        }
        public double getDamageOfVector()
        {
            double dmg = m_pCurrentAlienWeaponCurrent.getDamageType().getDamage();

            return dmg;
        }
        public double getAutoDamageMod()
        {
            double autoDmgmod = m_pCurrentAlienWeaponCurrent.getDamageType().getAutoDmg();

            return autoDmgmod;
        }
        public double getTimeOnAnimation()
        {
            double time = m_pCurrentAlienWeaponCurrent.getStrikeTime();

            return time;
        }
        public byte getMarineHealthPoints()
        {
            byte healthPoints = m_pMarineCharCurrent.getHealthPoint();

            return healthPoints;

        }
        public byte getMarineArmorPoints()
        {
            byte armorPoints = m_pMarineCharCurrent.getArmorPoints();

            return armorPoints;
        }
        public string getMarineStatus()
        {
            string s = m_pMarineCharCurrent.getStatus();

            return s;
        }

        public void setArmorAndHealth(byte healpthPoints, byte armorPoints, string typeOfArmor)
        {
            switch (typeOfArmor)
            {
                case "titan":
                    m_pMarineCharCurrent.setArmor(new CArmor(SCDescriptors.marinesArmorTypes.Titan));
                    break;
                case "composit":
                    m_pMarineCharCurrent.setArmor(new CArmor(SCDescriptors.marinesArmorTypes.Composit));
                    break;
                case "suit":
                    m_pMarineCharCurrent.setArmor(new CArmor(SCDescriptors.marinesArmorTypes.Suit));
                    break;
                default: throw new FormatException();
            }
            m_pMarineCharCurrent.setHealthPoint(healpthPoints);
            m_pMarineCharCurrent.setArmorPoints(armorPoints);

        }
        private byte calculateCountOfHits(string hitsName)
        {
            byte count = 0;
            foreach (IHit hit in m_pCurrentAlienWeaponCurrent.strikeHits())
            {
                if (hit.getName() == hitsName)
                {
                    count++;
                }
            }
            return count;
        }
        public byte getHeadHitsCount()
        {
            byte count = 0;
            if (m_pCurrentAlienWeaponCurrent.strikeHits() != null)
            {
                count = calculateCountOfHits("head");
            }
            return count;
        }
        public byte getBodyHitsCount()
        {
            byte count = 0;
            if (m_pCurrentAlienWeaponCurrent.strikeHits() != null)
            {
                count = calculateCountOfHits("body");
            }
            return count;
        }
        public byte getArmsHitsCount()
        {
            byte count = 0;
            if (m_pCurrentAlienWeaponCurrent.strikeHits() != null)
            {
                count = calculateCountOfHits("arms");
            }
            return count;
        }
        public byte getLegsHitsCount()
        {
            byte count = 0;
            if (m_pCurrentAlienWeaponCurrent.strikeHits() != null)
            {
                count = calculateCountOfHits("legs");
            }
            return count;
        }
        public byte getMissHitsCount()
        {
            byte count = 0;
            if (m_pCurrentAlienWeaponCurrent.strikeHits() != null)
            {
                count = calculateCountOfHits("miss");
            }
            return count;
        }
        private void updateHits()
        {
            byte headCount, bodyCount, armsCount, legsCount, missCount;
            headCount = getHeadHitsCount(); bodyCount = getBodyHitsCount(); armsCount = getArmsHitsCount();
            legsCount = getLegsHitsCount(); missCount = getMissHitsCount();
            setWeaponHits(headCount, bodyCount, armsCount, legsCount, missCount);
        }
        private void updateWeaponHits()
        {
            IAlienWeapon sveCurWeap = m_pCurrentAlienWeaponCurrent;
            m_pCurrentAlienWeaponCurrent = m_pAlienCharCurrent.getBiteWeapon();
            updateHits();
            m_pCurrentAlienWeaponCurrent = m_pAlienCharCurrent.getHoldBiteWeapon();
            updateHits();
            m_pCurrentAlienWeaponCurrent = m_pAlienCharCurrent.getStrikeWeapon();
            updateHits();
            m_pCurrentAlienWeaponCurrent = m_pAlienCharCurrent.getHoldStrikeWeapon();
            updateHits();
            m_pCurrentAlienWeaponCurrent = m_pAlienCharCurrent.getTailWeapon();
            updateHits();

            m_pCurrentAlienWeaponCurrent = sveCurWeap;
        }
        public void setWeaponHits(byte headCount, byte bodyCount, byte armsCount, byte legsCount, byte missCount)
        {
            int sumOfHits = headCount + bodyCount + armsCount + legsCount + missCount,
                sumWithOutMiss = sumOfHits-missCount;
            if (sumOfHits != m_pCurrentAlienWeaponCurrent.getMaxHits() || sumWithOutMiss==0)
            {
                throw new FormatException("Количество попаданий не должно превышать количество векторов или быть равно 0");
            }

            m_pCurrentAlienWeaponCurrent.clearHits();
            IHit hit = new CHit();
            hit.setHitDmgType(m_pCurrentAlienWeaponCurrent.getDamageType());

            byte index = headCount;
            hit.hitOn(m_pHeadHitBox);
            while (index>0)
            {
                m_pCurrentAlienWeaponCurrent.addHit(hit);
                index--;
            }
            index = bodyCount;
            hit = new CHit();
            hit.hitOn(m_pBodyHitBox);
            hit.setHitDmgType(m_pCurrentAlienWeaponCurrent.getDamageType());
            while (index > 0)
            {
                m_pCurrentAlienWeaponCurrent.addHit(hit);
                index--;
            }
            index = armsCount;
            hit = new CHit();
            hit.hitOn(m_pArmsHitBox);
            hit.setHitDmgType(m_pCurrentAlienWeaponCurrent.getDamageType());
            while (index > 0)
            {
                m_pCurrentAlienWeaponCurrent.addHit(hit);
                index--;
            }
            index = legsCount;
            hit = new CHit();
            hit.hitOn(m_pLegsHitBox);
            hit.setHitDmgType(m_pCurrentAlienWeaponCurrent.getDamageType());
            while (index > 0)
            {
                m_pCurrentAlienWeaponCurrent.addHit(hit);
                index--;
            }
            index = missCount;
            hit = new CHit();
            hit.hitOn(m_pMissHitBox);
            hit.setHitDmgType(m_pCurrentAlienWeaponCurrent.getDamageType());
            while (index > 0)
            {
                m_pCurrentAlienWeaponCurrent.addHit(hit);
                index--;
            }

        }

        public void setHitBoxes(double headMod, double bodyMod, double armsMod, double legsMod, double missMod)
        {
            m_pHeadHitBox.setModDmg(headMod);
            m_pBodyHitBox.setModDmg(bodyMod);
            m_pArmsHitBox.setModDmg(armsMod);
            m_pLegsHitBox.setModDmg(legsMod);
            m_pMissHitBox.setModDmg(missMod);

            updateWeaponHits();
        }


        public void selectAlien(byte index) {
            setCurrentAlien(index);
            setWeaponsOfCurrentAlienAndCurrentWeapon();
        }
        public void selectMarine(byte index) {
            setCurrentMarine(index);
        }
        public void selectAlienWeapon(byte index)
        {
            
            m_pCurrentAlienWeaponCurrent = m_lstAliensWeapons[index] as CAlienWeapon;
            m_strCurrentWeaponName = m_astrAliensWeapons[index];
        }
        public void setWeaponParameters(byte countOfVector, double dmgOnVector, double autoDmgMod, uint time)
        {
            m_pCurrentAlienWeaponCurrent.setMaxHits(countOfVector);
            m_pCurrentAlienWeaponCurrent.setDamage(dmgOnVector);
            m_pCurrentAlienWeaponCurrent.setAutoDmgMod(autoDmgMod);
            m_pCurrentAlienWeaponCurrent.setStrikeTime(time);
           
        }

        public void atackByBite()
        {
            m_pAlienCharCurrent.atackByBite(m_pMarineCharCurrent);
        }
        public void atackByHoldBite()
        {
            m_pAlienCharCurrent.atackByHoldBite(m_pMarineCharCurrent);
        }
        public void atackByStrike()
        {
            m_pAlienCharCurrent.atackByStrike(m_pMarineCharCurrent);
        }
        public void atackByHoldStrike()
        {
            m_pAlienCharCurrent.atackByHoldStrike(m_pMarineCharCurrent);
        }
        public void atackByTailStrike()
        {
            m_pAlienCharCurrent.atackByTail(m_pMarineCharCurrent);
        }

        public void restoreHP(byte points) {
            
            m_pMarineCharCurrent.restoreHealthPoints(points);
        }
        public void restoreAP(byte points)
        {
            m_pMarineCharCurrent.restoreArmorhPoints(points);
        }

        public void startFight() {
            
        }
        public void endFight() {
            m_pMarineCharCurrent.setStatus("Стоит");

        }
        public double getHeadHitBoxMod()
        {
            return m_pHeadHitBox.getDmgMod();
        }
        public double getBodyHitBoxMod()
        {
            return m_pBodyHitBox.getDmgMod();
        }
        public double getArmsHitBoxMod()
        {
            return m_pArmsHitBox.getDmgMod();
        }
        public double getLegsHitBoxMod()
        {
            return m_pLegsHitBox.getDmgMod();
        }


        private void setWeaponsOfCurrentAlienAndCurrentWeapon()
        {
            m_lstAliensWeapons.Clear();

            m_lstAliensWeapons.Add(m_pAlienCharCurrent.getBiteWeapon());
            m_lstAliensWeapons.Add(m_pAlienCharCurrent.getHoldBiteWeapon());
            m_lstAliensWeapons.Add(m_pAlienCharCurrent.getHoldStrikeWeapon());
            m_lstAliensWeapons.Add(m_pAlienCharCurrent.getStrikeWeapon());            
            m_lstAliensWeapons.Add(m_pAlienCharCurrent.getTailWeapon());

            m_astrAliensWeapons = new string[m_lstAliensWeapons.Count];

            byte index = 0;
            foreach(CAlienWeapon weapon in m_lstAliensWeapons)
            {
                m_astrAliensWeapons[index] = weapon.getName();
                index++;
            }

            m_pCurrentAlienWeaponCurrent = m_lstAliensWeapons[0];
            m_strCurrentWeaponName = m_pCurrentAlienWeaponCurrent.getName();
        }

       private void setCurrentAlien(byte index)
        {
            m_pAlienCharCurrent = m_lstAliens[index] as IAlienCharacter;
            m_strCurrentAlien = m_pAlienCharCurrent.getName();
        }
        private void setCurrentMarine(byte index)
        {
            m_pMarineCharCurrent = m_lstMarines[index] as IMarineCharacter;
            m_strCurrentMarineName = m_pMarineCharCurrent.getName();
        }
        private void prepareListsOfAliensAndMarines()
        {
            m_lstAliens.Add(m_pCharacterGenerator.createAlienWorker());

            m_astrAliensClasses = new string[m_lstAliens.Count];
            
            byte index = 0;
            foreach(IAlienCharacter alien in m_lstAliens)
            {
                m_astrAliensClasses[index] = alien.getName();
                index++;
            }

            m_lstMarines.Add(m_pCharacterGenerator.createMarineLeader());

            m_astrMarineClasses = new string[m_lstMarines.Count];

            index = 0;
            foreach(CMarineCharacter marine in m_lstMarines)
            {
                m_astrMarineClasses[index] = marine.getName();
                index++;
            }

            m_pHeadHitBox = new CHitBox("head", 1.7);
            m_pBodyHitBox = new CHitBox("body", 1.0);
            m_pArmsHitBox = new CHitBox("arms", 0.65);
            m_pLegsHitBox = new CHitBox("legs", 0.8);
            m_pMissHitBox = new CHitBox("miss", 0.5);
        }
    }
}
