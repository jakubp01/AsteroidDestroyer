using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public class Asteroid : GameObject
    {
        public int radius = 40;
        Random random = new Random();
        Image _img;
        int _rotate;
        int _asteroidSpeed;
 
        public Asteroid()
        {
            
            _img = Image.FromFile(@"Items\asteroid.png");
            this.y = 5;
            this.x= random.Next(620);
            _rotate = random.Next(360);
            
            _asteroidSpeed = 8;

        }

        protected override void DrawObject(Graphics g)
        {  
           g.RotateTransform(_rotate);
            g.ScaleTransform(0.2f, 0.2f);
            g.DrawImage(_img, -_img.Width/2, -_img.Height/2);
            //g.DrawEllipse(Pens.Red, -_img.Width / 2 ,- _img.Height / 2,  400, 400);
        }

       public void Move()
        {
            _rotate += _asteroidSpeed;
            y += _asteroidSpeed;
        }
        
    }
}