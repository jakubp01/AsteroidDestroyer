using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace test
{
    internal class AsteroidsService
    {
        List<Asteroid> _asteroidsList { get; set; }

        public int _randomOfAppear { get; set; }
        Random _random;


        public AsteroidsService(List<Asteroid> asteroidsList, int randomOfappear)
        {
            _random = new Random();

            _asteroidsList = asteroidsList;
            _randomOfAppear = randomOfappear;
        }


        public void MakeAsteroid()
        {
            if (_random.Next(100) > _randomOfAppear)
            {
                Asteroid asteroid = new Asteroid();
                _asteroidsList.Add(asteroid);

            }
        }
        public void MoveAsteroid(Asteroid asteroid)
        {
            asteroid._rotate += asteroid._asteroidSpeed;
            asteroid.y += asteroid._asteroidSpeed;

        }
        public void AsteroidsMovment(int bottonBorder, Player player)
        {
            if (_asteroidsList.Count != 0)
            {
                for (int i = 0; i < _asteroidsList.Count; i++)
                {

                    var asteroid = _asteroidsList[i];

                    if (asteroid.y < bottonBorder)
                    {
                        MoveAsteroid(asteroid);
                    }
                    else
                    {
                        player._lifes--;

                        _asteroidsList.Remove(asteroid);
                    }

                }

            }
        }
        public void DrawingAsteroid(PaintEventArgs e, List<Asteroid> asteroidsList)
        {
            foreach (Asteroid asteroid in asteroidsList)
            {
                asteroid.Draw(e.Graphics);
            }
        }


    }
}
