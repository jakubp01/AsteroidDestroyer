using System.Drawing;

namespace test
{
    public class Bullet : GameObject
    {
        Image _img;
        public int _bulletSpeed { get; set; }


        public Bullet(float locationX, float locationY)
        {
            _bulletSpeed = 5;
            _img = Image.FromFile(@"Items\blt.png");
            x = locationX;
            y = locationY;

        }
        protected override void DrawObject(Graphics g)
        {

            g.ScaleTransform(0.2f, 0.2f);
            g.DrawImage(_img, -_img.Width / 2, -_img.Height / 2);
            // g.DrawRectangle(Pens.Red, -_img.Width / 2, -_img.Height / 2, 200, 200);
        }




    }
}
