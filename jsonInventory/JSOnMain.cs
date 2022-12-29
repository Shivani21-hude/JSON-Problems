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
                    Console.WriteLine("Name : " + items.Name + ",  Weight : " + items.Weight + ",  Price :  " + items.Price + ", Total Value :" + value);
                }
            
        }

        List<Model2> item = new List<Model2>();
        public void ReadmanagementJsonFile(string filePath)
        {

            var json = File.ReadAllText(filePath);

            this.item = JsonConvert.DeserializeObject<List<Model2>>(json);

            foreach (var item2 in item)
            {
                double value2 = item2.price * item2.weight;
                Console.WriteLine("Tpe of rice : " + item2.name + ",  Weight " + item2.weight + ", Price : " + item2.price +" Total value :" + value2);
            }
        }
    }
}
