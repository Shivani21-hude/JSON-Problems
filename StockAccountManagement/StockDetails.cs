using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement
{
    internal class StockDetails
    {
        public string StockName { get; set; }
        public int StockPrice { get; set; }
        public int NoOfShares { get; set; }

        public List<StockDetails> Google { get; set; }
        public List<StockDetails> Amazon { get; set; }
        public List<StockDetails> AMD { get; set; }
    }
}
