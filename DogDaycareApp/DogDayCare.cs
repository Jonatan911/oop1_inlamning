using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace DogDaycareApp
{
    internal class DogDaycare
    {
        private const int Capacity = 10;  
        private readonly List<Dog> _dogs = new List<Dog>();

        public DogDaycare()
        {

        }

        public bool DropOffDog(string name, string breed)
        {
            switch (breed.ToLower())
            {
                case "hound":
                    return TryAdd(new Hound(name, breed));
                case "basset":
                    return TryAdd(new Basset(name, breed));
                default:
                    return TryAdd(new Dog(name, breed));
            }
        }

        private bool TryAdd(Dog dog)
        {
            if (_dogs.Count >= Capacity)
            {
                return false;
            }
            _dogs.Add(dog);
            return true;
        }

        public Dog RemoveDog(string name, string breed)
        {
            foreach (var dog in _dogs)
            {
                if (dog.GetName().Equals(name) & dog.GetBreed().Equals(breed))
                {
                    _dogs.Remove(dog);
                    return dog;

                }
            }
            return null;
        }

        public void PrintDogs()
        {
            foreach (var dog in _dogs)
            {
                Console.WriteLine(dog.GetName() + " the " + dog.GetBreed());
            }

        }


    }
}