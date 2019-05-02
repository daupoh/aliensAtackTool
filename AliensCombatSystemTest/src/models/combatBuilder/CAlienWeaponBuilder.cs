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
    class CAlienWeaponBuilder : ACCombatBuilder
    {

        public CAlienWeaponBuilder() : base("AlienWeaponBuilder")
        {
            string[] classCodes = { "WP_PA", "WP_HPA", "WP_TA", "WP_BA", "WP_HBA", "WP_AA" ,
           "SP_PA", "SP_HPA", "SP_TA", "SP_BA", "SP_HBA", "SP_AA" },
           //"HP_PA", "HP_HPA", "HP_TA", "HP_BA", "HP_HBA", "HP_AA",
           //"PP_PA", "PP_HPA", "PP_TA", "PP_BA", "PP_HBA", "PP_AA"},
           weaponsNames =
           { "Удары Лапами (Рабочий)", "Серия Ударов (Рабочий)", "Удар Хвостом (Рабочий)", "Укус (Рабочий)", "Мощный укус (Рабочий)", "Оглушающий Удар (Рабочий)",
            "Удары Лапами (Солдат)", "Ранящий удар (Солдат)", "Удар Хвостом (Солдат)", "Укус (Солдат)", "Мощный укус (Солдат)", "Оглушающий Удар (Солдат)"};
            /*     "Удары Когтями (Охотник)", "Ранящий удар (Охотник)", "Подсечка Хвостом (Охотник)", "Укус (Охотник)", "Мощный укус (Охотник)", "Растерзание (Охотник)",
                 "Удары Когтями (Преторианец)", "Мощный удар (Преторианец)", "Выпад Хвостом (Преторианец)", "Укус (Преторианец)", "Мощный укус (Преторианец)", "Таран (Преторианец)",};
                 */
            m_asTypesCodes = classCodes;
            m_asCombatsNames = weaponsNames;

            AddCombat();
        }      
       
        protected override void AddParametersPool(string classCode)
        {
            AddParameterPool_Atack(classCode);
            AddParameterPool_Damage(classCode);
            AddParameterPool_ArmorResist(classCode);
            AddParameterPool_HumansResists(classCode);
            AddParameterPool_MakeEffects(classCode);
            AddParameterPool_NockdownHealthMod(classCode);
            AddParameterPool_PeriodDmg(classCode);
            AddParameterPool_StrikesCooldowns(classCode,1);
            AddParameterPool_TimeOfStrikes(classCode,1);
        }
     

        //_________________________
        private void AddParameterPool_Atack(string classCode)
        {
            IParameter pHitVectorsCount = new CIntNumbParameter(SCXmlHelper.DoubleFromXml("hitVectorsCount", "AWP", classCode), 
                                                                    SCXmlHelper.RowFromXml("hitVectorsCount", "AWP", "P")),
                        pStrikesCount= new CIntNumbParameter(SCXmlHelper.DoubleFromXml("strikesCount", "AWP", classCode),
                                                                SCXmlHelper.RowFromXml("strikesCount", "AWP", "P")),
                        pTimePrepareAtack = new CIntNumbParameter(SCXmlHelper.DoubleFromXml("preparationAtackTime", "AWP", classCode),
                                                                 SCXmlHelper.RowFromXml("preparationAtackTime", "AWP","P"));
            IParametersPool pAtackPool = new CParametersPool(SCXmlHelper.RowFromXml("atack", "AWP", "PP"));

            pAtackPool.AddParameter(pHitVectorsCount);
            pAtackPool.AddParameter(pStrikesCount);
            pAtackPool.AddParameter(pTimePrepareAtack);

            m_pCurrentCombatEntity.AddParameterPool(pAtackPool);
        }
        private void AddParameterPool_TimeOfStrikes(string classCode, int length)
        {  
            IParameter parameter = new CIntNumbParameter(SCXmlHelper.DoubleFromXml("timeToStrike", "AWP", classCode),
                   SCXmlHelper.RowFromXml("timeToStrike", "AWP", "P")); ;
            IParametersPool parameterPool = new CParametersPool(SCXmlHelper.RowFromXml("timeOfStrikes", "AWP", "PP"));
            parameterPool.AddParameter(parameter);
            m_pCurrentCombatEntity.AddParameterPool(parameterPool);
        }
        private void AddParameterPool_StrikesCooldowns(string classCode, int length)
        {           
            IParameter parameter = new CIntNumbParameter(SCXmlHelper.DoubleFromXml("timeBetweenStrikes", "AWP", classCode),
                    SCXmlHelper.RowFromXml("timeBetweenStrikes", "AWP", "P")); ;
            IParametersPool parameterPool = new CParametersPool(SCXmlHelper.RowFromXml("strikesCooldowns", "AWP", "PP"));
            parameterPool.AddParameter(parameter);               
            
            m_pCurrentCombatEntity.AddParameterPool(parameterPool);
        }
        private void AddParameterPool_Damage(string classCode)
        {
            IParameter pDmgOnVector = new CIntNumbParameter(SCXmlHelper.DoubleFromXml("damageOnVector", "AWP", classCode),
                                    SCXmlHelper.RowFromXml("damageOnVector", "AWP", "P")),
                pAutoDmgMod = new CModParameter(SCXmlHelper.DoubleFromXml("autoDamageMod", "AWP", classCode), 
                                SCXmlHelper.RowFromXml("autoDamageMod", "AWP", "P")),
                pDefZonesDmgMod = new CModParameter(SCXmlHelper.DoubleFromXml("defenceZonesDamageMod", "AWP", classCode),
                            SCXmlHelper.RowFromXml("defenceZonesDamageMod", "AWP", "P"));
            IParametersPool pDamagePool = new CParametersPool(SCXmlHelper.RowFromXml("damage", "AWP", "PP"));

            pDamagePool.AddParameter(pDmgOnVector);
            pDamagePool.AddParameter(pAutoDmgMod);
            pDamagePool.AddParameter(pDefZonesDmgMod);

            m_pCurrentCombatEntity.AddParameterPool(pDamagePool);
        }
        private void AddParameterPool_PeriodDmg(string classCode)
        {
            IParameter pPeriodDmg = new CIntNumbParameter(SCXmlHelper.DoubleFromXml("periodDamage", "AWP", classCode),
                                    SCXmlHelper.RowFromXml("periodDamage", "AWP", "P")),
                pPeriodDmgTime = new CIntNumbParameter(SCXmlHelper.DoubleFromXml("periodDamageTime", "AWP", classCode),
                                    SCXmlHelper.RowFromXml("periodDamageTime", "AWP","P"));
            IParametersPool pPeriodDamagePool = new CParametersPool(SCXmlHelper.RowFromXml("periodDmg", "AWP", "PP"));

            pPeriodDamagePool.AddParameter(pPeriodDmg);
            pPeriodDamagePool.AddParameter(pPeriodDmgTime);

            m_pCurrentCombatEntity.AddParameterPool(pPeriodDamagePool);
        }
        private void AddParameterPool_ArmorResist(string classCode)
        {
            IParameter pArmorResist = new CModParameter(SCXmlHelper.DoubleFromXml("armorDamageMod", "AWP", classCode),
                                                SCXmlHelper.RowFromXml("armorDamageMod", "AWP", "P"));
            IParametersPool pArmorResistPool = new CParametersPool(SCXmlHelper.RowFromXml("armorResist", "AWP", "PP"));


            pArmorResistPool.AddParameter(pArmorResist);
            
            m_pCurrentCombatEntity.AddParameterPool(pArmorResistPool);
        }
        private void AddParameterPool_HumansResists(string classCode)
        {
            IParameter pHumanResist = new CModParameter(SCXmlHelper.DoubleFromXml("humanResist", "AWP", classCode),
                                                SCXmlHelper.RowFromXml("humanResist", "AWP", "P")),
                        pSynthResist = new CModParameter(SCXmlHelper.DoubleFromXml("synthResist", "AWP", classCode),
                                                SCXmlHelper.RowFromXml("synthResist", "AWP", "P")); ;
            IParametersPool pHumansResists = new CParametersPool(SCXmlHelper.RowFromXml("humansResists", "AWP", "PP"));

            pHumansResists.AddParameter(pHumanResist);
            pHumansResists.AddParameter(pSynthResist);

            m_pCurrentCombatEntity.AddParameterPool(pHumansResists);
        }
        private void AddParameterPool_NockdownHealthMod(string classCode)
        {
            IParameter pKnockdownMod = new CModParameter(SCXmlHelper.DoubleFromXml("nockdownHealthMod", "AWP", classCode),
                                             SCXmlHelper.RowFromXml("nockdownHealthMod", "AWP", "P"));
            IParametersPool pKnockdownBorderMod = new CParametersPool(SCXmlHelper.RowFromXml("nockdownHealthMod", "AWP", "PP"));

            pKnockdownBorderMod.AddParameter(pKnockdownMod);

            m_pCurrentCombatEntity.AddParameterPool(pKnockdownBorderMod);
        }
        private void AddParameterPool_MakeEffects(string classCode)
        {
            IParameter pBleed = new CYesNoParameter(SCXmlHelper.DoubleFromXml("makeBleedEffect", "AWP", classCode),
                                              SCXmlHelper.RowFromXml("makeBleedEffect", "AWP", "P")),
                      pStun = new CYesNoParameter(SCXmlHelper.DoubleFromXml("makeStunEffect", "AWP", classCode),
                                              SCXmlHelper.RowFromXml("makeStunEffect", "AWP", "P")); ;
            IParametersPool pMakeEffects = new CParametersPool(SCXmlHelper.RowFromXml("makeEffects", "AWP", "PP"));

            pMakeEffects.AddParameter(pBleed);
            pMakeEffects.AddParameter(pStun);

            m_pCurrentCombatEntity.AddParameterPool(pMakeEffects);
        }
        
    }
}
