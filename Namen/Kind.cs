using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namen
{
    public class Kind
    {
        public string name { get; set; }
        public string anzahl { get; set; }
        public string position { get; set; }
        public string geschlecht { get; set; }
        public Kind(string name, string anzahl, string geschlecht, string position)
        {
            this.name = name;
            this.anzahl = anzahl;
            this.geschlecht = geschlecht;
            this.position = position;
        }
    }
    
}
