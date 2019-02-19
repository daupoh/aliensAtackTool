using AliensCombatSystemTest.src2.helpers;
using AliensCombatSystemTest.src2.models.characters;
using AliensCombatSystemTest.src2.models.weapons.damageTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src2.models.weapons.effects.DmgEffect
{
    abstract class ACTypicalDmgEffect:IInstantaneousEffect
    {
        protected string m_strName;
        protected IDamageType m_pMainDmgType;
        protected IList<IDamageType> m_lstBonusDmgTypes;
        bool m_blHasBonus = true;

        public string Name
        {
            get
            {
                return m_strName;
            }
        }
        public bool HasBonus { get { return m_blHasBonus; } }
        protected void initializeBonusDmgTypes(IList<IDamageType> bonusDmgTypes)
        {
            m_lstBonusDmgTypes = new List<IDamageType>();
            foreach(IDamageType dmgType in bonusDmgTypes)
            {
                m_lstBonusDmgTypes.Add(dmgType);
            }
        }
        protected void checkName(string name)
        {
            string errorMsgText = "";
            SCDataFormatChecker.checkStrIsNotEmpty(name, errorMsgText);
        }
        protected void checkMainDmgType(IDamageType dmgType)
        {
            string errorMsgText = "";
            checkDmgType(dmgType, errorMsgText);
        }
        protected void checkDmgType(IDamageType dmgType, string errorMsgText)
        {            
            SCDataFormatChecker.checkEntityIsNotNull(dmgType, errorMsgText);
        }
        protected void checkBonusDmgTypes(IList<IDamageType> dmgTypes)
        {
            string errorMsgText = "";
            if (dmgTypes == null)
            {
                m_blHasBonus = false;
            }
            else
            {
                foreach (IDamageType dmgType in dmgTypes)
                {
                    checkDmgType(dmgType, errorMsgText);
                }
            }
        }
        public abstract bool canEffect();
        public abstract void doEffect(ICharacter enemyChar);
    }
}
