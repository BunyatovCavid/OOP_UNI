using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_UNI
{
    internal class Car
    {
        //field
        private int year;

        public Car()
        {
            year = 2000;
            Drive();
        }


        //Property
        public int year2
        { 
            get
            {
                return year *2 ;
            }
            set
            {
                year2 = value;
            }
        }

        public void Drive(string word, int number)
        {

        }
        public void Drive(int number, string word)
        {

        }
    }


    abstract class Animal
    {
        public virtual string voice { get; set; }
        public virtual string favoritefood { get; set; }
        public virtual int year { get; set; }
        public virtual string bloodtype { get; set; }
        abstract protected int bonenumber { get; set; }


        public virtual void Fly()
        {

        }

        public abstract void Swim();

        public void Run()
        {

        }
    }

    internal class Own : Animal
    {
        protected override int bonenumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string favoritefood { get => base.favoritefood; set => base.favoritefood = value; }
        public override string voice { get => base.voice; set => base.voice = value; }

        public override void Swim()
        {
           
        }
    }

    internal class Vet : Animal
    {

        protected override int bonenumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string bloodtype { get => base.bloodtype; set => base.bloodtype = value; }

        public override void Swim()
        {
            
        }
    }



}
