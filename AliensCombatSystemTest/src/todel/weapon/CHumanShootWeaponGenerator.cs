using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.weapon
{
    class CHumanShootWeaponGenerator:ACWeaponGenerator
    {
        public CHumanShootWeapon generatePistolSC()
        {
            return getWeapon("Пистолет VP70 (одиночные)",24,21,240,1,0,0,
                                        0.2,0.2,0.4,0.6,0.3,0.35, 0.05, 0.0);
        }
        public CHumanShootWeapon generatePistolSCAuto()
        {
            return getWeapon("Пистолет VP70 (очередями)", 24, 21, 500, 1, 0, 0,
                                        0.2, 0.2, 0.4, 0.6, 0.3, 0.35,0.05, 0.0);
        }
        public CHumanShootWeapon generatePistolHC()
        {
            return getWeapon("Пистолет M43", 20, 24, 240, 1, 0, 0,
                                        0.2, 0.2, 0.4, 0.6, 0.3, 0.35,0.05,0.0);
        }

        public CHumanShootWeapon getWeapon(string name, int ammo, int bulletDmg, int rateOfFire, int dmgByAcid, int dmgByTime,int durationDmg,
                                            double bpModDmg, double extraDmgByBP, double soldResist, double guardResist, double runResist, 
                                            double workResist,double acidDmgMod, double overheat)
        {
            CHumanShootWeapon weapon = null;
            m_aIntegerSettings = new int[6];
            m_aFloatSettings = new double[8];

            m_sWeaponName         = name; //name
            m_aIntegerSettings[0] = ammo;     //ammo
            m_aIntegerSettings[1] = bulletDmg;     //bulletDmg
            m_aIntegerSettings[2] = rateOfFire;    //rate of fire
            m_aIntegerSettings[3] = dmgByAcid;     //dmg by acid
            m_aIntegerSettings[4] = dmgByTime;      //dmg by time
            m_aIntegerSettings[5] = durationDmg;      //duration dmg by time

            m_aFloatSettings[0]   = bpModDmg;    //bp mod dmg
            m_aFloatSettings[1]   = extraDmgByBP;    //extra dmg by bp
            m_aFloatSettings[2]   = soldResist;    //soldier resist
            m_aFloatSettings[3]   = guardResist;    //guard resist
            m_aFloatSettings[4]   = runResist;    //runner resist
            m_aFloatSettings[5]   = workResist;   //workers resist
            m_aFloatSettings[6] = acidDmgMod;   //acidDmgMod 
            m_aFloatSettings[7] = overheat;   // overheat
            weapon = new CHumanShootWeapon(m_sWeaponName, m_aIntegerSettings, m_aFloatSettings);
            return weapon;
        }
    }
}
