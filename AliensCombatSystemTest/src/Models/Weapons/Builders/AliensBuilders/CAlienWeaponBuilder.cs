using AliensCombatSystemTest.src.Models.DamageTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models.Weapons.Builders.AliensBuilders
{
    public class CAlienWeaponBuilder:IAlienWeaponBuilder
    {
        protected IAlienWeapon m_pAlienWeapon;

        protected IDamageTypeBuilder m_pDamageTypeBuilder;
        protected IDamageType m_pDmgType;
        protected byte m_uiMaxHits;
        protected uint m_uiMiliseconds;
        protected double m_dbDmg, m_dbAutoDmgMod;
        protected string m_strName;
        protected SCDamageTypeDescriptor.aliensMetaClasses m_eAlienMetaClass;
        protected string m_strAlienWeapType;
        protected string m_strAlienDamageType;

        public CAlienWeaponBuilder()
        {
            m_pDmgType = null;
            m_uiMaxHits = 0;
            m_uiMiliseconds = 0;
            m_eAlienMetaClass = 0;
            m_strAlienWeapType = "";
            m_strAlienDamageType = "";

            m_pDamageTypeBuilder = new CDamageTypeBuilder();
        }
        public  IAlienWeapon build()
        {
            m_pDmgType = m_pDamageTypeBuilder
             .withAutoDamageMod(m_dbAutoDmgMod)
             .withDamage(m_dbDmg)
             .withMaxHits(m_uiMaxHits)
             .withName(damageTypeName())
             .build();
            m_pDamageTypeBuilder.restore();

            m_pAlienWeapon = new CAlienWeapon(m_strName, m_pDmgType);
            return m_pAlienWeapon;
        }
        public IAlienWeaponBuilder withMetaClass(SCDamageTypeDescriptor.aliensMetaClasses metaClass)
        {
            m_eAlienMetaClass = metaClass;
            return this;
        }
        public IAlienWeaponBuilder withWeaponKey(string key)
        {
            m_strAlienWeapType = key;
            return this;
        }

        public IAlienWeaponBuilder withMaxHits(byte maxHits)
        {
            m_uiMaxHits = maxHits;
            return this;
        }
        public IAlienWeaponBuilder withStrikeTime(uint miliseconds)
        {
            m_uiMiliseconds = miliseconds;
            return this;
        }
        public IAlienWeaponBuilder withDamageOnHit(double dmg)
        {
            m_dbDmg = dmg;
            return this;
        }
        public IAlienWeaponBuilder withAutoDmgMod(double autoDmgMod)
        {
            m_dbAutoDmgMod = autoDmgMod;
            return this;
        }
        public IAlienWeaponBuilder withName(string name)
        {
            m_strName = name;
            return this;
        }

        public void restore()
        {
            m_pAlienWeapon = null;
        }

        
        protected string damageTypeName()
        {
            string dmgTypeName = "";
            bool canFindValue = true;
           switch (m_eAlienMetaClass)
            {
                case SCDamageTypeDescriptor.aliensMetaClasses.Slave:
                    canFindValue = SCDamageTypeDescriptor
                        .aliensSlavesWeaponsDmgTypes.TryGetValue(m_strAlienWeapType, out dmgTypeName);
                    SCChecker.checkBooleanVarIsTrue(canFindValue);

                    break;
                case SCDamageTypeDescriptor.aliensMetaClasses.Hunter:
                    canFindValue = SCDamageTypeDescriptor
                        .aliensHuntersWeaponsDmgTypes.TryGetValue(m_strAlienWeapType, out dmgTypeName);
                    SCChecker.checkBooleanVarIsTrue(canFindValue);

                    break;
                case SCDamageTypeDescriptor.aliensMetaClasses.Soldier:
                    canFindValue = SCDamageTypeDescriptor
                        .aliensSoldiersWeaponsDmgTypes.TryGetValue(m_strAlienWeapType, out dmgTypeName);
                    SCChecker.checkBooleanVarIsTrue(canFindValue);

                    break;
                case SCDamageTypeDescriptor.aliensMetaClasses.Royal:
                    canFindValue = SCDamageTypeDescriptor
                        .aliensRoyalWeaponsDmgTypes.TryGetValue(m_strAlienWeapType, out dmgTypeName);
                    SCChecker.checkBooleanVarIsTrue(canFindValue);

                    break;
            }
            return dmgTypeName;
        }
    }
}
