﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Calc : ICalc
    {
        public int Add(int a, int b) => a + b;
        public int Sub(int a, int b) => a - b;
    }
}
