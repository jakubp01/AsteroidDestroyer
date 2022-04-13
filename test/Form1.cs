using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class GameForm : Form
    {
        Game _game;
       
        public GameForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackToMenubtn.Hide();
            _game = new Game();
            
        }

        private void moveTimer_Tick(object sender, EventArgs e)
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
                _game.ShowStatistic(pointsLabel, ammoLabel, LifesCounterLabel,LevelLabel);
                _game.GameLevelSetup();
                _game.MakeAsteroid();
                _game.AsteroidMovment();
                _game.BulletMovment();


                Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            _game.DrawwingObjects(e);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            _game.RocketControl(e);
        }

        private void BackToMenubtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
