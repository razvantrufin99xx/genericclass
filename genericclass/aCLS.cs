using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericclass
{
    public  class aCLS
    {
        public CLS thecls = new CLS();

        public aCLS() { }
        public bool addnewvariable()
        {
            thecls.initCLS("couter", "int", 8,"0");
            return true;
        }
        public bool increment(int i, int val)
        {
            //get datas from thecls
            string name = thecls.gen[i].name;
            string tip = thecls.gen[i].type;
            int len = thecls.gen[i].length;
            string v = thecls.gen[i].value;

            int xx = 0;
            xx = Convert.ToInt32(v);

            thecls.gen[i].value = xx++.ToString();

            return true;
        }
    }
}
