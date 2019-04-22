using AliensCombatSystemTest.src.models.parameter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.parametersPool
{
    class CParametersPool : ACEntity,IParametersPool
    {
        IList<IParameter> m_lsParameters;
        public CParametersPool(string name):base(name)
        {
            m_lsParameters = new List<IParameter>();
        }
        public double getValueByParameter(string name)
        {
            double result = -1;
            foreach(IParameter parameter in m_lsParameters)
            {
                if (parameter.Name==name)
                {
                    result = parameter.Value;
                }
            }
            if (result==-1)
            {
                throw new FormatException();
            }
            return result;
        }
        public void AddParameter(IParameter parameter)
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
                    result += parameter.View;
                }
                else
                {
                    result += '(';

                    foreach (IParameter parameter in m_lsParameters)
                    {
                        result += parameter.View;
                        lastParameters--;
                        if (lastParameters != 0)
                        {
                            result += ';';
                        }
                    }
                    result += ')';
                }
                return result;
            }
        }
    }
}
