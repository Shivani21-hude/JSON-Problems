using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to JSON Inventory Data Management \n");
            string inventoryFilePath = @"E:\\RFP\JSONInventory\\JSONsample\\Inventory.json";
            JSOnMain jSOnMain = new JSOnMain();
            jSOnMain.ReadJsonFile(inventoryFilePath);
        }
    }
}