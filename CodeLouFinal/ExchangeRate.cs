using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouFinal
{
    public class RatesClass
    {
        public RatesClass(Dictionary<string, decimal> rates)
        {
            // Constructor takes the deserialized info and adds it to the Rates Property
            Rates = rates;
        }

        Dictionary<string, decimal> Rates { get; }

        //VerifyAmount method works 100%
        public bool VerifyAmount(string amount)
        {
            if (string.IsNullOrWhiteSpace(amount))
            {
                return false;
            }
            else if(decimal.TryParse(amount, out decimal verified))
            {
                return true;
            }
            return false;
        }
        // calculates the exchange based on selection
        public decimal ConvertCurrency(string exchangeAmount)
        {
            if(VerifyAmount(exchangeAmount))
            {
                var orig = decimal.Parse(exchangeAmount);
                return (orig / Rates[Program.Origin]) * Rates[Program.Destination];
            }
            else
            {
                Console.WriteLine("The amount entered is invalid.");
                return 0;
            }
        }
    }
}
