using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace game
{
    public partial class gameRun : Form
    {


        LevelDemo level;
        //игрок
        PlayerRun player;

        // Emeny
        Enemy enemy;

        //Стены
        Wall wall_1;
        Wall wall_2;
        Wall wall_3;
        Wall wall_4;
        Wall wall_5;
        public List<Wall> listwall;

        //Пули
        List<int> listBullet;
        List<Bullet> lBullet;


        //Монеты
        Image money1;
        Image money2;
        bool flagMoney1;
        bool flagMoney2;
        public List<bool> listMoney;

        //Враги
        Vrag vrag1;
        Vrag vrag2;
        public List<Vrag> listVrag;

        // кусты
        Image bush;
        bool flagBush;

        // кнопка выход
        ButtonExit exitBut;
        public gameRun()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            if (GlobPath.witchLevel == 1)
            {
                level = new Level1();
            }
            else
            {
                level = new Level2();
                map.Size = new Size(700,650);
                map.Location = new Point(map.Location.X-50,map.Location.Y);
                door.Location = new Point(970-85, 600);
                textWin.Location =  new Point(350,350);
                textFail.Location = new Point(450, 350);
                textFail.Text = "ПРОИГРЫШ";
                this.Location = new Point(this.Location.X,this.Location.Y-200);
                buttonRestart.Location = new Point(500, 400);
            }
            //настройка таймера
            timer1.Interval = 60;
            timer1.Start();
            timer1.Tick += Timer1_Tick;
            //игрок
            player = new PlayerRun(this, map, level.listBullet, level.lBullet);
            //enemy
            enemy = new Enemy(player.position);
            // Нажатие клавиш
            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;
            map.MouseClick += Form1_MouseClick;
            // Отрисовка
            map.Paint += player.Player_Paint;
            map.Paint += level.Money_Paint;
            map.Paint += level.Wall_Paint;
            map.Paint += enemy.Enemy_Paint;
            map.Paint += level.Vrag_Paint;
            map.Paint += player.Bullet_Paint;
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            player.Fire(e.Location);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            player.GoMetod(this, map, pressedKeys);
            CheckTouch();
            CollectingMoney();
            CheckWin();
            Fail();
            CheckCountBullet();
            CheckHitBullet();
            player.Bullet_Update();
            enemy.Update(player.position);
            level.Vrag_UpDate(this, map, player);
            //перерисовка 
            //this.Invalidate();
            map.Invalidate();
        }
        public void Fail()
        {
            CheckVragTouch();
            CheckEnemyTouch(player, enemy);

        }
        private void CheckEnemyTouch(PlayerRun player, Enemy enemy)
        {
            Rectangle playerRec = CreateRectengle(player);
            Rectangle enemyRec = CreateRectengle(enemy);
            if (playerRec.IntersectsWith(enemyRec)) { EndGame(); }
        }

        public void EndGame()
        {
            timer1.Stop();
            textFail.Visible = true;
            buttonRestart.Visible = true;
        }

        private void CheckHitBullet()
        { 
            foreach (var item in player.dictBullet)
            {
                Bullet _b = item.Key;
                int _int = item.Value;
                Rectangle BulletRect = new Rectangle((int)_b.position.X, (int)_b.position.Y, 60, 70);

                // Преобразуем координаты игрока в систему координат формы
                BulletRect = map.RectangleToScreen(BulletRect);
                BulletRect = this.RectangleToClient(BulletRect);

                foreach (var vrag in level.listVrag)
                {
                    Rectangle vragRec = CreateRectengle(vrag);
                    if (BulletRect.IntersectsWith(vragRec) && _b.paintFlag==true)
                    {
                        vrag.flagVrag = false;
                        _b.paintFlag = false;
                    }
                }
                foreach (var wall in level.listwall)
                {
                    Rectangle wallRec = CreateRectengle(wall);
                    if (BulletRect.IntersectsWith(wallRec)) { _b.paintFlag = false; }
                }
            }

        }

        private void CheckCountBullet()
        {
            CountBullet.Text = (5 - player.dictBullet.Count).ToString();
            var bulletsToRemove = new List<Bullet>();
            foreach (var item in player.dictBullet)
            {
                Bullet _b = item.Key;
                int _int = item.Value;
                if (_int != 0)
                {
                    player.dictBullet[_b] -= 1;
                    break;
                }
                else
                {
                    bulletsToRemove.Add(_b);
                }
            }

            if (bulletsToRemove.Count != 0)
            {
                player.dictBullet.Remove(bulletsToRemove[0]);
                bulletsToRemove.RemoveAt(0);
            }
        }

        private void CheckVragTouch()
        {
            Rectangle playerRect = CreateRectengle(player);
            foreach (var item in level.listVrag)
            {
                Rectangle vragRect = CreateRectengle(item);
                if (playerRect.IntersectsWith(vragRect)) { EndGame(); }
            }
        }

        private void CheckWin()
        {
            Rectangle playerRect = CreateRectengle(player);
            Rectangle dorrRect = door.Bounds;
            dorrRect = this.RectangleToClient(door.Parent.RectangleToScreen(dorrRect));

            if (int.Parse(countMoney.Text) == level.listMoney.Count && playerRect.IntersectsWith(dorrRect))
            {
                timer1.Stop();
                textWin.Visible = true;
            }
        }
        public Rectangle CreateRectengle(dynamic player)
        {
            Rectangle playerRect = new Rectangle( (int)player.position.X,(int)player.position.Y,player.size.Width,player.size.Height);
            // Преобразуем координаты игрока в систему координат формы
            playerRect = map.RectangleToScreen(playerRect);
            playerRect = this.RectangleToClient(playerRect);
            return playerRect;
        }

        private void CheckTouch()
        {
            Rectangle playerRect = CreateRectengle(player);

            // игрок и стены 
            foreach (var wall in level.listwall)
            {
                Rectangle wallRect = CreateRectengle(wall);

                if (playerRect.IntersectsWith(wallRect))
                {
                    GetCollisionSide(player, playerRect, wallRect);
                }
            }

            // враг и стена 
            foreach (var vrag in level.listVrag)
            {
                foreach (var wall in level.listwall)
                {
                    Rectangle wallRect = CreateRectengle(wall);
                    Rectangle vragRect = CreateRectengle(vrag);

                    if (vragRect.IntersectsWith(wallRect))
                    {
                        GetCollisionSide(vrag, vragRect, wallRect);
                    }
                }
            }

        }
        public void CollectingMoney()
        {
            // облатсь игрока
            Rectangle playerRect = new Rectangle((int)player.position.X, (int)player.position.Y, 60, 70);

            playerRect = map.RectangleToScreen(playerRect);
            playerRect = this.RectangleToClient(playerRect);

            foreach (var item in level.listMoney)
            {
                if (item.flagMoney)
                {
                    Rectangle moneyRect1 = new Rectangle(item.position.X,item.position.Y,item.size.Width,item.size.Height);
                    moneyRect1 = this.RectangleToClient(map.RectangleToScreen(moneyRect1));

                    if (playerRect.IntersectsWith(moneyRect1))
                    {
                        item.flagMoney = false;
                        countMoney.Text = (int.Parse(countMoney.Text) + 1).ToString();
                    }

                }
            }

        }

        public void GetCollisionSide(Run _p, Rectangle playerRect, Rectangle wallRect)
        {
            int left = playerRect.Right - wallRect.Left;
            int right = wallRect.Right - playerRect.Left;
            int top = playerRect.Bottom - wallRect.Top;
            int bottom = wallRect.Bottom - playerRect.Top;

            int mintuch = Math.Min(Math.Min(left, right), Math.Min(top, bottom));

            if (mintuch == left)_p.position.X -= 10; 
            else if (mintuch == right) _p.position.X += 10; 
            else if (mintuch == top) _p.position.Y -= 10; 
            else if (mintuch == bottom) _p.position.Y += 10; 
        }




        //Отслеживание нажания клавиш
        private HashSet<Keys> pressedKeys = new HashSet<Keys>();
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.A || e.KeyCode == Keys.W || e.KeyCode == Keys.S)
            {
                player.flagGo = true;
                pressedKeys.Add(e.KeyCode);
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.A || e.KeyCode == Keys.W || e.KeyCode == Keys.S)
            {
                pressedKeys.Remove(e.KeyCode);
                if (pressedKeys.Count == 0) { player.flagGo = false; }
            }
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            var newGame = new gameRun();
            this.Hide();
            newGame.ShowDialog();
            this.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GlobPath.hide1.Show();
            this.Close();
        }

        private void textFail_Click(object sender, EventArgs e)
        {

        }
    }
}
