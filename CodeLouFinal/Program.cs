using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CodeLouFinal
{
    class Program
    {
        public Program()
        {
            // constructor to read Defaults and fill in properties
            
        }

        static public string Origin { get; set; }
        static public string Destination { get; set; }

        // attempting to deserialize json to dictionary for easy search.
        public static Dictionary<string, decimal> DeserializeRates()
        {
            var rates = new Dictionary<string, decimal>();
            var serializer = new JsonSerializer();
            string path = Directory.GetCurrentDirectory();
            using (var reader = new StreamReader(Path.Combine(path, @"Data\Exchangerates.json")))
            using (var jsonReader = new JsonTextReader(reader))
            {
                rates = serializer.Deserialize<Dictionary<string, decimal>>(jsonReader);
            }
            return rates;
        }

        static int Menu()
        {
            Console.WriteLine("Exchange rate published by: European Central Bank");
            Console.WriteLine("API by Madis Vain: https://exchangeratesapi.io/");
            Console.WriteLine("   +----------------------------+");
            Console.WriteLine("   |   Currency Exchange        |");
            Console.WriteLine("   |   1. Select Origin         |");
            Console.WriteLine("   |   2. Select Destination    |");
            Console.WriteLine("   |   3. Search Currency Codes |");
            Console.WriteLine("   |   4. Calculate Exchange    |");
            Console.WriteLine("   |   5. Quit                  |");
            Console.WriteLine("   +----------------------------+");
            Console.WriteLine("Origin = " + Program.Origin);
            Console.WriteLine("Destination = " + Program.Destination);
            Console.Write("Enter your Selection: ");
            Console.WriteLine();
            var selection = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(selection))
            {
                Console.WriteLine("Please try again the response was blank.");
                return 0;
            }
            else 
            {
                int.TryParse(selection, out int result);
                return result;
            }
        }

        static void Main(string[] args)
        {
            Origin = "n/a";
            Destination = "n/a";

            var menuOption = Menu();
            CountryList search = new CountryList();
            var myRates = new RatesClass(DeserializeRates()); //Initialize rate class with deserialized data from Exchangerates.json
            string exchangeAmount;
            while (menuOption != 5)
            {
                switch (menuOption)
                {
                    case 1:
                        Console.WriteLine("Enter Origin Country Code:");
                        var test = Console.ReadLine();
                        search.SetCountryCode(menuOption, test);
                        break;
                    case 2:
                        Console.WriteLine("Enter Destination Country Code:");
                        var test2 = Console.ReadLine();
                        search.SetCountryCode(menuOption, test2);
                        break;
                    case 3:
                            search.SearchTerm();
                        break;
                    case 4:
                            Console.WriteLine("Enter amount to convert:");
                            exchangeAmount = Console.ReadLine();
                            var test3 = myRates.ConvertCurrency(exchangeAmount);
                            Console.Write("Your exchange will be:{0:C}", test3);
                            Console.WriteLine(" " + Destination);
                            Console.WriteLine();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Unrecognized selection, only (1-5) are valid. Press ENTER to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
                menuOption = Menu();
            }
        }
    }
}
