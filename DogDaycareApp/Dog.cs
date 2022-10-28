using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DogDaycareApp
{
    internal class Dog 
    {

        private string _name;
        private string _breed;

        public Dog(string name, string breed)
        {
            this._name = name;
            this._breed = breed;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetBreed()
        {
            return _breed;
        }

        public virtual void Bark()
        {
            Console.WriteLine("*silence*");
            Thread.Sleep(2000);
        }

    }
}