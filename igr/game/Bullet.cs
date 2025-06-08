using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public class Bullet
    {
        public Image img = Image.FromFile("E:\\igr\\money\\b.png".Trim());
        public Point position;
        public Point target;
        private int speed = 30;
        private float dx, dy;
        public bool paintFlag = true;


        public Bullet(Point position, Point target)
        {
            this.position = position;
            this.target = target;
            CalculateDirection();
        }

        public void Update()
        {
            position.X += (int)dx;
            position.Y += (int)dy;
        }

        private void CalculateDirection()
        {
            float distance = (float)Math.Sqrt(Math.Pow(target.X - position.X, 2) + Math.Pow(target.Y - position.Y, 2));
            dx = distance > 0 ? (target.X - position.X) / distance * speed : 0;
            dy = distance > 0 ? (target.Y - position.Y) / distance * speed : 0;
        }
    }
}
