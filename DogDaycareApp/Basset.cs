using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace DogDaycareApp
{
    internal class Basset : Dog
    {
        public Basset(string name, string breed) : base(name, breed)
        {
        }

        public override void Bark()
        {
            SoundPlayer barkPlayer = new SoundPlayer(Properties.Resources.bassetbark);
            barkPlayer.PlaySync();
        }
    }
}
