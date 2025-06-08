using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{


    public class Run
    {
        //Выбор направление 
        public HashSet<Keys> pressedKeys = new HashSet<Keys>();

        // положение 
        public Point position;
        // Скорость 
        private int speedGo = 10;
        public void Move(Size size)
        {
            // Определяем направление движения
            bool moveRight = pressedKeys.Contains(Keys.D) && position.X < size.Height;
            bool moveLeft = pressedKeys.Contains(Keys.A) && position.X > 0;
            bool moveUp = pressedKeys.Contains(Keys.W) && position.Y > 0;
            bool moveDown = pressedKeys.Contains(Keys.S) && position.Y < size.Width-109;

            // Вычисляем перемещение
            float moveX = 0, moveY = 0;

            if (moveRight) moveX += speedGo;
            if (moveLeft) moveX -= speedGo;
            if (moveUp) moveY -= speedGo;
            if (moveDown) moveY += speedGo;

            // Применяем движение
            position.X += (int)moveX;
            position.Y += (int)moveY;

            // Корректируем позицию, если вышли за границы
            position.X = Math.Max(0, Math.Min(size.Height, position.X));
            position.Y = Math.Max(0, Math.Min(size.Width-109, position.Y));
        }   
    }
}
