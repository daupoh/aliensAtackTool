using AliensCombatSystemTest.src.models.parameter;
using AliensCombatSystemTest.src.models.weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.combatBuilder
{
    class CAlienWeaponBuilder : ACCombatBuilder
    {

        public CAlienWeaponBuilder(string name) : base(name)
        {
            m_pCurrentCombatEntity = new CCombatEntity("Удары Лапами (Рабочий)");
        }
        private void AddWorker()
        {
            AddWorkerPrimeAtack();
            AddWorkerHoldPrimeAtack();
            AddWorkerAltAtack();
            AddWorkerBiteAtack();
            AddWorkerHoldBiteAtack();
            AddWorkerTailAtack();
        }
        //_________________________

        private void AddWorkerPrimeAtack() { }
        private void AddWorkerHoldPrimeAtack() { }
        private void AddWorkerAltAtack() { }
        private void AddWorkerBiteAtack() { }
        private void AddWorkerHoldBiteAtack() { }
        private void AddWorkerTailAtack() { }

        //_________________________
        private void AddParameterPool_Atack(int nHitVectors,int nStrikes,double timePreparation)
        {
            IParameter pHitVectorsCount = new CIntNumbParameter(nHitVectors, "Количество векторов в атаке"),
                        pStrikesCount= new CIntNumbParameter(nStrikes, "Количество ударов в атаке");
        }
    }
}
