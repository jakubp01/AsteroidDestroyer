using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public abstract class GameObject
    {
        public float x, y;
        public void Draw(Graphics g)
        {
            var m = g.Transform;
            g.TranslateTransform(x, y);
            DrawObject(g);
            g.Transform = m;
        }
        protected abstract void DrawObject(Graphics g);
    }
}
