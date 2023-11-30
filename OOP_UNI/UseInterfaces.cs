using OOP_UNI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_UNI
{
    //interface'de qeyd edilen her bir property/metod impliment olunan klassda istifade edilmelidir.
    //Inheritence'den ferqli olaraq klassa istenilen sayda interface impliment edile biler.
    //bu hemin klassa inheritance edile bilmeyeceyi menasina gelmir.
    abstract class TestInheritence 
    {
    
    }

    internal class UseInterfaces :TestInheritence, IAnimal, IBird, IFish
    {
        public string Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool State { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Breathe()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public bool Sleep()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }
    }
}
