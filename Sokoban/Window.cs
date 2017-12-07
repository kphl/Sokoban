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
    public partial class Window : Form
    {
        Bitmap B;
        Graphics G;
        Game game;

        public Window()
        {
            InitializeComponent();
            B = new Bitmap(448, 448);
            G = Graphics.FromImage(B);
            G.Clear(Color.Wheat);
            gamePicture.Image = B;
            game = new Game();
            game.Draw(G);
            gamePicture.Invalidate();
        }

        private void Input_KeyDown(object sender, KeyEventArgs e)
        {

            // Game is finished
            if (game.CurrentLevel > Game.MAX_LEVEL)
                return;

            // Level is finished
            if (game.CheckSuccess())
            {
                if (e.KeyCode == Keys.Enter && game.CurrentLevel < Game.MAX_LEVEL)
                {
                    game.LoadNextLevel();
                    InitLevel();
                }
                return;
            }

            game.Event(e.KeyCode);
            UpdateUI();
        }

        private void ResetLevel(object sender, EventArgs e)
        {
            if (game.CheckSuccess()) return;
            game.ResetLevel();
            UpdateUI();
        }

        private void Undo(object sender, EventArgs e)
        {
            if (game.CheckSuccess()) return;
            game.Undo();
            UpdateUI();
        }

        private void RestartGame(object sender, EventArgs e)
        {
            ToogleWinMessage();
            game = new Game();
            UpdateUI();
        }

        private void ToogleWinMessage()
        {
            winMessage.Visible = !replayMessage.Visible;
            replayMessage.Visible = !replayMessage.Visible;
        }

        private void InitLevel()
        {
            nextLevelLabel.Visible = false;
            UpdateUI();
        }

        private void UpdateUI()
        {
            stepCounter.Text = game.moves.Count.ToString();
            levelLabel.Text = "LEVEL " + game.CurrentLevel.ToString();

            G.Clear(Color.Wheat);
            game.Draw(G);
            gamePicture.Invalidate();
            if (game.CheckSuccess())
            {
                if (game.CurrentLevel == Game.MAX_LEVEL) 
                {
                    ToogleWinMessage();
                }
                else
                {
                    nextLevelLabel.Visible = true;
                }
            }
        }
    }
}
