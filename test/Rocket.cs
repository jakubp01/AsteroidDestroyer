using System.Drawing;

namespace test
{
    internal class Rocket : GameObject
    {

        Image _rocketImage;
        Cartridge _cartridge;
        int _x = 320;
        int _y = 650;
        Configuration _configuration;

        public delegate void RocketMove();

        public Rocket(Cartridge cartridge)
        {
            _rocketImage = Image.FromFile(@"Items\rocketWbg.png");
            this.x = _x;
            this.y = _y;
            // Implement a Conifiguration class that include a properties for this class
            _configuration = Configuration.Get();
            _cartridge = cartridge;

        }
        protected override void DrawObject(Graphics g)
        {


            g.ScaleTransform(0.3f, 0.3f);
            g.DrawImage(_rocketImage, -_rocketImage.Width / 2, -_rocketImage.Height / 2);
            // g.DrawEllipse(Pens.Red, -200, -200, 400, 400);
        }

        public void Move(string side)
        {
            if (side == "left")
            {
                if (x > _configuration._windowLeftBorder)
                {
                    x -= _configuration._rocketSpeed;
                }
            }
            else
                if (x < _configuration._windowRightBorder)
            {
                x += _configuration._rocketSpeed;
            }
        }
        public void Shoot()
        {
            if (_cartridge._amount > 0)
            {
                Bullet bullet = new Bullet(x, y - 50);
                _cartridge._CartridgeList.Add(bullet);
                _cartridge._amount--;

            }

        }

    }
}
