namespace SavageRacer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.labelLose = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.labelEasy = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelNormal = new System.Windows.Forms.Label();
            this.labelHard = new System.Windows.Forms.Label();
            this.labelDevil = new System.Windows.Forms.Label();
            this.coins = new System.Windows.Forms.PictureBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelWin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coins)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(840, 650);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(455, 486);
            this.player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 150);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, -650);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(840, 650);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Transparent;
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(587, -185);
            this.enemy1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(100, 153);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 3;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Transparent;
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(180, -308);
            this.enemy2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(95, 156);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 4;
            this.enemy2.TabStop = false;
            this.enemy2.Click += new System.EventHandler(this.enemy2_Click);
            // 
            // labelLose
            // 
            this.labelLose.AutoSize = true;
            this.labelLose.BackColor = System.Drawing.Color.Gold;
            this.labelLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLose.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLose.ForeColor = System.Drawing.Color.DarkRed;
            this.labelLose.Location = new System.Drawing.Point(297, 199);
            this.labelLose.Name = "labelLose";
            this.labelLose.Size = new System.Drawing.Size(249, 48);
            this.labelLose.TabIndex = 6;
            this.labelLose.Text = "You lose :(";
            this.labelLose.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.Color.Gold;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestart.Font = new System.Drawing.Font("Magneto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestart.ForeColor = System.Drawing.Color.Maroon;
            this.buttonRestart.Location = new System.Drawing.Point(345, 292);
            this.buttonRestart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(172, 43);
            this.buttonRestart.TabIndex = 7;
            this.buttonRestart.Text = "Start again";
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Click += new System.EventHandler(this.button1_Click);
            // 
            // enemy3
            // 
            this.enemy3.Image = ((System.Drawing.Image)(resources.GetObject("enemy3.Image")));
            this.enemy3.Location = new System.Drawing.Point(179, -554);
            this.enemy3.Margin = new System.Windows.Forms.Padding(4);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(100, 150);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 8;
            this.enemy3.TabStop = false;
            // 
            // labelEasy
            // 
            this.labelEasy.AutoSize = true;
            this.labelEasy.BackColor = System.Drawing.Color.Gold;
            this.labelEasy.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEasy.ForeColor = System.Drawing.Color.DarkRed;
            this.labelEasy.Location = new System.Drawing.Point(7, 486);
            this.labelEasy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEasy.Name = "labelEasy";
            this.labelEasy.Size = new System.Drawing.Size(66, 25);
            this.labelEasy.TabIndex = 9;
            this.labelEasy.Text = "Easy";
            this.labelEasy.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.BackColor = System.Drawing.Color.Gold;
            this.labelLevel.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevel.ForeColor = System.Drawing.Color.DarkRed;
            this.labelLevel.Location = new System.Drawing.Point(7, 444);
            this.labelLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(108, 36);
            this.labelLevel.TabIndex = 10;
            this.labelLevel.Text = "Level";
            this.labelLevel.Click += new System.EventHandler(this.labelLevel_Click);
            // 
            // labelNormal
            // 
            this.labelNormal.AutoSize = true;
            this.labelNormal.BackColor = System.Drawing.Color.Gold;
            this.labelNormal.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNormal.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNormal.Location = new System.Drawing.Point(7, 486);
            this.labelNormal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNormal.Name = "labelNormal";
            this.labelNormal.Size = new System.Drawing.Size(93, 25);
            this.labelNormal.TabIndex = 11;
            this.labelNormal.Text = "Normal";
            // 
            // labelHard
            // 
            this.labelHard.AutoSize = true;
            this.labelHard.BackColor = System.Drawing.Color.Gold;
            this.labelHard.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHard.ForeColor = System.Drawing.Color.DarkRed;
            this.labelHard.Location = new System.Drawing.Point(7, 486);
            this.labelHard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHard.Name = "labelHard";
            this.labelHard.Size = new System.Drawing.Size(71, 25);
            this.labelHard.TabIndex = 12;
            this.labelHard.Text = "Hard";
            // 
            // labelDevil
            // 
            this.labelDevil.AutoSize = true;
            this.labelDevil.BackColor = System.Drawing.Color.Gold;
            this.labelDevil.Font = new System.Drawing.Font("Magneto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDevil.ForeColor = System.Drawing.Color.DarkRed;
            this.labelDevil.Location = new System.Drawing.Point(7, 486);
            this.labelDevil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDevil.Name = "labelDevil";
            this.labelDevil.Size = new System.Drawing.Size(233, 28);
            this.labelDevil.TabIndex = 13;
            this.labelDevil.Text = "What kinda Devil";
            // 
            // coins
            // 
            this.coins.BackColor = System.Drawing.Color.Transparent;
            this.coins.Image = ((System.Drawing.Image)(resources.GetObject("coins.Image")));
            this.coins.Location = new System.Drawing.Point(455, -431);
            this.coins.Margin = new System.Windows.Forms.Padding(4);
            this.coins.Name = "coins";
            this.coins.Size = new System.Drawing.Size(43, 39);
            this.coins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coins.TabIndex = 14;
            this.coins.TabStop = false;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Gold;
            this.labelScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelScore.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.DarkRed;
            this.labelScore.Location = new System.Drawing.Point(6, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(209, 36);
            this.labelScore.TabIndex = 15;
            this.labelScore.Text = "Score: 0/15";
            // 
            // labelWin
            // 
            this.labelWin.AutoSize = true;
            this.labelWin.BackColor = System.Drawing.Color.Gold;
            this.labelWin.Font = new System.Drawing.Font("Magneto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWin.ForeColor = System.Drawing.Color.DarkRed;
            this.labelWin.Location = new System.Drawing.Point(57, 250);
            this.labelWin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(705, 56);
            this.labelWin.TabIndex = 16;
            this.labelWin.Text = "Congratulations! You Won!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(92)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(840, 650);
            this.Controls.Add(this.labelWin);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.coins);
            this.Controls.Add(this.labelDevil);
            this.Controls.Add(this.labelHard);
            this.Controls.Add(this.labelNormal);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.labelEasy);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.labelLose);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Label labelLose;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.Label labelEasy;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelNormal;
        private System.Windows.Forms.Label labelHard;
        private System.Windows.Forms.Label labelDevil;
        private System.Windows.Forms.PictureBox coins;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelWin;
    }
}

