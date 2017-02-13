using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Playsong
    {
        List<string> Song = new List<string>();


        public void ADD(string name) {

            Song.Add(name);
        }
    }
}
