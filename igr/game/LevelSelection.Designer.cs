namespace game
{
    partial class LevelSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelSelection));
            this.map = new System.Windows.Forms.PictureBox();
            this.level1 = new System.Windows.Forms.Button();
            this.level2 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Image = ((System.Drawing.Image)(resources.GetObject("map.Image")));
            this.map.Location = new System.Drawing.Point(-75, -5);
            this.map.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(1481, 756);
            this.map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.map.TabIndex = 0;
            this.map.TabStop = false;
            this.map.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // level1
            // 
            this.level1.BackColor = System.Drawing.Color.DarkGreen;
            this.level1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.level1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.level1.Location = new System.Drawing.Point(280, 360);
            this.level1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(156, 32);
            this.level1.TabIndex = 1;
            this.level1.Text = "Играть";
            this.level1.UseVisualStyleBackColor = false;
            this.level1.Click += new System.EventHandler(this.level1_Click);
            // 
            // level2
            // 
            this.level2.BackColor = System.Drawing.Color.DarkGreen;
            this.level2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.level2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.level2.Location = new System.Drawing.Point(852, 360);
            this.level2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(156, 32);
            this.level2.TabIndex = 3;
            this.level2.Text = "Играть";
            this.level2.UseVisualStyleBackColor = false;
            this.level2.Click += new System.EventHandler(this.level2_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(1226, -5);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(171, 118);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 21;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // LevelSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 708);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.level2);
            this.Controls.Add(this.level1);
            this.Controls.Add(this.map);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(450, 450);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LevelSelection";
            this.Text = "LevelSelection";
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox map;
        private System.Windows.Forms.Button level1;
        private System.Windows.Forms.Button level2;
        private System.Windows.Forms.PictureBox exit;
    }
}