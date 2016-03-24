using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4LabShopCart
{
    class Program
    {

        static string[] ReadCatalogFromFile()
        {
            StreamReader inputReader = new StreamReader("catalog.txt");
            string inputString = "";
            string[] stringArray = new string[200];


            for (int i = 0; i < 200; i++)
            {
                inputString = inputReader.ReadLine();
                stringArray[i] = inputString;
            }

            return stringArray;
        }

        static bool IsProductInCatalog(string product, string[] catalog)
        {
            bool productInCatalog = false;
            foreach (string value in catalog)
            {
               if(product == value)
                {
                    productInCatalog = true;
                    break;

                }
               else
               {
                   productInCatalog = false;

               }
            }

            return productInCatalog;
        }

        static void Main(string[] args)
        {
            string[] catalogArray = ReadCatalogFromFile();

            string[] cart = new string[5];


        }
    }
}
