using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int white = 0;
        int black = 0;
        int[,] map = new int[8,8];
        bool game = false;
        int giliran = 0;

        private void btnPlay_Click(object sender, EventArgs e)
        {
            setUpGame();
        }

        void setUpGame()
        {
            white = 2;
            black = 2;
            giliran = 1;
            map = new int[8, 8];
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if(y == 3 && x == 3)
                    {
                        map[y, x] = 1;
                    }
                    else if(y == 3 && x == 4)
                    {
                        map[y, x] = 2;
                    }
                    else if(y == 4 && x == 3)
                    {
                        map[y, x] = 2;
                    }
                    else if (y == 4 && x == 4)
                    {
                        map[y, x] = 1;
                    }
                    else
                    {
                        map[y, x] = 0;
                    }
                }
            }
            game = true;
            lblBlack.Text = "Black : " + black;
            lblWhite.Text = "White : " + white;
            this.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (game)
            {
                for(int y =0; y < 8; y++)
                {
                    for(int x =0; x < 8; x++)
                    {
                        g.FillRectangle(Brushes.Green, x * 50, y * 50, 50, 50);
                        g.DrawRectangle(Pens.Black, x * 50, y * 50, 50, 50);
                        if(map[y,x] == 1)
                        {
                            g.FillEllipse(Brushes.White, x * 50, y * 50, 50, 50);
                        }
                        else if(map[y,x] == 2)
                        {
                            g.FillEllipse(Brushes.Black, x * 50, y * 50, 50, 50);
                        }
                    }
                }
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (game)
            {
                Rectangle click = new Rectangle(e.Location.X, e.Location.Y, 1, 1);
                int idx_x = -1;
                int idx_y = -1;
                for (int y = 0; y < 8; y++)
                {
                    for (int x = 0; x < 8; x++)
                    {
                        Rectangle box = new Rectangle(x * 50, y * 50, 50, 50);
                        if (box.IntersectsWith(click))
                        {
                            idx_x = x;
                            idx_y = y;
                        }
                    }
                }
                if(idx_x != -1 && idx_y != -1)
                {
                    if(map[idx_y, idx_x] == 0)
                    {
                        map[idx_y, idx_x] = giliran;
                        flip(idx_x, idx_y, -1, -1);
                        flip(idx_x, idx_y, -1, 0);
                        flip(idx_x, idx_y, -1, 1);
                        flip(idx_x, idx_y, 0, -1);
                        flip(idx_x, idx_y, 0, 0);
                        flip(idx_x, idx_y, 0, 1);
                        flip(idx_x, idx_y, 1, -1);
                        flip(idx_x, idx_y, 1, 0);
                        flip(idx_x, idx_y, 1, 1);

                        if (giliran == 1)
                        {
                            white++;
                        }
                        else if (giliran == 2)
                        {
                            black++;
                        }
                        lblBlack.Text = "Black : " + black;
                        lblWhite.Text = "White : " + white;
                        this.Refresh();
                            
                        gameOver();

                        giliran++;
                        if (giliran > 2)
                        {
                            giliran = 1;
                        }
                    }
                }
            }
        }

        void flip(int x, int y, int inc_x, int inc_y)
        {
            List<int> list_x = new List<int>();
            List<int> list_y = new List<int>();
            int ix = 0;
            int iy = 0;
            bool valid = true;
            bool stop = false;
            while(stop == false && valid)
            {
                x += inc_x;
                y += inc_y;
                if (x < 0 || y < 0 || x > 7 || y > 7)
                {
                    valid = false;
                }
                else if (map[y, x] == 0) {
                    valid = false;
                }
                else if(map[y,x] == giliran)
                {
                    stop = true;
                }
                else
                {
                    list_x.Add(x);
                    list_y.Add(y);
                    ix++;
                    iy++;
                }
            }
            if (valid)
            {
                for (int i = 0; i < ix; i++)
                {
                    if(map[list_y[i], list_x[i]] == 0)
                    {
                        if (giliran == 1)
                        {
                            white++;
                        }
                        else if (giliran == 2)
                        {
                            black++;
                        }
                    }
                    else if (map[list_y[i], list_x[i]] == 1)
                    {
                        white--;
                        if (giliran == 1)
                        {
                            white++;
                        }
                        else if (giliran == 2)
                        {
                            black++;
                        }
                    }
                    else if (map[list_y[i], list_x[i]] == 2)
                    {
                        black--;
                        if (giliran == 1)
                        {
                            white++;
                        }
                        else if (giliran == 2)
                        {
                            black++;
                        }
                    }
                    map[list_y[i], list_x[i]] = giliran;
                    
                }
            }
        }

        void gameOver()
        {
            bool gameover = true;
            for(int y = 0; y < 8; y++)
            {
                for(int x =0; x < 8; x++)
                {
                    if(map[y, x] == 0)
                    {
                        gameover = false;
                    }
                }
            }

            if (gameover)
            {
                if(white > black)
                {
                    MessageBox.Show("White menang!");
                }
                else if(black > white)
                {
                    MessageBox.Show("Black menang!");
                }
                else
                {
                    MessageBox.Show("Draw");
                }
                game = false;
            }
        }
    }
}
