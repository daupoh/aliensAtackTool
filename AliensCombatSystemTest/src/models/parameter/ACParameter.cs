using AliensCombatSystemTest.src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.parameter
{
     abstract class ACParameter :ACEntity, IParameter
    {
        protected double m_fValue;
       
       
        protected ACParameter(string name):base(name)
        {
           
        }
        public abstract double Value { get; }
        public virtual string View { get { return Value.ToString(); } }
    }



}

