using AliensCombatSystemTest.src2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src2.helpers
{
    public static class SCDataFormatChecker
    {
        public static void checkStrIsNotEmpty(string someString, string errorMsgText)
        {
            if (someString == "" || someString == null)
            {
                throw new FormatException(errorMsgText);
            }
        }
        public static void checkEntityIsNotNull(IEntity entity, string errorMsgText)
        {
            if (entity==null)
            {
                throw new FormatException(errorMsgText);
            }
        }
    }
}
