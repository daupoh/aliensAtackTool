using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src2.models.weapons.effects
{
    interface IEffect:IEntity
    {
        bool EffectActive { get; }

        double[] getEffect(double timePassed); //double[3] = {{healthDmg}, {armorDmg}, {positionChange}}
        void effectStartAct();
    }
}
