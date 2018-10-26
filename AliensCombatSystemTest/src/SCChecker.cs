using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models
{
    static class SCChecker
    {
        public static void checkNumberMoreThenZero(double number)
        {
            if (number<=0)
            {
                throw new FormatException();
            }

        }
        public static void checkBooleanVarIsTrue(bool expression)
        {
            if (!expression)
            {
                throw new FormatException();
            }
        }
        public static void checkFirstNumberMoreOrEquivalThenSecond(double firstNumb, double secondNumb)
        {
            if (secondNumb>firstNumb)
            {
                throw new FormatException();
            }
        }
        public static void checkObjectIsNotNull(Object sender)
        {
            if (sender==null)
            {
                throw new FormatException();
            }

        }
        public static void checkStringIsNotEmpty(string str)
        {
            if (str==null || str=="")
            {
                throw new FormatException();
            }
        }
    }
}
