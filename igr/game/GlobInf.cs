using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace game
{
    public static class GlobPath
    {
        public static  int witchLevel;
        public static Form hide2;
        public static Form hide1;
        // player
        public static Image playerStatic = Image.FromFile("E:\\igr\\path\\PLAYER\\0.png");
        public static Image playerDinamic1 = Image.FromFile("E:\\igr\\path\\PLAYER\\1.png");
        public static Image playerDinamic2 = Image.FromFile("E:\\igr\\path\\PLAYER\\2.png");
        public static Image playerDinamic3 = Image.FromFile("E:\\igr\\path\\PLAYER\\3.png");




        public static List<Image> listImgPlayerDinamic = new List<Image>() { playerStatic, playerDinamic1, playerDinamic2, playerDinamic3 };

        //файлы для головы препода
        public static string path_fonNew = "E:\\igr\\path\\FON\\fonNew.jpg".Trim();
        public static string path_fon = "E:\\igr\\path\\FON\\fon.jpg".Trim();

        //файлы для кастомных кнопок
        public static string butt = "E:\\igr\\path\\KEY\\k.png".Trim();
        public static string buttTrue = "E:\\igr\\path\\KEY\\kTrue.png".Trim();
        public static string buttFalse = "E:\\igr\\path\\KEY\\kFalse.png".Trim();

        //файл в вопросами 
        public static string quesiensFile = "E:\\igr\\path\\q.txt".Trim();

        //файл телефона
        public static string path_phone = "E:\\igr\\path\\phone.png".Trim();

    }
}
