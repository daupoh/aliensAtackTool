using AliensCombatSystemTest.src2.models.characters;
using AliensCombatSystemTest.src2.models.weapons.damageTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src2.models.weapons.effects.DmgEffect
{
    class CDamageWithBonusDmgEffect:ACTypicalDmgEffect
    {
        public CDamageWithBonusDmgEffect(string name, IDamageType mainDmgType, IList<IDamageType> bonusDmgTypes)
        {
            checkName(name);
            checkMainDmgType(mainDmgType);
            checkBonusDmgTypes(bonusDmgTypes);

            m_strName = name;
            m_pMainDmgType = mainDmgType;
            initializeBonusDmgTypes(bonusDmgTypes);
        }

        public override bool canEffect()
        {
            return true;
        }
        public override void doEffect(ICharacter enemyChar)
        {

        }
    }
}
