using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COD
{
    public class Muzzle
    {
        public string Name { get; set; }
        public int VTunnig { get; set; }
        public int HTunnig { get; set; }

        public Muzzle(string name, int vTunnig, int hTunnig)
        {
            Name = name;
            VTunnig = vTunnig;
            HTunnig = hTunnig;
        }
    }
}
