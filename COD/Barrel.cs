using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD
{
    public class Barrel
    {
        public string Name { get; set; }
        public double VTunnig { get; set; }
        public double HTunnig { get; set; }

        public Barrel(string name, double vTunnig, double hTunnig)
        {
            Name = name;
            VTunnig = vTunnig;
            HTunnig = hTunnig;
        }

        
    }
}
