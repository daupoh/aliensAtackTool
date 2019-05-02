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

        double m_dbTimeKnockdown = 0;
        public CAlienAtackCalculator() : base()
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
            AddParameterPool_ttk();
        }
        private void AddParameterPool_ttk()
        {
            double ttkMax = getTTK("max"),
                ttkMin = getTTK("min"),
                ttkAvg=(ttkMax+ttkMin)/2;
            IParameter pTtkMax = new CIntNumbParameter(ttkMax, SCXmlHelper.RowFromXml("ttkMax", "ARP", "P")),
                        pTtkMin = new CIntNumbParameter(ttkMin, SCXmlHelper.RowFromXml("ttkMin", "ARP", "P")),
                        pTtkAvg = new CIntNumbParameter(ttkAvg, SCXmlHelper.RowFromXml("ttkAvg", "ARP", "P"));
            IParametersPool pTTk = new CParametersPool(SCXmlHelper.RowFromXml("ttk","ARP","PP"));

            pTTk.AddParameter(pTtkMax);
            pTTk.AddParameter(pTtkMin);
            pTTk.AddParameter(pTtkAvg);
            m_pCurrentCombatEntity.AddParameterPool(pTTk);
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
            double countOfVectors = m_pWeapon.getParameterValueByName(
                    atackRow, SCXmlHelper.RowFromXml("hitVectorsCount", "AWP", "P")),
                countOfStrikes = m_pWeapon.getParameterValueByName(
                    atackRow, SCXmlHelper.RowFromXml("strikesCount", "AWP", "P")),
                preparation = m_pWeapon.getParameterValueByName(
                    atackRow, SCXmlHelper.RowFromXml("preparationAtackTime", "AWP", "P")),
                timeToStrike = m_pWeapon.getParameterValueByName(
                    SCXmlHelper.RowFromXml("timeOfStrikes", "AWP", "PP"), SCXmlHelper.RowFromXml("timeToStrike", "AWP", "P")),
                cooldownStrike = m_pWeapon.getParameterValueByName(
                    SCXmlHelper.RowFromXml("strikesCooldowns", "AWP", "PP"), SCXmlHelper.RowFromXml("timeBetweenStrikes", "AWP", "P")),
                dmgOnVector = m_pWeapon.getParameterValueByName(
                    damageRow, SCXmlHelper.RowFromXml("damageOnVector", "AWP", "P")),
                autoDamageMod = m_pWeapon.getParameterValueByName(
                    damageRow, SCXmlHelper.RowFromXml("autoDamageMod", "AWP", "P")),
                defenceZonesDamageMod = m_pWeapon.getParameterValueByName(
                    damageRow, SCXmlHelper.RowFromXml("defenceZonesDamageMod", "AWP", "P")),
                periodDamage = m_pWeapon.getParameterValueByName(
                    periodDmgRow, SCXmlHelper.RowFromXml("periodDamage", "AWP", "P")),
                periodDamageTime = m_pWeapon.getParameterValueByName(
                    periodDmgRow, SCXmlHelper.RowFromXml("periodDamageTime", "AWP", "P")),
                armorDamageMod = m_pWeapon.getParameterValueByName(
                    SCXmlHelper.RowFromXml("armorResist", "AWP", "PP"), SCXmlHelper.RowFromXml("armorDamageMod", "AWP", "P")),
                humanResist = m_pWeapon.getParameterValueByName(
                    humansResistsRow, SCXmlHelper.RowFromXml("humanResist", "AWP", "P")),
                synthResist = m_pWeapon.getParameterValueByName(
                    humansResistsRow, SCXmlHelper.RowFromXml("synthResist", "AWP", "P")),
                nockdownHealthMod = m_pWeapon.getParameterValueByName(
                    SCXmlHelper.RowFromXml("nockdownHealthMod", "AWP", "PP"), SCXmlHelper.RowFromXml("nockdownHealthMod", "AWP", "P")),
                makeBleedEffect = m_pWeapon.getParameterValueByName(
                    makeEffectsRow, SCXmlHelper.RowFromXml("makeBleedEffect", "AWP", "P")),
                makeStunEffect = m_pWeapon.getParameterValueByName(
                    makeEffectsRow, SCXmlHelper.RowFromXml("makeStunEffect", "AWP", "P")),

                baseNockdownHealthPoints = m_pTarget.getParameterValueByName(
                    baseNockdownHealthPointsRow, SCXmlHelper.RowFromXml("baseNockdownHealthPoints", "HTP", "P")),
                weightOfWeaponMod = m_pTarget.getParameterValueByName(
                    weightOfWeaponModRow, SCXmlHelper.RowFromXml("weightOfWeaponMod", "HTP", "P")),
                underEffectTrap = m_pTarget.getParameterValueByName(
                    underEffectRow, SCXmlHelper.RowFromXml("underEffectTrap", "HTP", "P")),
                underEffectBarricade = m_pTarget.getParameterValueByName(
                    underEffectRow, SCXmlHelper.RowFromXml("underEffectBarricade", "HTP", "P")),
                underEffectDefZone = m_pTarget.getParameterValueByName(
                    underEffectRow, SCXmlHelper.RowFromXml("underEffectDefZone", "HTP", "P")),
                isHuman = m_pTarget.getParameterValueByName(
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
                    double dmgThrough = 0;
                    if (isHuman==1)
                    {
                        dmgThrough = 1 - humanResist;
                    }
                    else
                    {
                        dmgThrough = 1 - synthResist;
                    }
                    double dmgAfterResist = curDmgOnVector *countOfVectors* dmgThrough
                            + autoDmgOnVector*countOfAutoVectors*dmgThrough,
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

                    if (nockdownHealthMod > 0)
                    {
                        double baseKnockdownMod = 1;
                        if (underEffectBarricade == 1)
                        {
                            baseKnockdownMod /= 2;
                        }
                        if (underEffectTrap == 1)
                        {
                            baseKnockdownMod *= 2;
                        }
                        double knockdownHealthBorder = (baseKnockdownMod * baseNockdownHealthPoints + weightOfWeaponMod)
                            * nockdownHealthMod;
                        if (100 * knockdownHealthBorder >= hp)
                        {
                            m_dbTimeKnockdown = timer;
                        }
                    }
                    timer += cooldownStrike;
                }
             
            }
            result = timer;
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
