using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonInventory
{
    public class JSOnMain
    {

        
        List<Model> data = new List<Model>();
        public void ReadJsonFile(string FilePath)
        {
           
                var json = File.ReadAllText(FilePath);
          
                 this.data= JsonConvert.DeserializeObject<List<Model>>(json);
               
                foreach (var items in data)
                {
                    double value = items.Price * items.Weight;
                    Console.WriteLine("Name : "+ items.Name + ",  Weight : " + items.Weight + ",  Price :  " + items.Price + ", Total Value :" + value);
                }
            
        }
    }
}
