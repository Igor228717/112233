using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{

    public class LevelDemo
    {


        //Пули
        public List<int> listBullet = new List<int>() { 0, 0, 0, 0, 0 };
        public List<Bullet> lBullet = new List<Bullet>() { };
        //Стены
        public List<Wall> listwall;
        //Монеты
        public List<Money> listMoney;
        // Враги
        public List<Vrag> listVrag;


        public void Vrag_Paint(object sender, PaintEventArgs e)
        {
            foreach (var item in listVrag)
            {
                item.Vrag_Paint(sender, e);
            }
        }
        public void Vrag_UpDate(Form form, PictureBox map, PlayerRun player)
        {
            foreach (var item in listVrag)
            {
                item.Update(form, map, player);
            }
        }
        public void Wall_Paint(object sender, PaintEventArgs e)
        {
            foreach (var item in listwall)
            {
                e.Graphics.DrawImage(item.img, item.position.X, item.position.Y, item.size.Width, item.size.Height);
            }
        }
        public void Money_Paint(object sender, PaintEventArgs e)
        {
            foreach (var item in listMoney)
            {
                if (item.flagMoney == true)
                {
                    e.Graphics.DrawImage(item.img, item.position.X, item.position.Y, item.size.Width, item.size.Height);
                }
            }
        }
    }


    public class Level2 : LevelDemo
    {
        public Level2()
        {
            // Стены
            listwall = new List<Wall>()
            {
              // 1 - справа сверху
              new Wall(new Point(400, 100), new Size(40, 100)),
              new Wall(new Point(500, 100), new Size(50, 50)),// правая стена 
              new Wall(new Point(430, 70), new Size(100, 40)),//  крышк
              //
              new Wall(new Point(50,0), new Size(40, 100)),
              // 3- две горизонтальные стены
              new Wall(new Point(300, 300), new Size(100, 40)),
              new Wall(new Point(300, 400), new Size(100, 40)),
              //
              new Wall(new Point(200, 500), new Size(50, 50)),
              new Wall(new Point(100, 500), new Size(50, 50)),
              new Wall(new Point(500, 200), new Size(40, 40)),
              new Wall(new Point(300, 300), new Size(100, 40)),
              new Wall(new Point(300, 300), new Size(100, 40))
            };
            // Враги
            listVrag = new List<Vrag>()
            {
              new Vrag(350, 70),
              new Vrag(60, 400),
              new Vrag(100, 100),
              new Vrag(400, 600),
              new Vrag(222, 333),
            };
            // монеты
            listMoney = new List<Money>
            {
              //1
              new Money(new Point(445, 110)),
              //2
              new Money(new Point(10, 15)),
              new Money(new Point(150, 500)),
              new Money(new Point(330, 350)),
              new Money(new Point(100, 330)),
            };
        }
    }

    public class Level1 : LevelDemo
    {
        public Level1()
        {
            // Стены
            listwall = new List<Wall>()
            {             
              new Wall(new Point(350 + 40, 70 - 40), new Size(40, 100)),
              new Wall(new Point(340 + 40, 140 - 40), new Size(50, 50)),
              new Wall(new Point(280 + 40, 170 - 40), new Size(100, 40)),
              new Wall(new Point(130 + 30, 350 - 45), new Size(40, 100)),
              new Wall(new Point(70 + 30, 420 - 45), new Size(100, 40)),
             };
            // Враги
            listVrag = new List<Vrag>()
            {
                new Vrag(350, 70),
                new Vrag(60, 400),
            };
            // монеты
            listMoney = new List<Money> 
            {          
               new Money(new Point(350, 70)),
               new Money(new Point(100, 330)),
            };
        }
    }



}
