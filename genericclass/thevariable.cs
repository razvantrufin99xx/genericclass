using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericclass
{
    public class thevariable
    {
        public string type = "string";
        public int length = 50;
        public string name = "x";
        public string value = "00000000000";

        public thevariable() { }
        public thevariable(string ptype,int len,string pname, string pval) {
            this.type = ptype;   
            this.length = len;
            this.name = pname;
            this.value = pval;

        }
    }
}
