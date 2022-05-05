
using System.Windows.Forms;


namespace test
{
    internal class StatisticService
    {
        Label _points;
        Label _ammo;
        Label _lifes;
        Label _level;


        public StatisticService(Label points, Label ammo, Label Lifes, Label level)
        {
            _points = points;
            _ammo = ammo;
            _lifes = Lifes;
            _level = level;
        }
        public void ShowStatistic(Player player, int gameLevel, Cartridge cartridge)
        {
            _points.Text = ($"Points:{player._points}");
            _ammo.Text = ($"Ammo:{cartridge._amount}");
            _lifes.Text = ($"Lifes:{player._lifes}");
            _level.Text = ($"Level {gameLevel}");
        }
    }
}
