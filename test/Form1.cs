using System;
using System.Windows.Forms;

namespace test
{
    public partial class GameForm : Form
    {
        Game _game;
        StatisticService _statisticService;

        public GameForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackToMenubtn.Hide();
            _game = new Game();
            _statisticService = new StatisticService(pointsLabel, ammoLabel, LifesCounterLabel, LevelLabel);


        }

        private async void moveTimer_Tick(object sender, EventArgs e)
        {
            if (_game._putNicknameForm.isOpen)
            {

            }
            else
            {
                if (_game.isGameOver())
                {
                    BackToMenubtn.Show();
                    moveTimer.Stop();
                }

                _statisticService.ShowStatistic(_game._player, _game._gameLevel, _game._cartridge);
                _game.GameLevelSetup();
                await _game.MakeAsteroid();
                await _game.BulletsMovment();
                await _game.AsteroidsMovment();


                Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            _game.DrawwingObjects(e);
        }

        private async void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            await _game.RocketControl(e);
        }

        private void BackToMenubtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
