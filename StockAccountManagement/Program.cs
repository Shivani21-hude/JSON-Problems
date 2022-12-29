using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to JSON Inventory Stock Account Management \n");
            string inventoryFilePath = @"E:\\JSON Problems\\StockAccountManagement\\StockAccountManagement\\Stock.json";
            stockAccountmanagement jSOnMain = new stockAccountmanagement();
            jSOnMain.ReadJsonFile(inventoryFilePath);
        }
    }
}