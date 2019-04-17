using AliensCombatSystemTest.src.models.parameter;
using AliensCombatSystemTest.src.models.parametersPool;
using System;
using System.Collections.Generic;

namespace AliensCombatSystemTest.src.models.weapon
{
    class CCombatEntity : ACEntity,ICombatEntity
    {      
      
        private Dictionary<string, IParametersPool> m_dctParametersPoolsDictionary;

        public CCombatEntity(string name):base(name)
        {
         
            m_dctParametersPoolsDictionary = new Dictionary<string, IParametersPool>();


        }
       
        public void AddParameterPool(IParametersPool parametersPool)
        {
            m_dctParametersPoolsDictionary.Add(parametersPool.Name, parametersPool);
        }
        public double getParameterValueByName(string namePool, string nameParameter)
        {
            double result = 0;
            IParametersPool tempParametersPool;
            bool tryGetValues = m_dctParametersPoolsDictionary.TryGetValue(namePool, out tempParametersPool);
            if (tryGetValues)
            {
                result = tempParametersPool.getValueByParameter(nameParameter);
            }
            else
            {
                throw new FormatException();
            }

            return result;
        }
        public string getParameterPoolViewByName(string name)
        {
            string result = "";
            IParametersPool tempParametersPool;
            bool tryGetValues = m_dctParametersPoolsDictionary.TryGetValue(name, out tempParametersPool);
            if (tryGetValues)
            {
                result = tempParametersPool.TableView;
            }
            else
            {
                throw new FormatException();
            }
            return result;
        }


    }
}
