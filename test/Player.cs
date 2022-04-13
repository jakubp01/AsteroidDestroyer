using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Player
    {
        
        public int _points { get; set; }
        public int _lifes { get; set; }
        public string _name { get; set; }

        public Player()
        {
            _points = 0;
            _lifes = 3;
        }
    }
}
