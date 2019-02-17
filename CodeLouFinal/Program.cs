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
        // attempting to deserialize json to dictionary for easy search.
        public static Dictionary<Rates>

        static int Menu()
        {
            Console.WriteLine("Exchange rate published by: European Central Bank");
            Console.WriteLine("API by Madis Vain: https://exchangeratesapi.io/");
            Console.WriteLine("   +----------------------------+");
            Console.WriteLine("   |   Currency Exchange        |");
            Console.WriteLine("   |   1. Change Origin         |");
            Console.WriteLine("   |   2. Select Destination    |");
            Console.WriteLine("   |   3. Search Currency Codes |");
            Console.WriteLine("   |   4. Calculate Exchange    |");
            Console.WriteLine("   |   5. Quit                  |");
            Console.WriteLine("   +----------------------------+");
            Console.WriteLine("Origin = " + Program.Origin + " Destination = " + Program.Destination);
            Console.Write("Enter your Selection: ");
            Console.WriteLine();
            var selection = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(selection))
            {
                Console.WriteLine("Please try again the response was either blank.");
                return 0;
            }
            else if (int.TryParse(selection, out int result))
            {
                return result;
            }
            return 0;


        }
        static string Origin {get; set;}
        static string Destination { get; set; }
     





        static void Main(string[] args)
        {
            Defaults defaults = new Defaults(); //used later to set default saved country selections
            var menuOption = Menu();
            CountryList search = new CountryList();
            while (menuOption < 5)
            {
                switch (menuOption)
                {
                    case 1:
                        Console.WriteLine("Enter Origin Country Code:");
                        var test = Console.ReadLine();
                                               
                        if (search.CodeSet(test) == true)
                        {
                            Console.WriteLine("Origin Set");
                            Program.Origin = test.ToUpper();
                            Console.Clear();

                        }
                        else
                        {
                            Console.WriteLine("No match Found");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter Destination Country Code:");
                        var test2 = Console.ReadLine();

                        if (search.CodeSet(test2) == true)
                        {
                            Console.WriteLine("Destination Set");
                            Program.Destination = test2.ToUpper();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("No match Found");
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Enter the Country name:");
                        search.SearchTerm(Console.ReadLine());
                        break;
                    case 4:
                        
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("You chose an invalid option. Press Enter to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }

                if (menuOption != 5)
                {
                    menuOption = Menu();
                }
            }



        }
    }
}
