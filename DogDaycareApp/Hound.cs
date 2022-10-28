using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Reflection;
using System.Threading;

namespace DogDaycareApp
{
    internal class Hound : Dog
    {
        public Hound(string name, string breed) : base(name, breed)
        {
        }

        public override void Bark()
        {
            SoundPlayer barkPlayer = new SoundPlayer(Properties.Resources.houndbark);
            barkPlayer.PlaySync();
        }

    }
}
