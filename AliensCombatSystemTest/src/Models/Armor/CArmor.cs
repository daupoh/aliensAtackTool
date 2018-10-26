using AliensCombatSystemTest.src.Models.DamageTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models.Armor
{
    class CArmor : IArmor
    {
        byte m_uiArmorCurrentPoints, m_uiArmorMaxPoints;
        double m_dbArmorDmgMod;
        
        SCDamageTypeDescriptor.marinesArmorTypes m_eArmorType;

        public CArmor()
        {
        }

        public double getsHealthDamage(double allDmg, IDamageType dmgType)
        {
            double dmg = 0, armorDmg = 0, healthDmg = 0;

            m_dbArmorDmgMod = getArmorDmgMod(dmgType);
            armorDmg = allDmg * m_dbArmorDmgMod;
            healthDmg = allDmg - armorDmg;
            dmg = healthDmg + armorGetsDamage((byte)armorDmg);
            return dmg;
        }
        public double getsArmorPoints()
        {
            double points = 0;
            points = m_uiArmorCurrentPoints;
            return points;

        }
        public void setArmorType(SCDamageTypeDescriptor.marinesArmorTypes typeOfArmor)
        {
            m_eArmorType = typeOfArmor;
        }
        public void setArmorMaxPoints(byte maxPoints) {
            SCChecker.checkNumberMoreThenZero(maxPoints);
            m_uiArmorMaxPoints = maxPoints;
        }
        public void restoreArmorPoints(byte restorePoints) {
            SCChecker.checkNumberMoreThenZero(restorePoints);
            if (m_uiArmorMaxPoints<(m_uiArmorCurrentPoints+restorePoints))
            {
                m_uiArmorCurrentPoints = m_uiArmorMaxPoints;
            }
            else
            {
                m_uiArmorCurrentPoints += restorePoints;
            }
        }

        private double armorGetsDamage(byte dmg)
        {
            double restDmg = 0;
            m_uiArmorCurrentPoints -= dmg;
            if (m_uiArmorCurrentPoints <=0)
            {
                restDmg = m_uiArmorCurrentPoints * -1;
                m_uiArmorCurrentPoints = 0;                
            }
            return restDmg;
        }
        private double getArmorDmgMod(IDamageType dmgType)
        {
            double dmgArmomMod = 0;
            bool canGetValue = true;
            switch (m_eArmorType)
            {
                case SCDamageTypeDescriptor.marinesArmorTypes.Composit:
                    canGetValue = SCDamageTypeDescriptor.marinesArmorCompositDmgTypes
                        .TryGetValue(dmgType.getName(),out dmgArmomMod);
                    SCChecker.checkBooleanVarIsTrue(canGetValue);
                    break;
                case SCDamageTypeDescriptor.marinesArmorTypes.Titan:
                    canGetValue = SCDamageTypeDescriptor.marinesArmorTitanDmgTypes
                        .TryGetValue(dmgType.getName(), out dmgArmomMod);
                    SCChecker.checkBooleanVarIsTrue(canGetValue);
                    break;
                case SCDamageTypeDescriptor.marinesArmorTypes.Suit:
                    canGetValue = SCDamageTypeDescriptor.marinesArmorSuitDmgTypes
                        .TryGetValue(dmgType.getName(), out dmgArmomMod);
                    SCChecker.checkBooleanVarIsTrue(canGetValue);
                    break;
            }

            return dmgArmomMod;
        }
    }
}
