using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models.DamageTypes
{
    public interface IDamageTypeBuilder
    {
        IDamageTypeBuilder withName(string name);
        IDamageTypeBuilder withDamage(double dmg);
        IDamageTypeBuilder withAutoDamageMod(double autoDmgMod);
        IDamageTypeBuilder withMaxHits(byte maxHits);

        void restore();
        IDamageType build();
    }
}
