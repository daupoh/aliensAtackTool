using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Controllers
{
    interface IMainController
    {
        string[] getAliensClasses();
        string[] getAliensWeapons();
        string[] getMarinesClasses();
        byte getCountOfVectors();
        double getDamageOfVector();
        double getAutoDamageMod();
        double getTimeOnAnimation();
        byte getMarineHealthPoints();
        byte getMarineArmorPoints();
        string getMarineStatus();

        void setHits(byte headCount, byte bodyCount, byte armsCount, byte legsCount);
        void setHitBoxes(double headMod, double bodyMod, double armsMod, double legsMod);
        void selectAlien(byte index);
        void selectMarine(byte index);
        void selectAlienWeapon(byte index);
        void setCurrentWeapon();
        
        void atackByBite();
        void atackByHoldBite();
        void atackByStrike();
        void atackByHoldStrike();
        void atackByTailStrike();

        void restoreHP();
        void restoreAP();

        void startFight();
        void endFight();
    }
}
