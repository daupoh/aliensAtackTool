using AliensCombatSystemTest.src.models.parameter;
using AliensCombatSystemTest.src.models.parametersPool;
using System;
using System.Collections.Generic;

namespace AliensCombatSystemTest.src.models.weapon
{
   class CCombatEntity : ACEntity,ICombatEntity
    {       
        private Dictionary<string, IParameter> m_dctParametersDictionary;
        private Dictionary<string, IParametersPool> m_dctParametersPoolsDictionary;

        protected CCombatEntity(string name):base(name)
        {
            m_dctParametersDictionary = new Dictionary<string, IParameter>();
            m_dctParametersPoolsDictionary = new Dictionary<string, IParametersPool>();


        }
        protected void AddParameter(IParameter parameter)
        {
            m_dctParametersDictionary.Add(parameter.Name, parameter);
        }
        protected void AddParameterPool(IParametersPool parametersPool)
        {
            m_dctParametersPoolsDictionary.Add(parametersPool.Name, parametersPool);
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
