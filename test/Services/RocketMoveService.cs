using System.Windows.Forms;

namespace test
{
    internal class RocketMoveService
    {
        Rocket _rocket;
        Cartridge _cartridge;

        public RocketMoveService(Rocket rocket, Cartridge cartridge)
        {
            _rocket = rocket;
            _cartridge = cartridge;
        }

        public void Rocketmove(KeyEventArgs e)
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
    }
}
