using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yunus_İnan_Corona_VizeProje_a3
{
    public partial class yilanOyunu : Form
    {
        public yilanOyunu()
        {
            InitializeComponent();
        }
        #region Snake Properties
        PictureBox[] SnakePart = new PictureBox[4]; // Snake number of sections
        int LastIndex = 0; // Snake start sections
        int HeadIndex = 0; // Snake end sections (the snake's head)
        bool GameStatus = false; // Game start or stop
        char SnakeWay = (char)0;
        bool SnakeCrashed = false;

        private void CreateSnake() // Create new a snake
        {
            SnakePart = new PictureBox[4];
            for (int i = 0; i < SnakePart.Length; i++)
            {
                SnakePart[i] = new PictureBox();
                SnakePart[i].Width = 15;
                SnakePart[i].Height = 15;
                SnakePart[i].Top = 0;
                SnakePart[i].Left = i * (SnakePart[i].Width + 1);
                SnakePart[i].BackColor = Color.Yellow;
                pbGame.Controls.Add(SnakePart[i]);
            }
            HeadIndex = SnakePart.Length - 1;
        }

        private void DeleteSnake() // Delete a snake
        {
            for (int i = 0; i < SnakePart.Length; i++)
            {
                pbGame.Controls.Remove(SnakePart[i]);
            }
        }

        private void SnakePartAdd()
        {
            Array.Resize(ref SnakePart, SnakePart.Length + 1);
            SnakePart[SnakePart.Length - 1] = new PictureBox();
            SnakePart[SnakePart.Length - 1].Width = 15;
            SnakePart[SnakePart.Length - 1].Height = 15;
            // Dışarıda oluşsun bir tur tamamlanında otomatik olarak ekleniyormuş :D
            SnakePart[SnakePart.Length - 1].Top = -20; //*
            SnakePart[SnakePart.Length - 1].Left = -20; //*
            SnakePart[SnakePart.Length - 1].BackColor = Color.Yellow;
            pbGame.Controls.Add(SnakePart[SnakePart.Length - 1]);
        }
        
        private void SnakeCrashControl() // Snake head crash controls func.
        {
            for (int i = 0; i < SnakePart.Length; i++) // Snake Crashed to tail
            {

                float mutlakX = Math.Abs((SnakePart[HeadIndex].Left + (SnakePart[HeadIndex].Width / 2)) - (SnakePart[i].Left + (SnakePart[i].Width / 2)));
                float mutlakY = Math.Abs((SnakePart[HeadIndex].Top + (SnakePart[HeadIndex].Height / 2)) - (SnakePart[i].Top + (SnakePart[i].Height / 2)));
                float farkGenislik = (SnakePart[HeadIndex].Width / 2) + (SnakePart[i].Width / 2);
                float farkYukselik = (SnakePart[HeadIndex].Height / 2) + (SnakePart[i].Height / 2);
                if ((farkGenislik > mutlakX) && (farkYukselik > mutlakY) && i != HeadIndex)
                {
                    SnakeCrashed = true;
                    break;
                }
            }

            if (SnakePart[HeadIndex].Left >= pbGame.Width - SnakePart[HeadIndex].Width)
            {
                SnakeCrashed = true;
            }
            else if (SnakePart[HeadIndex].Top >= pbGame.Height - SnakePart[HeadIndex].Height)
            {
                SnakeCrashed = true;
            }
            else if (SnakePart[HeadIndex].Top <= -1)
            {
                SnakeCrashed = true;
            }
            else if (SnakePart[HeadIndex].Left <= -1)
            {
                SnakeCrashed = true;
            }

            if (SnakeCrashed)
            {
                GameStatus = false;
                tmrGoSnake.Enabled = false;
                MessageBox.Show("Üzgünüm Çarptınız. Oyunu Kaybettiniz. Score : " + Score.ToString(), "Dikkat");
            }
        }

        int GoLeft = 0, GoTop = 0; // Snake go x and y coordinates
        private void SnakeMove(int top, int left)
        {
            SnakePart[LastIndex].Left = SnakePart[HeadIndex].Left + left;
            SnakePart[LastIndex].Top = SnakePart[HeadIndex].Top + top;

            if (LastIndex == SnakePart.Length - 1)
            {
                LastIndex = 0;
                HeadIndex = SnakePart.Length - 1;
            }
            else
            {
                LastIndex++;
                HeadIndex = LastIndex - 1;
            }
        }

        #endregion
        #region Food Properties
        Random r = new Random();
        PictureBox Food;
        int Score = 0;

        private void CreateFood()
        {
            int FoodTop = 16 * r.Next(1, 30);
            int FoodLeft = 16 * r.Next(1, 30);
            Food = new PictureBox();
            Food.Width = 15;
            Food.Height = 15;
            Food.Left = FoodLeft;
            Food.Top = FoodTop;
            Food.BackColor = Color.Red;
            pbGame.Controls.Add(Food);
        }

        bool FoodEat = false;
        private void FoodEatControl()
        {
            float mutlakX = Math.Abs((SnakePart[HeadIndex].Left + (SnakePart[HeadIndex].Width / 2)) - (Food.Left + (Food.Width / 2)));
            float mutlakY = Math.Abs((SnakePart[HeadIndex].Top + (SnakePart[HeadIndex].Height / 2)) - (Food.Top + (Food.Height / 2)));
            float farkGenislik = (SnakePart[HeadIndex].Width / 2) + (Food.Width / 2);
            float farkYukselik = (SnakePart[HeadIndex].Height / 2) + (Food.Height / 2);
            if ((farkGenislik > mutlakX) && (farkYukselik > mutlakY))
            {
                FoodEat = true;
            }

            if (FoodEat)
            {
                // New Part adding to snake       
                SnakePartAdd();
                Score += 10;
                lblScore.Text = "Score : " + Score.ToString();
                DeleteFood();
                CreateFood();
                FoodEat = false;
            }
        }

        private void tmrGoSnake_Tick(object sender, EventArgs e)
        {
            if (GameStatus)
            {
                SnakeMove(GoTop, GoLeft); // Snake Move 
                SnakeCrashControl();
                FoodEatControl();
            }
        }

        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            duraklatToolStripMenuItem.Text = "Duraklat";
            lblScore.Text = "Score : 0";
            Score = 0;
            FoodEat = false;
            GoLeft = 16; GoTop = 0;
            SnakeWay = 'R';
            SnakeCrashed = false;
            GameStatus = true;
            LastIndex = 0;

            DeleteSnake();
            CreateSnake();

            DeleteFood();
            CreateFood();

            tmrGoSnake.Enabled = true;
        }

        private void duraklatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GameStatus || duraklatToolStripMenuItem.Text == "Devam Et") // Game started or text is = "Devam Et" Then
            {
                if (duraklatToolStripMenuItem.Text == "Duraklat")
                {
                    tmrGoSnake.Enabled = false;
                    GameStatus = false;
                    duraklatToolStripMenuItem.Text = "Devam Et";
                }
                else
                {
                    tmrGoSnake.Enabled = true;
                    GameStatus = true;
                    duraklatToolStripMenuItem.Text = "Duraklat";
                }
            }
        }

        private void yilanOyunu_KeyDown(object sender, KeyEventArgs e)
        {
            if (GameStatus) // If game start then change a go x and go y
            {
                if (e.KeyCode == Keys.Right && SnakeWay != 'L')
                {
                    GoLeft = 0; GoTop = 0;
                    GoLeft = 16;
                    SnakeWay = 'R';
                }
                else if (e.KeyCode == Keys.Left && SnakeWay != 'R')
                {
                    GoLeft = 0; GoTop = 0;
                    GoLeft = -16;
                    SnakeWay = 'L';
                }
                else if (e.KeyCode == Keys.Up && SnakeWay != 'D')
                {
                    GoLeft = 0; GoTop = 0;
                    GoTop = -16;
                    SnakeWay = 'U';
                }
                else if (e.KeyCode == Keys.Down && SnakeWay != 'U')
                {
                    GoLeft = 0; GoTop = 0;
                    GoTop = 16;
                    SnakeWay = 'D';
                }  
            }
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notifyIconTaksi_DoubleClick(object sender, EventArgs e)
        {
            if (this.Visible == false)
                this.Show();
            else
                this.Hide();
        }

        private void DeleteFood()
        {
            pbGame.Controls.Remove(Food);
        }

        #endregion   


    }
}
