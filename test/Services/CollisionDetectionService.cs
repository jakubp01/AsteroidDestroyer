using System;
using System.Collections.Generic;

namespace test
{
    internal class CollisionDetectionService
    {
        Cartridge _cartridge;
        List<Asteroid> _asteroidList;

        public bool _isAsteroidDelete { get; set; } = false;

        public int _asteroidRadius { get; set; }

        public int _asteroidToDelete { get; set; }

        public CollisionDetectionService(Cartridge cartridge, List<Asteroid> asteroidsList, int radius, bool isAsteroidDelete, int asteroidToDelete)
        {
            _cartridge = cartridge;
            _asteroidList = asteroidsList;

            _isAsteroidDelete = isAsteroidDelete;

            _asteroidRadius = radius;
            _asteroidToDelete = asteroidToDelete;

        }

        public void CollisonDetection(Bullet bullet)
        {
            var index = 0;

            foreach (var _asteroid in _asteroidList)
            {
                if (Math.Sqrt(Math.Pow((bullet.x - _asteroid.x), 2) + Math.Pow((bullet.y - _asteroid.y), 2)) <= _asteroidRadius)
                {
                    _cartridge._CartridgeList.Remove(bullet);
                    _asteroidToDelete = index;
                    _isAsteroidDelete = true;
                    break;

                }

                index++;
            }
        }
    }
}
