using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_UNI.OOP
{
    abstract class Abstraction
    {
        //Abstraction (mucerredlesdirme) - diger klasslara sadece onlara lazim olan deyisenlere (field/property) ve metodlara vere bilmek ucun,
        //esas (Base) klassin obyektinin alinmasini qeyri-mumkun edilmesi.
        // new Abstraction(); qeyri-mumkundur.

        public int num;
        string word;

        public string Word { get; set; }

        public void Get()
        {

        }

        //abstract keywordu sadece abstract klasslarda istifade oluna bilir
        //abstract olaraq teyin olunmus field/property/metod hec bir zaman private ola bilmez
        //abstract olaraq teyin olunmus metodlarin body'si ( {  } ) ola bilmez.
        public abstract void Post();
    }
}
