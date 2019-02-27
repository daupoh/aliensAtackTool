using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.Models
{
    static class SCChecker
    {
        
        public static void checkSettings(string name, string[] strSettings, int[] integerSettings, double[] floatSettings)
        {
            CheckStringIsNotEmpty(name);
            if (strSettings != null)
            {
                foreach (string s in strSettings)
                {
                    CheckStringIsNotEmpty(s);
                }
            }
            if (integerSettings!= null)
            {
                foreach (int i in integerSettings)
                {
                    CheckNumberMoreOrEqualThenZero(i);
                }
            }
            if (floatSettings!= null)
            {
                foreach (double f in floatSettings)
                {
                    CheckNumberMoreOrEqualThenZero(f);
                }
            }
            
        }
        public static void CheckNumberMoreThenZero(double number)
        {
            if (number <= 0)
            {
                throw new FormatException();
            }

        }
        public static void CheckNumberMoreOrEqualThenZero(double number)
        {
            if (number < 0)
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
        public static double[] GetDefaultModHitBoxes()
        {
            double[] mods = new double[4];
            mods[0]=1.7;
            mods[1] = 1.0;
            mods[2] = 0.6;
            mods[3] = 0.8;
            return mods;
        }
    }
}
