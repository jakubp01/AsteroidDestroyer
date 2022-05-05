using System;
using System.Windows.Forms;

namespace test
{
    public partial class Scoreboard : Form
    {
        public Scoreboard()
        {
            InitializeComponent();
        }

        private void Scoreboard_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'scoreboardDbDataSet.ScoreboardDb' . Możesz go przenieść lub usunąć.
            this.scoreboardDbTableAdapter.FillBy(this.scoreboardDbDataSet.ScoreboardDb);

        }

        public void AddToScoreboard(string nick, string score)
        {
            this.scoreboardDbTableAdapter.InsertPlayer(nick, score);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
