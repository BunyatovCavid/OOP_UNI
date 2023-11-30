using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_UNI.OOP
{
    //Inheritence - Base klassin menimsediydiyi (impliment)  klasslarda (drived/child) xususiyyetlerini (property/metod) istifade edile bilmesine icaze verir.

    //Base klass
    abstract class Transportation
    {
        //virtual keywordu ile isare edilen property/metod'un drived klassda istifadesi isteye baglidir.
        public virtual string brand { get; set; }
        public virtual int amount { get; set; }

        //abstract keywordu ile isare edilen property/metod'un drived klassda istifadesi mutleqdir.
        public abstract int Year { get; set; }
        public abstract string Color { get; set; }
        public abstract bool State { get; set; }

        public virtual void WriteHi()
        {
            Console.WriteLine("Hi");
        }

        public abstract void Drive();
        public abstract void Stop();
    }

    //Derived / Child
    //Derived klassa sadece bir base klass implement edile biler
    internal class Car : Transportation
    {
        int year;
        string color;
        bool state;

        public override int Year { get { return year; } set { year = value; } }
        public override string Color { get { return color; } set { color = value; } }
        public override bool State { get { return state; } set { state = value; } }

        public override string brand { get => base.brand; set => base.brand = value; }

        public override void Drive()
        {
            Console.WriteLine("The car drives");
        }

        public override void Stop()
        {
            Console.WriteLine("The car stops");
        }
    }

    internal class Bus : Transportation
    {
        int year;
        string color;
        bool state;

        public override int Year { get { return year; } set { year = value; } }
        public override string Color { get { return color; } set { color = value; } }
        public override bool State { get { return state; } set { state = value; } }

        public override int amount { get => base.amount; set => base.amount = value; }

        public override void Drive()
        {
            Console.WriteLine("The bus drives");
        }

        public override void Stop()
        {
            Console.WriteLine("The bus stops");
        }
    }





}
