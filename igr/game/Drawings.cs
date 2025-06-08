using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public  class Money
    {
        public Image img= Image.FromFile("E:\\igr\\money\\mon.png".Trim());
        public Size size=new Size(40,40);
        public Point position;
        public bool flagMoney=true;

        public Money(Point pos)
        {
            position = pos;
        }

    }

    public class Wall
    {
        public Point position;

        public Image img;
        public Size size;
        public Wall(Point point, Size size)
        {
            position = point;
            img = Image.FromFile("E:\\igr\\k1.png".Trim());
            this.size = size;
        }
    }

}
