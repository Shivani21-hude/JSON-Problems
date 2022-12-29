using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement
{
    internal class stockAccountmanagement
    {
        List<StockDetails> data = new List<StockDetails>();
        public void ReadJsonFile(string FilePath)
        {

            var json = File.ReadAllText(FilePath);

            this.data = JsonConvert.DeserializeObject<List<StockDetails>>(json);

            foreach (var items in data)
            {
                double value = items.StockPrice * items.NoOfShares;
                Console.WriteLine(" Stock Name : " + items.StockName + ",  Stock price : " + items.StockPrice + ",  No of Shares :  \n" + items.NoOfShares + ", Total Stock :" + value);
            }

        }
    }
}
