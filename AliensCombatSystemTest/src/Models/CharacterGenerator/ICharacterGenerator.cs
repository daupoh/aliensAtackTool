using AliensCombatSystemTest.src.Models.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models.CharacterGenerator
{
    interface ICharacterGenerator
    {
        ICharacter createAlienWorker();
        ICharacter createMarineLeader();
    }
}
