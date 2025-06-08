using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static game.Bullet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace game
{

    public class Enemy
    {
        public Image img;
        public Size size = new Size(70, 70);
        public float Speed = 4f; //скорость
        public PointF position = new PointF(0, 0);
        public PointF target;

        Queue<PointF> que = new Queue<PointF>();
        float sumQueX = 0;
        float sumQueY = 0;
        int windowSize = 5;

        public Enemy(PointF playerPosition)
        {
            img = Image.FromFile("E:\\igr\\ggost.png".Trim());
            target = playerPosition;
        }

        public void Update(PointF playerPosition)
        {
            VectorSearch(playerPosition);
            Move(); 
        }

        public void Move()
        {
            float dx = target.X - position.X;
            float dy = target.Y - position.Y;
            float distanceSquared = dx * dx + dy * dy;

            if (distanceSquared < 0.01f) return; // Почти на месте

            float distance = (float)Math.Sqrt(distanceSquared);
            PointF direction = distance > 0.0001f
                ? new PointF(dx / distance, dy / distance)
                : new PointF(0, 0);

            position.X += direction.X * Speed;
            position.Y += direction.Y * Speed;
        }

        private void VectorSearch(PointF playerPosition)
        {
            if (que.Count >= windowSize)
            {
                PointF old = que.Dequeue();
                sumQueX -= old.X;
                sumQueY -= old.Y;
            }
            que.Enqueue(playerPosition);
            sumQueX += playerPosition.X;
            sumQueY += playerPosition.Y;

            target = que.Count > 0
                ? new PointF(sumQueX / que.Count, sumQueY / que.Count)
                : playerPosition;
        }
        public void Enemy_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(
                img,
                position.X,
                position.Y,
                size.Width,
                size.Height);
        }
    }

    public class Vrag:Run
    {
        // таймер
        public Size size = new Size(50, 50);
        public int timer = 0;
        public const int maxTimer = 900;
        public List<Keys> possibleDirections = new List<Keys>() { Keys.D, Keys.S, Keys.A, Keys.W };
        public Random rnd = new Random();
        public PlayerRun player;
        Image img;
        public bool flagVrag = true;

        public Vrag(int x,int y)
        {
            position.X=x;position.Y=y;
            img= Image.FromFile("E:\\igr\\vrag\\vrag.png".Trim());
        }

        public void Update(Form form, PictureBox map, PlayerRun player)
        {
            if (timer < maxTimer)
            {
                timer++;
                ChekingDirection();
                if (flagVrag) Move(map.Size);
                else
                {
                    position = new Point(-50, -50);
                }  
            }
            else
            {
                pressedKeys.Clear();
                timer = 0;
            }
           
        }

        // проверка направления
        public void  ChekingDirection() 
        {
            if (pressedKeys.Count == 0 || rnd.Next(100) < 20)
            {
                int rndInt;

                pressedKeys.Clear();
                if (player != null)
                {
                    rndInt = Math.Abs(rnd.Next(possibleDirections.Count) * (player.position.X - position.X)) % 4;
                }
                else
                {
                    rndInt = rnd.Next(possibleDirections.Count);
                }
                pressedKeys.Add(possibleDirections[rndInt]);
            }
        }


        public  void Vrag_Paint(object sender, PaintEventArgs e)
        {
            if (flagVrag)
            {
                e.Graphics.DrawImage(img, position.X, position.Y,40,40);
            }
        }


    }
}
