﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideBySideBar2DChart
{
    public class DataPoint
    {
        public double XValue { get; set; }
        public double YValue { get; set; }

        public DataPoint(double x, double y) { XValue = x; YValue = y; }
    }
}
