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
        int m_uiArmorCurrentPoints, m_uiArmorMaxPoints;
        double m_dbArmorDmgMod;
        
        SCDescriptors.marinesArmorTypes m_eArmorType;

        public CArmor()
        {
        }
        public CArmor(SCDescriptors.marinesArmorTypes armorType)
        {
            setArmorType(armorType);
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
        public void setArmorType(SCDescriptors.marinesArmorTypes typeOfArmor)
        {
            m_eArmorType = typeOfArmor;
        }
        public void setArmorMaxPoints(byte maxPoints) {
            SCChecker.checkNumberMoreThenZero(maxPoints);
            m_uiArmorMaxPoints = maxPoints;
            m_uiArmorCurrentPoints = m_uiArmorMaxPoints;
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
                case SCDescriptors.marinesArmorTypes.Composit:
                    canGetValue = SCDescriptors.marinesArmorCompositDmgTypes
                        .TryGetValue(dmgType.getName(),out dmgArmomMod);
                    SCChecker.checkBooleanVarIsTrue(canGetValue);
                    break;
                case SCDescriptors.marinesArmorTypes.Titan:
                    canGetValue = SCDescriptors.marinesArmorTitanDmgTypes
                        .TryGetValue(dmgType.getName(), out dmgArmomMod);
                    SCChecker.checkBooleanVarIsTrue(canGetValue);
                    break;
                case SCDescriptors.marinesArmorTypes.Suit:
                    canGetValue = SCDescriptors.marinesArmorSuitDmgTypes
                        .TryGetValue(dmgType.getName(), out dmgArmomMod);
                    SCChecker.checkBooleanVarIsTrue(canGetValue);
                    break;
            }

            return dmgArmomMod;
        }
    }
}
