using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace game
{
    public class MyButton
    {
        public PictureBox button;
        public Label label;


        public MyButton()
        {
            button = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(500, 90),
                Cursor = Cursors.Hand,
                BackColor = Color.Transparent

            };
            label = new Label()
            {
                Location = new Point(190, 30),
                BackColor = Color.Transparent,
                Font = new Font("Arial", 26, FontStyle.Bold),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

        }
        public virtual void AddButton(Control form)
        {
            form.Controls.Add(button);
            button.Controls.Add(label);
        }
    }

    public class ButtonFirstForm : MyButton
    {
        int number;
        Image imgT;
        Image imgF;
        public bool flagFofbutt2 = false;
        PictureBox pp;
        Form f;
        public ButtonFirstForm(Form form, int number) : base()
        {
            f = form;
            //pp = rules;
            this.number = number;
            // загрузка картинок
            imgT = Image.FromFile("E:\\igr\\path\\KEY\\keyFirstTrue.png".Trim());
            imgF = Image.FromFile("E:\\igr\\path\\KEY\\keyFirstFalse.png".Trim());

            // настройка кнопки 
            button.Image = imgF;
            button.Location = new Point(1000, 150 + (number * 100));
            button.Name = number.ToString();


            foreach (var item in form.Controls)
            {
                if (item is PictureBox p && p.Name == "RULES")
                {
                    pp = p;
                }
            }
            //функционал кнопок
            LabelForButt();
        }

        public void LabelForButt()
        {
            label.Click += (sender, e) => { ClickButtClear(button.Parent); };
            if (number == 3)
            {
                label.Text = "ИГРАТЬ";
                label.Click += (sender, e) =>
                {
                    GlobPath.hide2=f;
                    GlobPath.hide2.Hide();
                    Form m = new LevelSelection();
                    m.ShowDialog();
                    //Form m = new gameRun();
                    //m.ShowDialog();
                    pp.Visible = false;

                };
            }
            else if (number == 2)
            {
                label.Text = "УПРАВЛЕНИЕ";
                label.Click += (sender, e) => { pp.Visible = true; };
            }
        }
        public void ClickButtClear(Control form)
        {
            //меняется на светлый
            if (number != 3) { button.Image = imgT; }
            // остальные меняем на темные
            foreach (var item in form.Controls)
                if (item is PictureBox pictureBox && pictureBox != button && new[] { "1", "2", "3" }.Contains(pictureBox.Name)) { pictureBox.Image = imgF; }
        }

    }

    public class ButtonExit : MyButton
    {
        Image img;
        public ButtonExit(Form form) : base()
        {
            img = Image.FromFile("E:\\igr\\path\\KEY\\kFalse.png".Trim());
            button.Image = img;

            button.Location = new Point(0, 0);
            label.Font = new Font("Arial", 15, FontStyle.Bold);
            button.Size = new Size(100, 100);
            label.Text = "EXIT";
            label.Click += (sender, e) =>
            {
                form.Close();
            };
        }

    }
}
