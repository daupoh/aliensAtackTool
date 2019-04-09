using AliensCombatSystemTest.src.models.parameter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.parametersPool
{
    abstract class ACParametersPool : ACEntity,IParametersPool
    {
        IList<IParameter> m_lsParameters;
        protected ACParametersPool(string name):base(name)
        {
            m_lsParameters = new List<IParameter>();
        }
        protected void AddParameter(IParameter parameter)
        {
            m_lsParameters.Add(parameter);
        }
        public string TableView
        {
            get
            {
                string result = "";
                int lastParameters = m_lsParameters.Count;
                if (m_lsParameters==null || lastParameters == 0)
                {
                    throw new FormatException();
                }
                if (lastParameters == 1)
                {
                    IParameter parameter = m_lsParameters[0];
                    result += parameter.Value.ToString();
                }
                else
                {
                    result += '(';

                    foreach (IParameter parameter in m_lsParameters)
                    {
                        result += parameter.Value.ToString();
                        lastParameters--;
                        if (lastParameters != 0)
                        {
                            result += ',';
                        }
                    }
                    result += ')';
                }
                return result;
            }
        }
    }
}
