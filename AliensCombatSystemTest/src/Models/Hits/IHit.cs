using AliensCombatSystemTest.src.Models.DamageTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models.Hits
{
    public interface IHit
    {
        double getDamage();
        void hitOn(IHitBox atackedHitBox);
        void setHitDmgType(IDamageType dmgType);
        string getName();
    }
}
