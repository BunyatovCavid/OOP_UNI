using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_UNI
{
    internal class Encapsulation
    {
        
        //Encapsulation - diger klasslardan deyisenlere bir basa el catanligi aradan qaldirir ve hem menimsedilen,
        //hem de geri qaytarilan deyer uzerinde emeliyyatlar gore bilmeyimize imkanyaradir, bu sayede deyisenin deyerin qorumagimiza imkan verir.
        private int age;

        public int Age
        {
            //Property'nin deyerinden istifade etmek istediyimizde get bloku ise dusur.
            //int age = Age;
            //Get blokunda er zaman return qeyd olunmalidir.
            //Get blokunda hec bir zaman property'nin ozu cagrila bilmez, bunun sebebi hemin vaxt sonsuz bir dongu yaranmasidi.
            get
            {
                return age / 2;
            }
            //Property'edeyer teyin etmekistediyimizde set bloku ise dusur.
            //Age = 15;
            set
            {
                //value - set bloku ise dusende menimsedilen deyer
                age = value + 150;
            }
        }

        //Property istifade edilimeyen halda Encapsulation
        public int Get()
        {
            return age / 2;
        }
        public void Set(int value)
        {
            age = value + 150;
        }

    }
}
