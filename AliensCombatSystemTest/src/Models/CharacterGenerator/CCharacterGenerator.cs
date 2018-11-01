using AliensCombatSystemTest.src.Models.Armor;
using AliensCombatSystemTest.src.Models.Characters;
using AliensCombatSystemTest.src.Models.Characters.Aliens;
using AliensCombatSystemTest.src.Models.Characters.Marines;
using AliensCombatSystemTest.src.Models.DamageTypes;
using AliensCombatSystemTest.src.Models.Hits;
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

        
        IAlienWeapon m_pBiteWeap, m_pHoldBiteWeap, m_pStrikeWeap,
            m_pHoldStrikeWeap, m_pTailWeap;
        SCDescriptors.aliensMetaClasses alienMetaClass;

        IMarineCharacter m_pMarineChar;
        IArmor m_pArmorMarine;
        public CCharacterGenerator()
        {
            m_pAlienWeaponBuilder = new CAlienWeaponBuilder();
            
        }

        public ICharacter createAlienWorker()
        {
            alienMetaClass = SCDescriptors.aliensMetaClasses.Slave;
            m_pAlienChar = new CAlienCharacter("Alien Worker");

            m_pBiteWeap = m_pAlienWeaponBuilder
                .withAutoDmgMod(0.1)
                .withDamageOnHit(19)
                .withMaxHits(1)
                .withName(SCDescriptors.bite)
                .withStrikeTime(500)
                .withMetaClass(alienMetaClass)
                .withWeaponKey(SCDescriptors.bite)
                .build();
            IHit hit = new CHit();
            hit.setHitDmgType(m_pBiteWeap.getDamageType());
            hit.hitOn(new CHitBox("head", 0.5));
            for (int i=0;i<m_pBiteWeap.getMaxHits();i++)
            {
                m_pBiteWeap.addHit(hit);

            }
            m_pAlienWeaponBuilder.restore();
            m_pHoldBiteWeap = m_pAlienWeaponBuilder
                .withAutoDmgMod(0.1)
                .withDamageOnHit(59)
                .withMaxHits(1)
                .withName(SCDescriptors.holdBite)
                .withStrikeTime(1350)
                .withMetaClass(alienMetaClass)
                .withWeaponKey(SCDescriptors.holdBite)
                .build();
            hit = new CHit();
            hit.setHitDmgType(m_pHoldBiteWeap.getDamageType());
            hit.hitOn(new CHitBox("head", 0.5));
            for (int i = 0; i < m_pHoldBiteWeap.getMaxHits(); i++)
            {
                m_pHoldBiteWeap.addHit(hit);

            }
            m_pAlienWeaponBuilder.restore();
            m_pStrikeWeap = m_pAlienWeaponBuilder
                .withAutoDmgMod(0.5)
                .withDamageOnHit(8)
                .withMaxHits(5)
                .withName(SCDescriptors.strike)
                .withStrikeTime(500)
                .withMetaClass(alienMetaClass)
                .withWeaponKey(SCDescriptors.strike)
                .build();
            hit = new CHit();
            hit.setHitDmgType(m_pStrikeWeap.getDamageType());
            hit.hitOn(new CHitBox("head", 0.5));
            for (int i = 0; i < m_pStrikeWeap.getMaxHits(); i++)
            {
                m_pStrikeWeap.addHit(hit);

            }
            m_pAlienWeaponBuilder.restore();
            m_pHoldStrikeWeap = m_pAlienWeaponBuilder
                .withAutoDmgMod(0.1)
                .withDamageOnHit(10)
                .withMaxHits(5)
                .withName(SCDescriptors.holdStrike)
                .withStrikeTime(500)
                .withMetaClass(alienMetaClass)
                .withWeaponKey(SCDescriptors.holdStrike)
                .build();
            hit = new CHit();
            hit.setHitDmgType(m_pHoldStrikeWeap.getDamageType());
            hit.hitOn(new CHitBox("head", 0.5));
            for (int i = 0; i < m_pHoldStrikeWeap.getMaxHits(); i++)
            {
                m_pHoldStrikeWeap.addHit(hit);

            }
            m_pAlienWeaponBuilder.restore();
            m_pTailWeap = m_pAlienWeaponBuilder
                .withAutoDmgMod(0.8)
                .withDamageOnHit(6)
                .withMaxHits(10)
                .withName(SCDescriptors.tail)
                .withStrikeTime(1000)
                .withMetaClass(alienMetaClass)
                .withWeaponKey(SCDescriptors.tail)
                .build();
            hit = new CHit();
            hit.setHitDmgType(m_pTailWeap.getDamageType());
            hit.hitOn(new CHitBox("head", 0.5));
            for (int i = 0; i < m_pTailWeap.getMaxHits(); i++)
            {
                m_pTailWeap.addHit(hit);

            }
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
            m_pArmorMarine.setArmorType(SCDescriptors.marinesArmorTypes.Composit);
            m_pMarineChar.setArmor(m_pArmorMarine);
            
            return m_pMarineChar;

        }

    }
}
