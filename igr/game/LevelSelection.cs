using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class LevelSelection : Form
    {
        public LevelSelection()
        {
            InitializeComponent();


            exit.Parent = map;
            exit.Location = new Point(80, 10);
            exit.Click += Exit_Click;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void level1_Click(object sender, EventArgs e)
        {
            GlobPath.hide1 = this;
            GlobPath.hide1.Hide(); 

            GlobPath.witchLevel = 1;
            Form m = new gameRun();          
            m.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e){}

        private void level2_Click(object sender, EventArgs e)
        {
            GlobPath.witchLevel = 2;
            Form m = new gameRun();
            m.ShowDialog();
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            GlobPath.hide2.Show();
        }
    }
}
