using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonInventory
{
    internal class Model
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }

        public List<Model> Rice { get; set; }
        public List<Model> Pulses { get; set; }
        public List<Model> Wheat { get; set; }
    }
}
