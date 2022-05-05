using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{

    internal class Game
    {

        int _randomOfAppear;
        bool _isAsteroidDelete = false;
        public Player _player;
        public int _gameLevel;
        int _asteroidToDelete;
        float _pointsToBeatLevel;
        int _bottonBorder;
        int _skyBorder;
        Rocket _rocket;
        public Cartridge _cartridge;
        List<Asteroid> _asteroidList;
        public PutNicknameForm _putNicknameForm;
        Scoreboard _scoreboard;
        Configuration _configuration;
        GameSetupService _gameLevelSetup;
        RocketMoveService _rocketMoveService;
        CollisionDetectionService _collisionDetectionService;
        AsteroidsService _asteroidsService;
        BulletsService _bulletsService;




        public Game()
        {
            _configuration = Configuration.Get();
            GameSetup();


        }

        public void DrawwingObjects(PaintEventArgs e)
        {
            _bulletsService.DrawingBullets(e, _cartridge);
            _asteroidsService.DrawingAsteroid(e, _asteroidList);
            _rocket.Draw(e.Graphics);
        }

        public async Task RocketControl(KeyEventArgs e)
        {
            await Task.Run(() => _rocketMoveService.Rocketmove(e));
        }

        public void GameLevelSetup()
        {
            _gameLevelSetup.Setup(_pointsToBeatLevel, _player._points, _randomOfAppear, _gameLevel);
        }

        public async Task BulletsMovment()
        {
            await Task.Run(() => _bulletsService.BulletsMovment(_cartridge, _collisionDetectionService, _asteroidList, _player, _skyBorder));

        }

        public async Task AsteroidsMovment()
        {
            await Task.Run(() => _asteroidsService.AsteroidsMovment(_bottonBorder, _player));

        }

        public async Task MakeAsteroid()
        {
            await Task.Run(() => _asteroidsService.MakeAsteroid());

        }

        public bool isGameOver()
        {
            if (_gameLevelSetup.isGameOver(_scoreboard, _player, _putNicknameForm))
            {
                return true;
            }
            else
                return false;
        }

        public void GameSetup()
        {
            _putNicknameForm = new PutNicknameForm();
            _putNicknameForm.Show();
            _scoreboard = new Scoreboard();
            _randomOfAppear = 96;
            _cartridge = new Cartridge();
            _asteroidList = new List<Asteroid>();
            _rocket = new Rocket(_cartridge);
            _player = new Player();
            _pointsToBeatLevel = 40;
            _gameLevel = 0;
            _skyBorder = _configuration._skyBorder;
            _bottonBorder = _configuration._bottonBorder;
            _gameLevelSetup = new GameSetupService();
            _rocketMoveService = new RocketMoveService(_rocket, _cartridge);
            _collisionDetectionService = new CollisionDetectionService(_cartridge, _asteroidList, Asteroid.radius, _isAsteroidDelete, _asteroidToDelete);
            _asteroidsService = new AsteroidsService(_asteroidList, _randomOfAppear);
            _bulletsService = new BulletsService();


        }
    }
}
