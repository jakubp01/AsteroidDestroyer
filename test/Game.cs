using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    internal class Game
    {
        Random _random;
         int _randomOfAppear;
         Rocket _rocket;
         Cartridge _cartridge;
         List<Asteroid> _asteroidList;
         bool _isAsteroidDelete = false;
        int _asteroidToDelete;
         Player _player;
        float _gameLevel;
        float _pointsToBeatLevel;
        public PutNicknameForm _putNicknameForm;
        Scoreboard _scoreboard;
        
        public Game()
        {
            _putNicknameForm = new PutNicknameForm();
            _putNicknameForm.Show();
            
            _scoreboard = new Scoreboard();
            _randomOfAppear = 96;
            _cartridge = new Cartridge();
            _asteroidList = new List<Asteroid>();
            _random = new Random();
            _rocket = new Rocket(_cartridge);
            _player = new Player();
            _pointsToBeatLevel = 40;
            _gameLevel = 0;
            
            
        }

        public void DrawwingObjects(PaintEventArgs e)
        {
            foreach (var bullet in _cartridge._CartridgeList)
            {
                bullet.Draw(e.Graphics);

            }
            foreach (Asteroid asteroid in _asteroidList)
            {
                asteroid.Draw(e.Graphics);
            }
            _rocket.Draw(e.Graphics);
        }

        public void RocketControl(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                _rocket.Move("left");
            }
            if (e.KeyCode == Keys.Right)
            {
                _rocket.Move("right");
            }
            if (e.KeyCode == Keys.Space)
            {
                _rocket.Shoot();
               
            }
            if (e.KeyCode == Keys.R)
            {
                _cartridge.Reload();
            }

        }
        /// A function that checks the number of points and sets the current level of the game
        public void GameLevelSetup()
        {
            if (_pointsToBeatLevel <= _player._points)
            {
                if (_gameLevel < 10)
                { 
                    _randomOfAppear -= 2;
                    _pointsToBeatLevel *= 1.6f;
                    _gameLevel++;
                }
            }
        }
        // BulletMovemnt Function  a function that is responsible for moving objects of the bullet class and checking for collisions
        public void BulletMovment()
        {
            for (int i = 0; i < _cartridge._CartridgeList.Count; i++)
            {
                var bullet = _cartridge._CartridgeList[i];
                CollisonDetectionForBullet(bullet);
                if (_isAsteroidDelete)
                {
                    _asteroidList.RemoveAt(_asteroidToDelete);
                    _isAsteroidDelete = false;
                    _player._points += 4;
                }
                if (bullet.y > 0)
                {
                    bullet.Move();
                }
                else

                    _cartridge._CartridgeList.Remove(bullet);
            }
        }
        public void AsteroidMovment()
        {
            for (int i = 0; i < _asteroidList.Count; i++)
            {
                var asteroid = _asteroidList[i];

                if (asteroid.y < 800)
                {
                    asteroid.Move();
                }
                else
                {
                    _player._lifes--;

                    _asteroidList.Remove(asteroid);
                }
            }
        }

        public void MakeAsteroid()
        {
            if (_random.Next(100) > _randomOfAppear)
            {
                Asteroid asteroid = new Asteroid();
                _asteroidList.Add(asteroid);
     
            }
        }
        // Base colissionDetection that checking if objects from bullet and asteroid class has the Collision
        public void CollisonDetectionForBullet(Bullet bullet)
        {
            var index = 0;

            foreach (var asteroid in _asteroidList)
            {
                if (Math.Sqrt(Math.Pow((bullet.x - asteroid.x), 2) + Math.Pow((bullet.y - asteroid.y), 2)) <= asteroid.radius)
                {
                    _cartridge._CartridgeList.Remove(bullet);
                    _asteroidToDelete = index;
                    _isAsteroidDelete = true;
                    break;

                }
                index++;

            }

        }
       public void ShowStatistic(Label points,Label ammo, Label Lifes,Label level)
        {
            points.Text = ($"Points:{_player._points}");
            ammo.Text = ($"Ammo:{_cartridge._amount}");
            Lifes.Text = ($"Lifes:{_player._lifes}");
            level.Text = ($"Level {_gameLevel}");
        }

       public bool isGameOver()
        {
            if (_player._lifes < 1)
            {
                string points = _player._points.ToString();
                
                _scoreboard.AddToScoreboard(_putNicknameForm._playerNickname,points);
                return true;
            }
            else return false;
        }
    }
}
