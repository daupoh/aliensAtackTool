using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models.Hits
{
    public interface IHitBox
    {
        double getModedDmg(double dmgOfVector);
        double getDmgMod();
        string getName();
        void setModDmg(double mode);
    }
}
