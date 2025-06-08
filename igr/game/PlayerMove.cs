using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static game.Bullet;


namespace game
{
    public class PlayerRun : Run
    {
        //
        public Dictionary<Bullet, int> dictBullet = new Dictionary<Bullet, int>();
        //
        public Size size = new Size(50, 50);
        public PictureBox map;

        //для отрисовки игрока
        public Image playerS;
        public List<Image> playerD;
        public Image nowPlayer;
        public int nowImg = 0;


        public PlayerRun(Form form, PictureBox pict, List<int> listBullet, List<Bullet> lBullet)
        {


            position = new Point(400, 400);
            //
            this.map = pict;
            //
            playerS = GlobPath.listImgPlayerDinamic[0];
            playerD = GlobPath.listImgPlayerDinamic;
            nowPlayer = playerS;
        }

        // go
        public Keys keyGo;
        private int speedGo = 10;
        public bool flagGo = false;

        public void Fire(Point target)
        {
            if (dictBullet.Count < 5)
            {
                dictBullet[new Bullet(position, target)] = 100;
            }
        }
        public void Bullet_Paint(object sender, PaintEventArgs e)
        {
            foreach (var item in dictBullet)
            {
                Bullet _b = item.Key;
                int _int = item.Value;
                if(_b.paintFlag) e.Graphics.DrawImage(_b.img,_b.position.X,_b.position.Y,80, 80);
            }
        }
        public void  Bullet_Update()
        {
            foreach (var item in dictBullet)
            {
                Bullet _b = item.Key;
                int _int = item.Value;
                _b.Update();
            }
        }

        public void GoMetod(Form form, PictureBox map, HashSet<Keys> pressedKeys)
        {
            this.pressedKeys = pressedKeys;
            if (flagGo)
            {
                DrawingRun();
                Move(map.Size);
            }
        }
        private void DrawingRun()
        {
            // Отрисовка бега
            if (nowImg == GlobPath.listImgPlayerDinamic.Count - 1) { nowImg = 1; }
            else { nowImg += 1; }
            nowPlayer = GlobPath.listImgPlayerDinamic[nowImg];
        }
        public void Player_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(nowPlayer, position.X, position.Y, 70, 70);
        }
    } 
}




