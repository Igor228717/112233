namespace game
{
    partial class gameRun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameRun));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.map = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.countMoney = new System.Windows.Forms.Label();
            this.door = new System.Windows.Forms.Panel();
            this.textWin = new System.Windows.Forms.Label();
            this.textFail = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Label();
            this.CountBullet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.map.Image = ((System.Drawing.Image)(resources.GetObject("map.Image")));
            this.map.Location = new System.Drawing.Point(320, 164);
            this.map.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(705, 585);
            this.map.TabIndex = 0;
            this.map.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(423, 82);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(533, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 54);
            this.label3.TabIndex = 8;
            this.label3.Text = "-";
            // 
            // countMoney
            // 
            this.countMoney.AutoSize = true;
            this.countMoney.BackColor = System.Drawing.Color.Transparent;
            this.countMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countMoney.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.countMoney.Location = new System.Drawing.Point(567, 97);
            this.countMoney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countMoney.Name = "countMoney";
            this.countMoney.Size = new System.Drawing.Size(49, 54);
            this.countMoney.TabIndex = 9;
            this.countMoney.Text = "0";
            // 
            // door
            // 
            this.door.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.door.Location = new System.Drawing.Point(1007, 609);
            this.door.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(19, 139);
            this.door.TabIndex = 12;
            // 
            // textWin
            // 
            this.textWin.AutoSize = true;
            this.textWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textWin.ForeColor = System.Drawing.Color.Black;
            this.textWin.Location = new System.Drawing.Point(345, 396);
            this.textWin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textWin.Name = "textWin";
            this.textWin.Size = new System.Drawing.Size(602, 135);
            this.textWin.TabIndex = 13;
            this.textWin.Text = "ПОБЕДА!";
            this.textWin.Visible = false;
            // 
            // textFail
            // 
            this.textFail.AutoSize = true;
            this.textFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textFail.ForeColor = System.Drawing.Color.Black;
            this.textFail.Location = new System.Drawing.Point(457, 427);
            this.textFail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textFail.Name = "textFail";
            this.textFail.Size = new System.Drawing.Size(382, 69);
            this.textFail.TabIndex = 14;
            this.textFail.Text = "ПРОИГРЫШ";
            this.textFail.Visible = false;
            this.textFail.Click += new System.EventHandler(this.textFail_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.AutoSize = true;
            this.buttonRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRestart.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRestart.Location = new System.Drawing.Point(551, 529);
            this.buttonRestart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(224, 69);
            this.buttonRestart.TabIndex = 15;
            this.buttonRestart.Text = "заново";
            this.buttonRestart.Visible = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // CountBullet
            // 
            this.CountBullet.AutoSize = true;
            this.CountBullet.BackColor = System.Drawing.Color.Transparent;
            this.CountBullet.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountBullet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CountBullet.Location = new System.Drawing.Point(977, 101);
            this.CountBullet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CountBullet.Name = "CountBullet";
            this.CountBullet.Size = new System.Drawing.Size(46, 52);
            this.CountBullet.TabIndex = 16;
            this.CountBullet.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(751, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 52);
            this.label4.TabIndex = 17;
            this.label4.Text = "Патроны";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(947, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 54);
            this.label5.TabIndex = 18;
            this.label5.Text = "-";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1219, -28);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(241, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // gameRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1380, 1010);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CountBullet);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.textFail);
            this.Controls.Add(this.textWin);
            this.Controls.Add(this.door);
            this.Controls.Add(this.countMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.map);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "gameRun";
            this.Text = "gameRun";
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox map;
        private System.Windows.Forms.PictureBox wall1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label countMoney;
        private System.Windows.Forms.Panel door;
        private System.Windows.Forms.Label textWin;
        private System.Windows.Forms.Label textFail;
        private System.Windows.Forms.Label buttonRestart;
        private System.Windows.Forms.Label CountBullet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}