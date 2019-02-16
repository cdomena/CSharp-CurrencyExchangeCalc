using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouFinal
{
    public class CountryList
    {
        
        

        public Dictionary<string, string> currencyCode = new Dictionary<string, string>
                                            {
                                                {"AUSTRALIA","AUD"},
                                                {"CHRISTMAS ISLAND", "AUD"},
                                                {"COCOS KEELING ISLANDS","AUD"},
                                                {"HEARD ISLAND AND McDONALD ISLANDS","AUD"},
                                                {"KIRIBATI","AUD"},
                                                {"NAURU","AUD"},
                                                {"NORFOLK ISLAND","AUD"},
                                                {"TUVALU","AUD"},
                                                {"BULGARIA","BGN"},
                                                {"BRAZIL","BRL"},
                                                {"CANADA","CAD"},
                                                {"SWITZERLAND","CHE"},
                                                {"LIECHTENSTEIN","CHF"},
                                                {"CHINA","CNY"},
                                                {"CZECH REPUBLIC","CZK"},
                                                {"DENMARK","DKK"},
                                                {"FAROE ISLANDS","DKK"},
                                                {"GREENLAND","DKK"},
                                                {"ANDORRA","EUR"},
                                                {"AUSTRIA","EUR"},
                                                {"BELGIUM","EUR"},
                                                {"CYPRUS","EUR"},
                                                {"ESTONIA","EUR"},
                                                {"EUROPEAN UNION","EUR"},
                                                {"FINLAND","EUR"},
                                                {"FRANCE","EUR"},
                                                {"FRENCH GUIANA","EUR"},
                                                {"FRENCH SOUTHERN TERRITORIES","EUR"},
                                                {"GERMANY","EUR"},
                                                {"GREECE","EUR"},
                                                {"GUADELOUPE","EUR"},
                                                {"HOLY SEE","EUR"},
                                                {"IRELAND","EUR"},
                                                {"ITALY","EUR"},
                                                {"LATVIA","EUR"},
                                                {"LITHUANIA","EUR"},
                                                {"LUXEMBOURG","EUR"},
                                                {"MALTA","EUR"},
                                                {"MARTINIQUE","EUR"},
                                                {"MAYOTTE","EUR"},
                                                {"MONACO","EUR"},
                                                {"MONTENEGRO","EUR"},
                                                {"NETHERLANDS","EUR"},
                                                {"PORTUGAL","EUR"},
                                                {"REUNION","EUR"},
                                                {"SAINT BARTHELEMY","EUR"},
                                                {"SAINT MARTIN","EUR"},
                                                {"SAINT PIERRE AND MIQUELON","EUR"},
                                                {"SAN MARINO","EUR"},
                                                {"SLOVAKIA","EUR"},
                                                {"SLOVENIA","EUR"},
                                                {"SPAIN","EUR"},
                                                {"ALAND ISLANDS","EUR"},
                                                {"GUERNSEY","GBP"},
                                                {"ISLE OF MAN","GBP"},
                                                {"JERSEY","GBP"},
                                                {"UNITED KINGDOM OF GREAT BRITAIN AND NORTHERN IRELAND","GBP"},
                                                {"HONG KONG","HKD"},
                                                {"CROATIA","HRK"},
                                                {"HUNGARY","HUF"},
                                                {"INDONESIA","IDR"},
                                                {"ISRAEL","ILS"},
                                                {"BHUTAN","INR"},
                                                {"INDIA","INR"},
                                                {"ICELAND","ISK"},
                                                {"JAPAN","JPY"},
                                                {"SOUTH KOREA","KRW"},
                                                {"MEXICO","MXN"},
                                                {"MALAYSIA","MYR"},
                                                {"BOUVET ISLAND","NOK"},
                                                {"NORWAY","NOK"},
                                                {"SVALBARD AND JAN MAYEN","NOK"},
                                                {"COOK ISLANDS","NZD"},
                                                {"NEW ZEALAND","NZD"},
                                                {"NIUE","NZD"},
                                                {"PITCAIRN","NZD"},
                                                {"TOKELAU","NZD"},
                                                {"PHILIPPINES","PHP"},
                                                {"POLAND","PLN"},
                                                {"ROMANIA","RON"},
                                                {"RUSSIA","RUB"},
                                                {"SWEDEN","SEK"},
                                                {"SINGAPORE","SGD"},
                                                {"THAILAND","THB"},
                                                {"TURKEY","TRY"},
                                                {"AMERICAN SAMOA","USD"},
                                                {"BONAIRE, SINT EUSTATIUS AND SABA","USD"},
                                                {"BRITISH INDIAN OCEAN TERRITORY","USD"},
                                                {"ECUADOR","USD"},
                                                {"EL SALVADOR","USD"},
                                                {"GUAM","USD"},
                                                {"HAITI","USD"},
                                                {"MARSHALL ISLANDS","USD"},
                                                {"MICRONESIA","USD"},
                                                {"NORTHERN MARIANA ISLANDS","USD"},
                                                {"PALAU","USD"},
                                                {"PANAMA","USD"},
                                                {"PUERTO RICO","USD"},
                                                {"TIMOR-LESTE","USD"},
                                                {"TURKS AND CAICOS ISLANDS","USD"},
                                                {"UNITED STATES MINOR OUTLYING ISLANDS","USD"},
                                                {"UNITED STATES OF AMERICA","USD"},
                                                {"VIRGIN ISLANDS","USD"},
                                                {"LESOTHO","ZAR"},
                                                {"NAMIBIA","ZAR"},
                                                {"SOUTH AFRICA","ZAR"},
                                              
                                            };
        public void SearchTerm(string term)
        {
            //checks if search entry is more than 3 characters
            if (term.Length < 4)
            {
                Console.WriteLine("Please enter more than 3 characters for a search");
            }
            else
            {
                var code = term.ToUpper();
                var value = (from i in currencyCode.Where(i => i.Key.Contains(code)) select i); //searchs the dictionary for matches
                Console.WriteLine("Search Results:");
                if (value.Count() == 0)
                {
                    Console.WriteLine("No results found");
                }
                else
                {
                    foreach (KeyValuePair<string, string> i in value)
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine();
                }
            }
        }
        public bool CodeSet(string verify)
        {
            bool search = currencyCode.ContainsValue(verify.ToUpper());
            return search;
        }

    }
}
