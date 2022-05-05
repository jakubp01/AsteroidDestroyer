using System;
using System.Drawing;

namespace test
{
    public class Asteroid : GameObject
    {
        public static int radius = 40;
        Random random = new Random();
        Image _img;
        public int _rotate;
        public int _asteroidSpeed;

        public Asteroid()
        {

            _img = Image.FromFile(@"Items\asteroid.png");
            this.y = 5;
            this.x = random.Next(620);
            _rotate = random.Next(360);

            _asteroidSpeed = random.Next(8, 16);

        }

        protected override void DrawObject(Graphics g)
        {
            g.RotateTransform(_rotate);
            g.ScaleTransform(0.2f, 0.2f);
            g.DrawImage(_img, -_img.Width / 2, -_img.Height / 2);
            //g.DrawEllipse(Pens.Red, -_img.Width / 2 ,- _img.Height / 2,  400, 400);
        }



    }
}