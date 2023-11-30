using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_UNI
{
    //Polymorphism (polimorfizm) - eyni adli methoddan çoxsaylı tetbiqetmeye imkanı verir
    //Polymorphism iki yere ayrilir : statik (compiler time'da teyin olunan) ve dinamik (runtime'da teyin olunan)
    //statik polymorphism - overload prosesi
    //dinamik polymorpism - override keywordu istifade edilerek yerine yetirilen prosesler.
    internal class Polymorphism
    {
        // overload prosesi - eyni ada ferqli signature sahib metodlar yazmagimiza imkan yaradir

        public virtual int Age { get; set; } = 18;
        public void Get()
        {

        }

        public int Get(int num)
        {
            return num;
        }
        public string Get(string word)
        {
            return word;
        }

        //ferqli data tipinde olan inputlarin yerinin deyisilmesi ile overload etmek mumkundur.
        public void Get(int num, string word)
        {

        }

        public void Get(string word, int num)
        {

        }


        //Outputu deyisdirerek overload etmek mumkun deyil
        /*public int Get()
        {

        }*/


        //Access modifie deyisdirerek overload etmek mumkun deyil
        /*private void Get()
        {

        }*/

        public virtual void WriteToConsole()
        {
            Console.WriteLine("Base class writes");
        }
        public virtual string ReadFromConsole()
        {
            string response = Console.ReadLine();
            return response;
        }

    }


    internal class Drived : Polymorphism
    {
        //override - base klassda abstract ve ya virtual keywordlerinden istifade edilen property/metod'lari drive klassda istifade etmeye
        //ve hetda hemin property/metodu drive klassa lazim olan sekilde uygunlasdirmaga imkan verir.
        public override void WriteToConsole()
        {
            Console.WriteLine("Drive class writes");
        }

        public override string ReadFromConsole()
        {
            //base keyword'u sayesinde base klassda qeyd olunan ReadFromConsole() metodundan istifade edir
            return base.ReadFromConsole();
        }

    }


}
