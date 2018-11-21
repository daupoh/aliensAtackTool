using AliensCombatSystemTest.src2.models.characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src2.models.weapons.effects
{
    interface IStickedEffect:IEffect
    {
        bool tryStickTo(ICharacter enemyChar, long timeActivate);
        bool canUpdate();
        void update();
    }
}
