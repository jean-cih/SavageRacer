using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavageRacer
{
    public partial class Form1 : Form
    {
        private Point pos;
        private bool dragging, lose = false;
        private double countSpeed = 0;
        private int countCoins = 0;
        
        public Form1()
        {
            InitializeComponent();

            pictureBox1.MouseDown += MouseClickDown;
            pictureBox1.MouseUp += MouseClickUp;
            pictureBox1.MouseMove += MouseClickMove;

            pictureBox3.MouseDown += MouseClickDown;
            pictureBox3.MouseUp += MouseClickUp;
            pictureBox3.MouseMove += MouseClickMove;

            labelLose.Visible = false;
            buttonRestart.Visible = false;
            labelEasy.Visible = true;
            labelNormal.Visible = false;
            labelHard.Visible = false;
            labelDevil.Visible = false;
            labelWin.Visible = false;

            KeyPreview = true;
        }

        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            pos.X = e.X;
            pos.Y = e.Y;
        }
        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(currentPoint.X - pos.X, currentPoint.Y - pos.Y + pictureBox1.Top);
            }
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            countSpeed += 0.02;
            int speed;
            int enemy1Speed;
            int enemy2Speed;

            if (countSpeed < 10)
            {
                speed = 5;
                enemy1Speed = 6;
                enemy2Speed = 6;
            }
            else if(countSpeed >= 10 && countSpeed < 20)
            {
                labelEasy.Visible = false;
                labelNormal.Visible = true;
                speed = 7;
                enemy1Speed = 8;
                enemy2Speed = 8;
            }
            else if(countSpeed >= 20 && countSpeed < 30)
            {
                labelNormal.Visible = false;
                labelHard.Visible = true;
                speed = 9;
                enemy1Speed = 10;
                enemy2Speed = 10;
            }
            else
            {
                labelHard.Visible = false;
                labelDevil.Visible = true;
                speed = 12;
                enemy1Speed = 13;
                enemy2Speed = 13;
            }

            pictureBox1.Top += speed; //Смещение
            pictureBox3.Top += speed;

            enemy1.Top += enemy1Speed;
            enemy2.Top += enemy2Speed;

            coins.Top += speed;

            if (player.Bounds.IntersectsWith(coins.Bounds))
            {
                countCoins++;
                labelScore.Text = "Score: " + countCoins.ToString() + "/15";
                if(countCoins == 15)
                {
                    labelWin.Visible = true;
                    timer.Enabled = false;
                }
                coins.Top = -150;
                Random rand = new Random();
                coins.Left = rand.Next(135, 440);

            }

            if(coins.Top >= 528)
            {
                coins.Top = -350;
                Random rand = new Random();
                coins.Left = rand.Next(135, 440);
            }

            if(pictureBox1.Top >= 528)
            {
                player.Top = 395;
                pictureBox1.Top = -528;
            }

            if (pictureBox3.Top >= 528)
            {
                pictureBox3.Top = -528;
            }

            if (enemy1.Top >= 650)//Синяя тачка
            {
                enemy1.Top = -150;
                Random rand = new Random();
                enemy1.Left = rand.Next(135, 440);

            }

            if (enemy2.Top >= 650)//Серая тачка
            {
                enemy2.Top = -170;

                if (enemy1.Left > 300)
                {
                    Random random = new Random();
                    enemy2.Left = random.Next(135, 250);
                }
                else
                {
                    Random random = new Random();
                    enemy2.Left = random.Next(350, 440);
                }
            }

            if (player.Bounds.IntersectsWith(enemy1.Bounds) || player.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer.Enabled = false;
                labelLose.Visible = true;
                buttonRestart.Visible = true;
                lose = true;
                coins.Visible = false; 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(lose == true)
            {
                return;
            }

            int speed = 10;
            
            if((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && player.Left > 135)
            {
                player.Left -= speed;
            }
            else if((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && player.Right < 515)
            {
                player.Left += speed;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enemy2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
  
        }

        private void labelLevel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            enemy1.Top = -150;
            enemy2.Top = -250;
            countSpeed = 0;
            
            labelLose.Visible = false;
            buttonRestart.Visible = false;
            timer.Enabled = true;
            lose = false;
            labelEasy.Visible = true;
            labelNormal.Visible = false;
            labelHard.Visible = false;
            labelDevil.Visible = false;
            coins.Visible = true;

            countCoins = 0;
            labelScore.Text = "Score: " + countCoins.ToString() + "/15";
            coins.Top = -350;

        }
    }
}

