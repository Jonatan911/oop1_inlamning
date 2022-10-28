using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace DogDaycareApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DogDaycare daycare = new DogDaycare();
            DaycareConsole console = new DaycareConsole(daycare);
            console.Run();

        }

    }

}