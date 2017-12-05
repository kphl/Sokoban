using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokoban
{
    public partial class Form1 : Form
    {
        Bitmap B;
        Graphics G;
        Game game;

        public Form1()
        {
            InitializeComponent();
            B = new Bitmap(448, 448);
            G = Graphics.FromImage(B);
            G.Clear(Color.Wheat);
            pictureBox1.Image = B;
            game = new Game();
            game.Draw(G);
            pictureBox1.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            G.Clear(Color.Wheat);

            if(e.KeyCode == Keys.Back)
            {
                pictureBox3_Click(sender, e);
            }

            while(game.CheckSuccess())
            {
                if (e.KeyCode == Keys.Enter)
                {
                    game.LoadNextLevel();
                    label2.Text = "LEVEL " + game.CurrentLevel.ToString();
                    game.Draw(G);
                    label1.Text = game.moves.Count.ToString();
                    pictureBox1.Invalidate();
                }
                return;
            }

            game.Event(e.KeyCode);
            game.Draw(G);

            if (game.CheckSuccess())
            {
                G.DrawString("Yeah !", new Font("Comic Sans MS", 22), new SolidBrush(Color.Red), 50, 50);
            }
            label1.Text = game.moves.Count.ToString();
            pictureBox1.Invalidate();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            game.ResetLevel();
            game.Draw(G);
            label1.Text = game.moves.Count.ToString();
            pictureBox1.Invalidate();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Enabled = false;
            game.Undo();
            game.Draw(G);
            label1.Text = game.moves.Count.ToString();
            pictureBox1.Invalidate();
            pictureBox3.Enabled = true;
        }
    }
}
