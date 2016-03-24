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
            string[] catalogArray = ReadCatalogFromFile();  // read catalog from txt file
            int productsAdded = 0;
            string userInput = "";
            bool inCatalog;
            string maxProducts = "";
            int maxProd;

            Console.WriteLine("How many items would you like to purchase?  Set the maximum with this value:");
            maxProducts = Console.ReadLine();
            maxProd = int.Parse(maxProducts);       // set loop counter

            Console.WriteLine("What products would you like to purchase? Enter quit to end list.");    

            string[] cart = new string[maxProd];    // define available cart size

            while (productsAdded < maxProd)
            {
                
                userInput = Console.ReadLine();
                //string userInputUpper = userInput.ToUpper();

                inCatalog = IsProductInCatalog(userInput, catalogArray);        // check to see if product in catalog

                if (inCatalog == true)
                {
                    cart[productsAdded] = userInput;        // add to cart
                    Console.WriteLine("$$$ \"" + userInput + "\" has been added to your shopping cart.");
                    productsAdded++;    // increment added
                }
                else if(userInput.ToUpper().Equals("QUIT"))
	            {
                    break;  // exit loop on quit
	            }
                else
                {
                    Console.WriteLine("Sorry, the product \"" + userInput + "\" is not in the catalog.  Please try another product.");
                }

            }

            Console.WriteLine("You are ready to check out! Here are the products in your cart:");

            Array.Sort(cart);

            foreach (var item in cart)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
