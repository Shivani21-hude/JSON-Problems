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
        public static string ManagementfilePath { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to JSON Inventory Data Management \n");
            string inventoryFilePath = @"E:\\JSON Problems\\JSON-Problems\\jsonInventory\\Inventory.json";
            JSOnMain jSOnMain = new JSOnMain();
            jSOnMain.ReadJsonFile(inventoryFilePath);
            string ManagemenrfilePath = @"E:\\JSON Problems\\JSON-Problems\\jsonInventory\\management.json";
           
            jSOnMain.ReadmanagementJsonFile(ManagementfilePath);
        }
    }
}