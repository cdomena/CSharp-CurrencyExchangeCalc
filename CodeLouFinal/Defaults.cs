using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouFinal
{

    public class DefaultSettings
    {
        public Defaults[] Starting { get; set; }
    }

    public class Defaults
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
    }

}
