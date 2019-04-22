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
        private void AddParameterPool_hitsOnHitBoxes() { }
        private void AddParameterPool_timeAndDmgOnAtack() { }
        private void AddParameterPool_nockDownResults() { }
        private void AddParameterPool_targetCocooned() { }
        private void AddParameterPool_damagesOnTarget() { }
        private void AddParameterPool_autoDamageOnTarget() { }
        private void AddParameterPool_damagesPeriodOnTarget() { }
    }
}
