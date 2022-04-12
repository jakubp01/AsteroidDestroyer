using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Rocket:GameObject
    {
        
        Image _rocketImage;
        Cartridge _cartridge;
        int _x=320;
        int _y = 650;
        public Rocket(Cartridge cartridge)
        {
            _rocketImage = Image.FromFile(@"C:\Users\jakub\Desktop\Projekty\WF\test\test\Items\rocketWbg.png");
            this.x = _x ;
            this.y = _y;
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
            if (side == "right")
            {
                x += 12;
            }
            else
                x -= 12;
        }
        public void Shoot()
        {
            if (_cartridge._amount > 0)
            {
                Bullet bullet = new Bullet(x, y -50);
                _cartridge._CartridgeList.Add(bullet);
                _cartridge._amount--;
                
            }

        }
        
    }
}
