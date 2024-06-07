﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products
{
    internal interface IAbstractProductB
    {
        string UsefulFunctionB();

        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }
}
