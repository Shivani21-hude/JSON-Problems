using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonInventory
{
    internal class Model2
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int price { get; set; }

        public List<Model2> TypeofRice { get; set; }
        public List<Model2> TpeofPulses { get; set; }
        public List<Model2> TypeofWheat { get; set; }
        public static string ManagementfilePath { get; private set; }
    }
}


            

