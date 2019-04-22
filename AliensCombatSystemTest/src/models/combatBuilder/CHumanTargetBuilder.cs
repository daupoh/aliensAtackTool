using AliensCombatSystemTest.src.models.parameter;
using AliensCombatSystemTest.src.models.parametersPool;
using gravityPrototype.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.combatBuilder
{
    class CHumanTargetBuilder : ACCombatBuilder
    {
        public CHumanTargetBuilder() : base("HumanTargetBuilder")
        {
            string[] classCodes = { "HL_NE", "HL_TE", "HL_BE", "HL_ZE", "HL_AE" },
           //"SP_PA", "SP_HPA", "SP_TA", "SP_BA", "SP_HBA", "SP_AA" },
          //"HP_PA", "HP_HPA", "HP_TA", "HP_BA", "HP_HBA", "HP_AA",
          //"PP_PA", "PP_HPA", "PP_TA", "PP_BA", "PP_HBA", "PP_AA"},
          targetsNames =
          { "Человек с легким оружием (без эффектов)","Человек с легким оружием (ловушка)",
            "Человек с легким оружием (баррикада)","Человек с легким оружием (зона)",
            "Человек с легким оружием (все эффекты)"};
            
            m_asTypesCodes = classCodes;
            m_asCombatsNames = targetsNames;

            AddCombat();
        }

        protected override void AddAtack(string typeCode)
        {
            AddParameterPool_BaseKnockdown(typeCode);
            AddParameterPool_HitMods(typeCode);
            AddParameterPool_UnderEffects(typeCode);
            AddParameterPool_WeaponWeight(typeCode);
        }
        private void AddParameterPool_HitMods(string typeCode)
        {
            IParameter pHitModHead = new CModParameter(SCXmlHelper.DoubleFromXml("hitBoxesModHead", "HTP", typeCode),
                                                        SCXmlHelper.RowFromXml("hitBoxesModHead", "HTP", "P")),
                       pHitModBody = new CModParameter(SCXmlHelper.DoubleFromXml("hitBoxesModBody", "HTP", typeCode),
                                                        SCXmlHelper.RowFromXml("hitBoxesModBody", "HTP", "P")),
                       pHitModArms = new CModParameter(SCXmlHelper.DoubleFromXml("hitBoxesModArms", "HTP", typeCode),
                                                        SCXmlHelper.RowFromXml("hitBoxesModArms", "HTP", "P")),
                       pHitModLegs = new CModParameter(SCXmlHelper.DoubleFromXml("hitBoxesModLegs", "HTP", typeCode),
                                                        SCXmlHelper.RowFromXml("hitBoxesModLegs", "HTP", "P"));

            IParametersPool pHitMods = new CParametersPool(SCXmlHelper.RowFromXml("hitBoxesMods", "HTP", "PP"));

            pHitMods.AddParameter(pHitModHead);
            pHitMods.AddParameter(pHitModBody);           
            pHitMods.AddParameter(pHitModLegs);
            pHitMods.AddParameter(pHitModArms);

            m_pCurrentCombatEntity.AddParameterPool(pHitMods);

        }
        private void AddParameterPool_BaseKnockdown(string typeCode)
        {
            IParameter pBaseKnockdownMod = new CModParameter(SCXmlHelper.DoubleFromXml("baseNockdownHealthPoints", "HTP", typeCode),
                                                       SCXmlHelper.RowFromXml("baseNockdownHealthPoints", "HTP", "P"));
            IParametersPool pBaseKnockdown = new CParametersPool(SCXmlHelper.RowFromXml("baseNockdownHealthPoints", "HTP", "PP"));

            pBaseKnockdown.AddParameter(pBaseKnockdownMod);

            m_pCurrentCombatEntity.AddParameterPool(pBaseKnockdown);
        }
        private void AddParameterPool_WeaponWeight(string typeCode)
        {
            IParameter pWeaponWeightMod = new CModParameter(SCXmlHelper.DoubleFromXml("weightOfWeaponMod", "HTP", typeCode),
                                                       SCXmlHelper.RowFromXml("weightOfWeaponMod", "HTP", "P"));
            IParametersPool pWeaponWeight = new CParametersPool(SCXmlHelper.RowFromXml("weightOfWeaponMod", "HTP", "PP"));

            pWeaponWeight.AddParameter(pWeaponWeightMod);

            m_pCurrentCombatEntity.AddParameterPool(pWeaponWeight);
        }
        private void AddParameterPool_UnderEffects(string typeCode)
        {
            IParameter pUnderTrap = new CYesNoParameter(SCXmlHelper.DoubleFromXml("underEffectTrap", "HTP", typeCode),
                                                        SCXmlHelper.RowFromXml("underEffectTrap", "HTP", "P")),
                       pUnderBarricade = new CYesNoParameter(SCXmlHelper.DoubleFromXml("underEffectBarricade", "HTP", typeCode),
                                                        SCXmlHelper.RowFromXml("underEffectBarricade", "HTP", "P")),
                       pUnderZone = new CYesNoParameter(SCXmlHelper.DoubleFromXml("underEffectDefZone", "HTP", typeCode),
                                                        SCXmlHelper.RowFromXml("underEffectDefZone", "HTP", "P"));


            IParametersPool pUnderEffects = new CParametersPool(SCXmlHelper.RowFromXml("underEffect", "HTP", "PP"));

            pUnderEffects.AddParameter(pUnderTrap);
            pUnderEffects.AddParameter(pUnderBarricade);
            pUnderEffects.AddParameter(pUnderZone);

            m_pCurrentCombatEntity.AddParameterPool(pUnderEffects);
        }
    }
}
