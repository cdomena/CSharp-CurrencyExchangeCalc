using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouFinal
{

    //public class RootObject
    //{
    //    public Rates rates { get; set; }
    //}

    public class RatesClass
    {
        public RatesClass(Dictionary<string, decimal> rates)
        {
            Rates = rates;
        }

        Dictionary<string, decimal> Rates {get;}
    }
    //public bool VerifyAmount(string amount)
    //{



    //}

}
