﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD
{
    public class Muzzle
    {
        public string Name { get; set; }
        public double VTunnig { get; set; }
        public double HTunnig { get; set; }

        public Muzzle(string name, double vTunnig, double hTunnig)
        {
            Name = name;
            VTunnig = vTunnig;
            HTunnig = hTunnig;
        }
    }
}
