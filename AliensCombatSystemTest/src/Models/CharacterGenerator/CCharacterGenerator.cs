using AliensCombatSystemTest.src.Models.Armor;
using AliensCombatSystemTest.src.Models.Characters;
using AliensCombatSystemTest.src.Models.Characters.Aliens;
using AliensCombatSystemTest.src.Models.Characters.Marines;
using AliensCombatSystemTest.src.Models.DamageTypes;
using AliensCombatSystemTest.src.Models.Weapons;
using AliensCombatSystemTest.src.Models.Weapons.Builders.AliensBuilders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models.CharacterGenerator
{
    class CCharacterGenerator:ICharacterGenerator
    {
        IAlienCharacter m_pAlienChar;
       
        IAlienWeaponBuilder m_pAlienWeaponBuilder;

        IDamageType m_pBiteDmgType, m_pHoldBiteDmgType, m_pStrikeDmgType,
            m_pHoldStrikeDmgType, m_pTailDmgType;
        IAlienWeapon m_pBiteWeap, m_pHoldBiteWeap, m_pStrikeWeap,
            m_pHoldStrikeWeap, m_pTailWeap;
        SCDamageTypeDescriptor.aliensMetaClasses alienMetaClass;

        IMarineCharacter m_pMarineChar;
        IArmor m_pArmorMarine;
        public CCharacterGenerator()
        {
            m_pAlienWeaponBuilder = new CAlienWeaponBuilder();
        }

        public ICharacter createAlienWorker()
        {
            alienMetaClass = SCDamageTypeDescriptor.aliensMetaClasses.Slave;
            m_pAlienChar = new CAlienCharacter("Alien Worker");

            m_pBiteWeap = m_pAlienWeaponBuilder
                .withAutoDmgMod(0)
                .withDamageOnHit(30)
                .withMaxHits(1)
                .withName(SCDamageTypeDescriptor.bite)
                .withStrikeTime(250)
                .withMetaClass(alienMetaClass)
                .withWeaponKey(SCDamageTypeDescriptor.bite)
                .build();
            m_pAlienWeaponBuilder.restore();
            m_pHoldBiteWeap = m_pAlienWeaponBuilder
                .withAutoDmgMod(0)
                .withDamageOnHit(70)
                .withMaxHits(1)
                .withName(SCDamageTypeDescriptor.holdBite)
                .withStrikeTime(750)
                .withMetaClass(alienMetaClass)
                .withWeaponKey(SCDamageTypeDescriptor.holdBite)
                .build();
            m_pAlienWeaponBuilder.restore();
            m_pStrikeWeap = m_pAlienWeaponBuilder
                .withAutoDmgMod(0.5)
                .withDamageOnHit(12)
                .withMaxHits(5)
                .withName(SCDamageTypeDescriptor.strike)
                .withStrikeTime(60)
                .withMetaClass(alienMetaClass)
                .withWeaponKey(SCDamageTypeDescriptor.strike)
                .build();
            m_pAlienWeaponBuilder.restore();
            m_pHoldStrikeWeap = m_pAlienWeaponBuilder
                .withAutoDmgMod(0)
                .withDamageOnHit(20)
                .withMaxHits(5)
                .withName(SCDamageTypeDescriptor.holdStrike)
                .withStrikeTime(1000)
                .withMetaClass(alienMetaClass)
                .withWeaponKey(SCDamageTypeDescriptor.holdStrike)
                .build();
            m_pAlienWeaponBuilder.restore();
            m_pTailWeap = m_pAlienWeaponBuilder
                .withAutoDmgMod(0.8)
                .withDamageOnHit(5)
                .withMaxHits(10)
                .withName(SCDamageTypeDescriptor.tail)
                .withStrikeTime(50)
                .withMetaClass(alienMetaClass)
                .withWeaponKey(SCDamageTypeDescriptor.tail)
                .build();
            m_pAlienWeaponBuilder.restore();
            //назначение
            m_pAlienChar.setBiteWeapon(m_pBiteWeap);
            m_pAlienChar.setHoldBiteWeapon(m_pHoldBiteWeap);
            m_pAlienChar.setHoldStrikeWeapon(m_pStrikeWeap);
            m_pAlienChar.setStrikeWeapon (m_pHoldStrikeWeap);
            m_pAlienChar.setTailWeapon(m_pTailWeap);

            return m_pAlienChar;
        }
        public ICharacter createMarineLeader()
        {
            m_pMarineChar = new CMarineCharacter("Marine Leader",100);
            m_pArmorMarine = new CArmor();
            m_pArmorMarine.setArmorMaxPoints(100);
            m_pArmorMarine.setArmorType(SCDamageTypeDescriptor.marinesArmorTypes.Composit);
            m_pMarineChar.setArmor(m_pArmorMarine);
            
            return m_pMarineChar;

        }

    }
}
