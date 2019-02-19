using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models
{
    static class SCChecker
    {
        public static void CheckNumberMoreThenZero(double number)
        {
            if (number<=0)
            {
                throw new FormatException();
            }

        }
        public static void CheckBooleanVarIsTrue(bool expression)
        {
            if (!expression)
            {
                throw new FormatException();
            }
        }
        public static void CheckFirstNumberMoreOrEquivalThenSecond(double firstNumb, double secondNumb)
        {
            if (secondNumb>firstNumb)
            {
                throw new FormatException();
            }
        }
        public static void CheckObjectIsNotNull(Object sender,string message)
        {
            if (sender==null)
            {
                throw new FormatException(message);
            }

        }
        public static void CheckStringIsNotEmpty(string str)
        {
            if (str==null || str=="")
            {
                throw new FormatException();
            }
        }
    }
}
