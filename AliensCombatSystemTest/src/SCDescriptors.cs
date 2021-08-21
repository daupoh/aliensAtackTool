using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src
{
    public static class SCDescriptors
    {
        //aliens metaclasses
        public  enum aliensMetaClasses:byte {Slave, Hunter, Soldier,Royal};
        public enum marinesArmorTypes:byte { Titan,Composit,Suit};
        //aliens weapons
        public static string bite = "Bites",
              holdBite = "HoldBite",
              strike = "Strike",
              holdStrike = "HoldStrike",
              tail = "Tail",
        //aliens damage types
         biteDT = "Bite",
             holdBiteDT = "HoldBite",
             pawStrikeDT = "PawAtack",
             clawStrikeDT = "ClawAtack",
             pawComboDT = "PawCombo",
            clawBlowDT = "ClawBlow",
            clawBleedingDT = "ClawBleeding",
            tailStrikeDT = "TailStrike",
            tailNockdownDT = "TailNockDown",
            tailSpearDT = "TailSpear";
        static double 
            armorEffectiveZero = 0.0,
            armorEffectiveVeryLow = 0.15,
            armorEffectiveLow = 0.35,
            armorEffectiveMiddle = 0.5,
            armorEffectiveHigh = 0.65,
            armorEffectiveVeryHigh = 0.85;

        public static Dictionary<string, double> marinesHitBoxes = new Dictionary<string, double>
        {
            { "head", 1.7 },
            { "body", 1},
            { "arms", 0.65},
            { "legs", 0.8},
            { "miss", 0.5}            
        };
        public static Dictionary<string, string> aliensSlavesWeaponsDmgTypes = new Dictionary<string, string>
        {
            { bite,biteDT},
            { holdBite,holdBiteDT},
            { strike,pawStrikeDT},
            { holdStrike,pawComboDT},
            { tail,tailStrikeDT}
        };
        public static Dictionary<string, string> aliensSoldiersWeaponsDmgTypes = new Dictionary<string, string>
        {
            { bite,biteDT},
            { holdBite,holdBiteDT},
            { strike,clawStrikeDT},
            { holdStrike,clawBleedingDT},
            { tail,tailStrikeDT}
        };
        public static Dictionary<string, string> aliensHuntersWeaponsDmgTypes = new Dictionary<string, string>
        {
            { bite,biteDT},
            { holdBite,holdBiteDT},
            { strike,clawStrikeDT},
            { holdStrike,clawBleedingDT},
            { tail,tailNockdownDT}
        };
        public static Dictionary<string, string> aliensRoyalWeaponsDmgTypes = new Dictionary<string, string>
        {
            { bite,biteDT},
            { holdBite,holdBiteDT},
            { strike,pawStrikeDT},
            { holdStrike,clawBlowDT},
            { tail,tailSpearDT}
        };
        public static Dictionary<string, double> marinesArmorTitanDmgTypes = new Dictionary<string, double>
        {
            { biteDT, armorEffectiveZero},
            { holdBiteDT,armorEffectiveZero},
            { pawStrikeDT,armorEffectiveLow},
            { clawStrikeDT,armorEffectiveHigh},
            { pawComboDT,armorEffectiveLow},
            { clawBlowDT,armorEffectiveHigh},
            { clawBleedingDT,armorEffectiveHigh},
            { tailNockdownDT,armorEffectiveLow},
            { tailSpearDT,armorEffectiveMiddle},
            { tailStrikeDT,armorEffectiveHigh}
        };
        public static Dictionary<string, double> marinesArmorCompositDmgTypes = new Dictionary<string, double>
        {
              { biteDT, armorEffectiveZero},
            { holdBiteDT,armorEffectiveZero},
            { pawStrikeDT,armorEffectiveLow},
            { clawStrikeDT,armorEffectiveHigh},
            { pawComboDT,armorEffectiveLow},
            { clawBlowDT,armorEffectiveHigh},
            { clawBleedingDT,armorEffectiveHigh},
            { tailNockdownDT,armorEffectiveLow},
            { tailSpearDT,armorEffectiveMiddle},
            { tailStrikeDT,armorEffectiveHigh}
        };
        public static Dictionary<string, double> marinesArmorSuitDmgTypes = new Dictionary<string, double>
        {
              { biteDT, armorEffectiveZero},
            { holdBiteDT,armorEffectiveZero},
            { pawStrikeDT,armorEffectiveLow},
            { clawStrikeDT,armorEffectiveHigh},
            { pawComboDT,armorEffectiveLow},
            { clawBlowDT,armorEffectiveHigh},
            { clawBleedingDT,armorEffectiveHigh},
            { tailNockdownDT,armorEffectiveLow},
            { tailSpearDT,armorEffectiveMiddle},
            { tailStrikeDT,armorEffectiveHigh}
        };
    }
}
