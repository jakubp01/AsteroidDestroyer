using System;
using System.Windows.Forms;

namespace test
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {

            Scoreboard scoreboardcs = new Scoreboard();
            scoreboardcs.Show();

        }

        private void Playbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GameForm gameForm = new GameForm();

            gameForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
