﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliensCombatSystemTest.src.models.parameter
{
    interface IParameter:IEntity
    {
       
        double Value { get; }
     
    }
}