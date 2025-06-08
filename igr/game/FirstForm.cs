using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static game.MyButton;

namespace game
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.BackgroundImage = Image.FromFile("E:\\igr\\jpg.jpg".Trim());
            ButtonFirstForm butt2 = new ButtonFirstForm(this, 2);
            butt2.AddButton(this);

            ButtonFirstForm butt3 = new ButtonFirstForm(this, 3);
            butt3.AddButton(this);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RULES_Click(object sender, EventArgs e)
        {

        }
    }
}
