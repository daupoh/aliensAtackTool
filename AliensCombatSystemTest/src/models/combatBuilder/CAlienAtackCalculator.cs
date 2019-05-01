using AliensCombatSystemTest.src.models.parameter;
using AliensCombatSystemTest.src.models.parametersPool;
using AliensCombatSystemTest.src.models.weapon;
using gravityPrototype.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.combatBuilder
{
    class CAlienAtackCalculator : ACCombatCalculator
    {
       

        public CAlienAtackCalculator(string accuracity) : base(accuracity)
        {
            
        }
        public override void Calculate()
        {
            if (m_pWeapon != null && m_pTarget != null)
            {
                m_asCombatsNames[0] = m_pWeapon.Name + " atack " + m_pTarget;
                AddCombat();
            }
            else
            {
                throw new FormatException();
            }
        }

        protected override void AddParametersPool(string typeCode)
        {
            
        }
        private void AddParameterPool_ttk()
        {
          

        }
        private double getTTK(string type)
        {
            double result=0;
            string atackRow = SCXmlHelper.RowFromXml("atack", "AWP", "PP"),
                damageRow = SCXmlHelper.RowFromXml("damage", "AWP", "PP"),
                periodDmgRow = SCXmlHelper.RowFromXml("periodDmg", "AWP", "PP"),
                humansResistsRow = SCXmlHelper.RowFromXml("humansResists", "AWP", "PP"),
                makeEffectsRow = SCXmlHelper.RowFromXml("makeEffects", "AWP", "PP"),

                baseNockdownHealthPointsRow = SCXmlHelper.RowFromXml("baseNockdownHealthPoints", "HTP", "PP"),
                weightOfWeaponModRow = SCXmlHelper.RowFromXml("weightOfWeaponMod", "HTP", "PP"),
                underEffectRow = SCXmlHelper.RowFromXml("underEffect", "HTP", "PP");
            double countOfVectors = m_pCurrentCombatEntity.getParameterValueByName(
                    atackRow, SCXmlHelper.RowFromXml("hitVectorsCount", "AWP", "P")),
                countOfStrikes = m_pCurrentCombatEntity.getParameterValueByName(
                    atackRow, SCXmlHelper.RowFromXml("strikesCount", "AWP", "P")),
                preparation = m_pCurrentCombatEntity.getParameterValueByName(
                    atackRow, SCXmlHelper.RowFromXml("preparationAtackTime", "AWP", "P")),
                timeToStrike = m_pCurrentCombatEntity.getParameterValueByName(
                    SCXmlHelper.RowFromXml("timeOfStrikes", "AWP", "PP"), SCXmlHelper.RowFromXml("timeToStrike", "AWP", "P")),
                cooldownStrike = m_pCurrentCombatEntity.getParameterValueByName(
                    SCXmlHelper.RowFromXml("strikesCooldowns", "AWP", "PP"), SCXmlHelper.RowFromXml("timeBetweenStrikes", "AWP", "P")),
                dmgOnVector = m_pCurrentCombatEntity.getParameterValueByName(
                    damageRow, SCXmlHelper.RowFromXml("damageOnVector", "AWP", "P")),
                autoDamageMod = m_pCurrentCombatEntity.getParameterValueByName(
                    damageRow, SCXmlHelper.RowFromXml("autoDamageMod", "AWP", "P")),
                defenceZonesDamageMod = m_pCurrentCombatEntity.getParameterValueByName(
                    damageRow, SCXmlHelper.RowFromXml("defenceZonesDamageMod", "AWP", "P")),
                periodDamage = m_pCurrentCombatEntity.getParameterValueByName(
                    periodDmgRow, SCXmlHelper.RowFromXml("periodDamage", "AWP", "P")),
                periodDamageTime = m_pCurrentCombatEntity.getParameterValueByName(
                    periodDmgRow, SCXmlHelper.RowFromXml("periodDamageTime", "AWP", "P")),
                armorDamageMod = m_pCurrentCombatEntity.getParameterValueByName(
                    SCXmlHelper.RowFromXml("armorResist", "AWP", "PP"), SCXmlHelper.RowFromXml("armorDamageMod", "AWP", "P")),
                humanResist = m_pCurrentCombatEntity.getParameterValueByName(
                    humansResistsRow, SCXmlHelper.RowFromXml("humanResist", "AWP", "P")),
                synthResist = m_pCurrentCombatEntity.getParameterValueByName(
                    humansResistsRow, SCXmlHelper.RowFromXml("synthResist", "AWP", "P")),
                nockdownHealthMod = m_pCurrentCombatEntity.getParameterValueByName(
                    SCXmlHelper.RowFromXml("nockdownHealthMod", "AWP", "PP"), SCXmlHelper.RowFromXml("nockdownHealthMod", "AWP", "P")),
                makeBleedEffect = m_pCurrentCombatEntity.getParameterValueByName(
                    makeEffectsRow, SCXmlHelper.RowFromXml("makeBleedEffect", "AWP", "P")),
                makeStunEffect = m_pCurrentCombatEntity.getParameterValueByName(
                    makeEffectsRow, SCXmlHelper.RowFromXml("makeStunEffect", "AWP", "P")),

                baseNockdownHealthPoints = m_pCurrentCombatEntity.getParameterValueByName(
                    baseNockdownHealthPointsRow, SCXmlHelper.RowFromXml("baseNockdownHealthPoints", "HTP", "P")),
                weightOfWeaponMod = m_pCurrentCombatEntity.getParameterValueByName(
                    weightOfWeaponModRow, SCXmlHelper.RowFromXml("weightOfWeaponMod", "HTP", "P")),
                underEffectTrap = m_pCurrentCombatEntity.getParameterValueByName(
                    underEffectRow, SCXmlHelper.RowFromXml("underEffectTrap", "HTP", "P")),
                underEffectBarricade = m_pCurrentCombatEntity.getParameterValueByName(
                    underEffectRow, SCXmlHelper.RowFromXml("underEffectBarricade", "HTP", "P")),
                underEffectDefZone = m_pCurrentCombatEntity.getParameterValueByName(
                    underEffectRow, SCXmlHelper.RowFromXml("underEffectDefZone", "HTP", "P")),
                isHuman = m_pCurrentCombatEntity.getParameterValueByName(
                    SCXmlHelper.RowFromXml("isHuman", "HTP", "PP"), SCXmlHelper.RowFromXml("isHuman", "HTP", "P"));

            double maxDmgonVector = dmgOnVector * 1.7,
                minDmgOnVector = dmgOnVector * 0.65,
                autoDmgOnVector = autoDamageMod * dmgOnVector,
                countOfAutoVectors = countOfVectors - 1,              
                curDmgOnVector = 0;
            switch(type)
            {
                case "max":
                    curDmgOnVector = maxDmgonVector;
                    countOfAutoVectors = 0;
                    break;              
                case "min":
                    curDmgOnVector = minDmgOnVector;
                    countOfVectors = 1;
                    break;
                default: throw new FormatException();
            }
            if (underEffectDefZone==1)
            {
                curDmgOnVector *= defenceZonesDamageMod;
            }

            double timer = 0,prodDmgTimerStart=0, hp=100, ap=100;

            while (hp>0)
            {
                timer += preparation;
                for (int i = 0; i < countOfStrikes; i++)
                {
                    timer += timeToStrike;
                    double resist = 0;
                    if (isHuman==1)
                    {
                        resist = humanResist;
                    }
                    else
                    {
                        resist = synthResist;
                    }
                    double dmgAfterResist = curDmgOnVector *countOfVectors* resist
                            + autoDmgOnVector*countOfAutoVectors*resist,
                        dmgOnArmor = dmgAfterResist*armorDamageMod,
                        dmgOnHealth = dmgAfterResist-dmgOnArmor,
                        periodDmgOnHealth=0,
                        dmgThroughArmor=0,
                        armorRest = ap-dmgOnArmor;
                    if (armorRest<0)
                    {
                        dmgThroughArmor = -1 * armorRest;
                        ap = 0;
                    }
                    else
                    {
                        ap = armorRest;
                    }
                    dmgOnHealth += dmgThroughArmor;

                    if (periodDamageTime > 0)
                    {
                        if (prodDmgTimerStart == 0)
                        {
                            prodDmgTimerStart = timer;
                        }
                        else
                        {
                            double progDmgSeconds = (timer - prodDmgTimerStart)/1000;
                            if (progDmgSeconds > periodDamageTime)
                            {
                                periodDmgOnHealth = periodDamage * periodDamageTime / 1000;
                                prodDmgTimerStart = 0;
                            }                            
                            else if (progDmgSeconds > 1)
                            {
                                periodDmgOnHealth = periodDamage * (Math.Truncate(progDmgSeconds));
                                prodDmgTimerStart += Math.Truncate(progDmgSeconds);
                            }
                        }
                        dmgOnHealth += periodDmgOnHealth;
                    }
                    hp -= dmgOnHealth;
                    timer += cooldownStrike;
                }
             
            }

            return result;
        } 


        private void AddParameterPool_targetEffects()
        {
            IParameter pTrapEffect = new CYesNoParameter(m_pTarget.getParameterValueByName("underEffect", "underEffectTrap"),
                SCXmlHelper.RowFromXml("trapEffect", "ARP", "P")),
                pBarricadeEffect = new CYesNoParameter(m_pTarget.getParameterValueByName("underEffect", "underEffectBarricade"),
                SCXmlHelper.RowFromXml("barricadeEffect", "ARP", "P")),
                pZoneEffect = new CYesNoParameter(m_pTarget.getParameterValueByName("underEffect", "underEffectDefZone"),
                SCXmlHelper.RowFromXml("ZoneEffect", "ARP", "P"));

            IParametersPool pTargetEffects = new CParametersPool(SCXmlHelper.RowFromXml("targetEffects", "ARP", "PP"));

            pTargetEffects.AddParameter(pTrapEffect);
            pTargetEffects.AddParameter(pZoneEffect);
            pTargetEffects.AddParameter(pBarricadeEffect);

            m_pCurrentCombatEntity.AddParameterPool(pTargetEffects);
        }
        private void AddParameterPool_hitsOnHitBoxes()
        {
            IParameter[] hits = new IParameter[5];

        }
        private void AddParameterPool_timeAndDmgOnAtack() { }
        private void AddParameterPool_nockDownResults() { }
        private void AddParameterPool_targetCocooned() { }
        private void AddParameterPool_damagesOnTarget() { }
        private void AddParameterPool_autoDamageOnTarget() { }
        private void AddParameterPool_damagesPeriodOnTarget() { }
    }
}
