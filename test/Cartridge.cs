using System.Collections.Generic;

namespace test
{
    internal class Cartridge
    {
        public int _amount { get; set; }

        public List<Bullet> _CartridgeList;

        public Cartridge()
        {
            _amount = 10;
            _CartridgeList = new List<Bullet>();
        }


        public void Reload()
        {
            if (_amount == 0)
            {
                _amount = 10;
            }
        }

    }
}
