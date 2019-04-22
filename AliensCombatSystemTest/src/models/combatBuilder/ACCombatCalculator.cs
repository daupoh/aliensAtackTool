using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AliensCombatSystemTest.src.models.weapon;

namespace AliensCombatSystemTest.src.models.combatBuilder
{
    abstract class ACCombatCalculator : ACCombatBuilder, ICombatCalculator
    {
        protected ICombatEntity m_pTarget, m_pWeapon;
        protected string m_sAccuracity = "";
        protected ACCombatCalculator(string accuracity) : base("CombatCalculator")
        {
            m_sAccuracity = accuracity;
            m_asTypesCodes = new string[1];
            m_asCombatsNames = new string[1];
        }   
        public ICombatEntity SetTarget
        {
            set
            {
                if (value != null && value is ICombatEntity)
                {
                    m_pTarget = value;
                }
                else
                {
                    throw new FormatException();
                }

            }
        }

        public ICombatEntity SetWeapon
        {
            set
            {
                if (value != null && value is ICombatEntity)
                {
                    m_pWeapon = value;
                }
                else
                {
                    throw new FormatException();
                }
            }
        }

        public abstract void Calculate();
    }
}
