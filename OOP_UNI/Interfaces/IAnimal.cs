using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_UNI.Interfaces
{
    //interface'ler kodumuzda var ola bilecek en yuksek seviyye abstraction'a (bagimsizliga) sahib olurlar.
    //interface'de qeyd olunan property/metodlar public olmalidir.
    //interface'de qeyd olunan property/metodlarin body'si ola bilmez.
    public interface IAnimal
    {
        public string Color { get; set; }
        public bool State { get; set; }

        public void Breathe();
        public bool Sleep();

    }
}
