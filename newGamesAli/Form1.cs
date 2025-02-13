using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace newGamesAli
{
    public partial class Form1 : Form
    {
        int score = 0;

        bool isActive = false;

        bool isActiveUp = false;
        bool isActiveDown = false;
        bool isActiveLeft = false;
        bool isActiveRight = false;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            label66.Text = score.ToString();
        }

        public void checkWin ()
        {
            if (score == 90)
            {
                isActive = false;
                timer1.Stop();
                MessageBox.Show("you win");
            }
        }

        public void checkLose()
        {
            if (score == -30)
            {
                isActive = false;
                timer1.Stop();
                MessageBox.Show("you have lost");
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)  {}
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive) {

                if (isActiveUp)
                {
                    this.up();
                }
                else if (isActiveLeft)
                {
                    this.left();
                }
                else if (isActiveRight)
                {
                    this.right();
                }
                else if (isActiveDown) {
                    this.down();
                }
            }
        }
        public void up ()
        {
            isActiveUp = true;

            isActiveDown = false;
            isActiveRight = false;
            isActiveLeft = false;

            if (isActive)
            {
                pictureBox1.Top -= 15;

                for (int k = 8; k <= 64; k++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(Controls["label" + k].Bounds))
                    {
                        pictureBox1.Top += 15;
                    }
                }

                for (int k = 2; k <= 7; k++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(Controls["label" + k].Bounds) && Controls["label" + k].Visible)
                    {
                        Controls["label" + k].Visible = false;
                        score += 15;
                        label66.Text = score.ToString();
                    }
                }

                for (int k = 2; k <= 3; k++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(Controls["pictureBox" + k].Bounds) && Controls["pictureBox" + k].Visible)
                    {
                        Controls["pictureBox" + k].Visible = false;
                        score -= 15;
                        label66.Text = score.ToString();
                    }
                }
                this.checkWin();
                this.checkLose();
            }
        }
        public void down ()
        {
            isActiveDown = true;
            isActiveRight = false;
            isActiveLeft = false;
            isActiveUp = false;

            if (isActive)
            {
                pictureBox1.Top += 15;

                for (int k = 8; k <= 64; k++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(Controls["label" + k].Bounds))
                    {
                        pictureBox1.Top -= 15;
                    }
                }

                for (int k = 2; k <= 7; k++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(Controls["label" + k].Bounds) && Controls["label" + k].Visible)
                    {
                        Controls["label" + k].Visible = false;
                        score += 15;
                        label66.Text = score.ToString();
                    }
                }

                for (int k = 2; k <= 3; k++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(Controls["pictureBox" + k].Bounds) && Controls["pictureBox" + k].Visible)
                    {
                        Controls["pictureBox" + k].Visible = false;
                        score -= 15;
                        label66.Text = score.ToString();
                    }
                }

                this.checkWin();
                this.checkLose();
            }
        }
        public void right ()
        {
            isActiveRight = true;
            isActiveLeft = false;
            isActiveUp = false;
            isActiveDown = false;

            if (isActive)
            {
                pictureBox1.Left += 15;

                for (int k = 8; k <= 64; k++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(Controls["label" + k].Bounds))
                    {
                        pictureBox1.Left -= 15;
                    }
                }

                for (int k = 2; k <= 7; k++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(Controls["label" + k].Bounds) && Controls["label" + k].Visible)
                    {
                        Controls["label" + k].Visible = false;
                        score += 15;
                        label66.Text = score.ToString();
                    }
                }

                for (int k = 2; k <= 3; k++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(Controls["pictureBox" + k].Bounds) && Controls["pictureBox" + k].Visible)
                    {
                        Controls["pictureBox" + k].Visible = false;
                        score -= 15;
                        label66.Text = score.ToString();
                    }
                }

                this.checkWin();
                this.checkLose();
            }
        }
        public void left ()
        {
            isActiveLeft = true;

            isActiveDown = false;
            isActiveUp = false;
            isActiveRight = false;

            if (isActive)
            {
                pictureBox1.Left -= 15;

                for (int k = 8; k <= 64; k++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(Controls["label" + k].Bounds))
                    {
                        pictureBox1.Left += 15;
                    }
                }

                for (int k = 2; k <= 7; k++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(Controls["label" + k].Bounds) && Controls["label" + k].Visible)
                    {
                        Controls["label" + k].Visible = false;
                        score += 15;
                        label66.Text = score.ToString();
                    }
                }

                for (int k = 2; k <= 3; k++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(Controls["pictureBox" + k].Bounds) && Controls["pictureBox" + k].Visible)
                    {
                        Controls["pictureBox" + k].Visible = false;
                        score -= 15;
                        label66.Text = score.ToString();
                    }
                }
                this.checkWin();
                this.checkLose();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) this.up();
            if (e.KeyCode == Keys.S) this.down();
            if (e.KeyCode == Keys.D) this.right();
            if (e.KeyCode == Keys.A) this.left();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isActive == false)
            {
                isActive = true;
                isActiveDown = false;
                isActiveUp = false;
                isActiveLeft = false;
                isActiveRight = false;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (isActive == true)
            {
                isActive = false;
                isActiveDown = false;
                isActiveUp = false;
                isActiveLeft = false;
                isActiveRight = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.right();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.up();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.left();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.down();
        }
    }
}
