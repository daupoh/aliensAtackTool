using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models.Hits
{
    public interface IHitBox
    {
        double getModDmg(double dmgOfVector);
    }
}
