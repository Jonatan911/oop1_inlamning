using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace DogDaycareApp
{
    internal class DaycareConsole
    {
        private DogDaycare _daycare;

        public DaycareConsole(DogDaycare daycare)
        {
            _daycare = daycare;
        }


        public void Run()
        {
            while (true)
            {
                ShowMenu();

                switch (GetStartInput())
                {
                    case "1":
                        PickUpDog();
                        break;
                    case "2":
                        DropOffDog();
                        break;
                    case "3":
                        ShowAllDogs();
                        break;
                    case "4":
                        return;
                }

            }


        }

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Pick up your dog");
            Console.WriteLine("2. Drop off your dog");
            Console.WriteLine("3. List all dogs");
            Console.WriteLine("4. Quit");
        }

        public string GetStartInput()
        {
            string input;
            do input = Console.ReadLine();
            while (!IsStartInput(input));

            return input;
        }

        private bool IsStartInput(string input)
        {
            return input.Equals("1") | input.Equals("2") | input.Equals("3") | input.Equals("4");
        }

        private void PickUpDog()
        {
            (string name, string breed) = GetNameAndBreed();
            Dog dog = _daycare.RemoveDog(name, breed);

            if (dog == null)
            {
                Console.WriteLine("We do not have your dog.");
                Thread.Sleep(2000);
                return;
            }

            Console.Clear();
            Console.WriteLine("1. Play with dog");
            Console.WriteLine("2. Go back to startmenu");

            while (true)
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        PlayWithDog(dog);
                        return;
                    case "2": 
                        return;
                }
            }
        }


        private string GetInput()
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input != null)
                {
                    return input.ToLower();
                }
            }
        }


        private void DropOffDog()
        {
            (string name, string breed) = GetNameAndBreed();
            if (!_daycare.DropOffDog(name, breed))
            {
                Console.WriteLine("Daycare is full.");
                Thread.Sleep(2000);
            }
        }


        private (string name, string breed) GetNameAndBreed()
        {
            Console.Clear();
            Console.WriteLine("Input name:");
            string name = GetInput();

            Console.Clear();
            Console.WriteLine("Input breed:");
            string breed = GetInput();

            return (name, breed);
        }

        private void PlayWithDog(Dog dog)
        {
            Console.WriteLine("Playing with " + dog.GetName() + " the " + dog.GetBreed() + "..");
            dog.Bark();
        }

        private void ShowAllDogs()
        {
            Console.Clear();
            Console.WriteLine("Here are all the dogs in the daycare:");
            Console.WriteLine("____________________________________");
            _daycare.PrintDogs();
            Console.WriteLine();
            WaitForEscape();
        }

        private void WaitForEscape()
        {
            Console.WriteLine("Press ESC to go back to startmenu");

            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                if (key.Equals(ConsoleKey.Escape))
                {
                    return;
                }
            }
        }









    }
}