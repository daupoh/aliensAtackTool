using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Controllers
{
    interface IFormController
    {
        string[] getAliensClasses();
        string[] getAliensWeapons();
        string[] getMarinesClasses();

        byte getCountOfVectors();
        double getDamageOfVector();
        double getAutoDamageMod();
        double getTimeOnAnimation();

        byte getHeadHitsCount();
        byte getBodyHitsCount();
        byte getArmsHitsCount();
        byte getLegsHitsCount();
        byte getMissHitsCount();

        double getHeadHitBoxMod();
        double getBodyHitBoxMod();
        double getArmsHitBoxMod();
        double getLegsHitBoxMod();
       

        byte getMarineHealthPoints();
        byte getMarineArmorPoints();
        string getMarineStatus();

        void setArmorAndHealth(byte healpthPoints, byte armorPoints, string typeOfArmor);

        void setWeaponHits(byte headCount, byte bodyCount, byte armsCount, byte legsCount);
        void setHitBoxes(double headMod, double bodyMod, double armsMod, double legsMod);

        void selectAlien(byte index);
        void selectMarine(byte index);
        void selectAlienWeapon(byte index);

        void setWeaponParameters(byte countOfVector,double dmgOnVector,double autoDmgMod, uint time);
        
        void atackByBite();
        void atackByHoldBite();
        void atackByStrike();
        void atackByHoldStrike();
        void atackByTailStrike();

        void restoreHP(byte points);
        void restoreAP(byte points);

        void startFight();
        void endFight();
    }
}
