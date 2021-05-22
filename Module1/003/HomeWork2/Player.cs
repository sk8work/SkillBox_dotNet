using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Player
    {
        /********** vars **********/

        public string Name { get; set; }
        public int Steps { get; set; }

        public string NewPlayer()
        {
            Name = Console.ReadLine();
            return Name;
        }
    }
}
