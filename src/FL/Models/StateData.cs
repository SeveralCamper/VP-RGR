using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL.Models
{
    public class StateData
    {
        public string Name { get; private set; }
        public string Abbreviation { get; private set; }
        public string Capital { get; private set; }

        public StateData(string name, string abbreviatoin, string capital)
        {
            Name = name;
            Abbreviation = abbreviatoin;
            Capital = capital;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
