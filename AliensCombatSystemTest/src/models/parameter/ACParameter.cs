using AliensCombatSystemTest.src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.parameter
{
    abstract class ACParameter : IParameter
    {
        protected double m_fValue;
        protected string m_sName;
        protected ACParameter(string name)
        {
            SCChecker.CheckStringIsNotEmpty(name);
            m_sName = name;
        }
        public string NameParameter { get { return m_sName; } }
        public abstract double Value { get; }
        public abstract string View { get; }



    }



}

