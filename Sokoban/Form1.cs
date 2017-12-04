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
            B = new Bitmap(640, 640);
            G = Graphics.FromImage(B);
            G.Clear(Color.White);
            pictureBox1.Image = B;
            game = new Game();
            game.Draw(G);
            pictureBox1.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (game.CheckSuccess())
            {
                game.LoadNextLevel();
                game.Draw(G);
                pictureBox1.Invalidate();
                return;
            }

            game.Event(e.KeyCode);
            G.Clear(Color.White);
            game.Draw(G);

            if (game.CheckSuccess())
            {
                G.DrawString("Yeah !", new Font("Comics Sans MS", 22), new SolidBrush(Color.Red), 50, 50);
            }

            pictureBox1.Invalidate();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            game.ResetLevel();
            game.Draw(G);
            pictureBox1.Invalidate();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            game.Undo();
            game.Draw(G);
            pictureBox1.Invalidate();
        }
    }
}
