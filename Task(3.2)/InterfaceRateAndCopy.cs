using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._2_
{
    internal interface InterfaceRateAndCopy
    {
        double Rating { get; }
        object DeepCopy(); 

    }
}

