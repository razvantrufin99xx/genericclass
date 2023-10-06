using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericclass
{
    public class CLS
    {
        public List<thevariable> gen = new List<thevariable> { };
      
        
        public bool addNewTypeAndLen(string t , int x, string n , string v)
        { 
            gen.Add(new thevariable(t,x,n , v));

            return true;
        }
       
        public CLS(string nameof, string thetypeof, int lenof, string pv) {
            initCLS(nameof,thetypeof,lenof, pv);
        }
        public CLS()
        {
            initCLS();
        }
        public bool initCLS() {

            inittypeslist();
            return true;    
        }
        public bool inittypeslist()
        {
            addNewTypeAndLen("string", 50,"x","0");
            return true;
        }
      
        public bool initCLS(string n, string t, int l, string pv)
        {
           
            addNewTypeAndLen(t, l,l,pv);
            return true;
        }
    }
}
