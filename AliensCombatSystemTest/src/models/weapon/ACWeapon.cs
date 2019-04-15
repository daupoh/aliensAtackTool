using AliensCombatSystemTest.src.models.parameter;

using System;
using System.Collections.Generic;

namespace AliensCombatSystemTest.src.models.weapon
{
   abstract class ACWeapon :ACEntity,IWeapon
    {
       
        protected Dictionary<string, IParameter> m_dctParametersDictionary;

        protected ACWeapon(string name):base(name)
        {
            m_dctParametersDictionary = new Dictionary<string, IParameter>();
            
        }
        protected void AddParameter(IParameter parameter)
        {
            m_dctParametersDictionary.Add(parameter.Name, parameter);
        }
        
        public double getParameterValueByName(string name)
        {
            double result = 0;
            IParameter tempParameter;
            bool tryGetValues = m_dctParametersDictionary.TryGetValue(name, out tempParameter);
            if (tryGetValues)
            {
                result = tempParameter.Value;
            }
            else
            {
                throw new FormatException();
            }
            return result;
        }

      
    }
}
