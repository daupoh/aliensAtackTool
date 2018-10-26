using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models.Hits
{
    class CHitBoxMiss:IHitBox
    {
        public double getModDmg(double dmgOfVector)
        {
            return dmgOfVector;
        }
    }
}
