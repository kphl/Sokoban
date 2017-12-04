using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokoban
{
    class Game
    {
        public static readonly Dictionary<Keys, Direction> DIC_KEY_DIR = new Dictionary<Keys, Direction>(){
            { Keys.Down, Direction.DOWN },
            { Keys.Up, Direction.UP },
            { Keys.Left, Direction.LEFT },
            { Keys.Right, Direction.RIGHT }
        };

        private int CurrentLevel { get; set; }

        public Grid Grid { get; private set; }
        //public List<Coup> coups;

        public Game()
        {
            CurrentLevel = 1;
            LoadLevel(CurrentLevel);
        }

        public void ResetLevel()
        {
            LoadLevel(CurrentLevel);
        }

        public void LoadNextLevel()
        {
            ++CurrentLevel;
            LoadLevel(CurrentLevel);
        }

        public void LoadLevel(int level)
        {
            Grid = new Grid(Properties.Resources.ResourceManager.GetObject("level_" + level).ToString().Split('\n'));
        }

        public void Move(Direction d)
        {
            Player player = Grid.getPlayer();
            Position pos = null;

            switch (d)
            {
                case Direction.DOWN:
                    pos = new Position(0, 1);
                    break;
                case Direction.UP:
                    pos = new Position(0, -1);
                    break;
                case Direction.LEFT:
                    pos = new Position(-1, 0);
                    break;
                case Direction.RIGHT:
                    pos = new Position(1, 0);
                    break;
            }

            Box start = Grid.Boxes[player.Pos.Y, player.Pos.X];
            Position p = pos + player.Pos;
            Box end = Grid.Boxes[p.Y, p.X];

            if (player.Move(d, end))
            {
                player.Pos = p;
                Grid.Move(start, end);
            }
        }

        public void Event(Keys key)
        {
            if (DIC_KEY_DIR.Keys.Contains(key))
            {
                Move(DIC_KEY_DIR[key]);
            }
        }

        public void Draw(Graphics g)
        {
            foreach(Box b in Grid.Boxes)
            {
                List<Image> imgs = b.Draw();
                foreach(Image img in imgs)
                {
                    g.DrawImage(img, b.Pos.X * 64, b.Pos.Y * 64);
                }
            }
        }

        public bool CheckSuccess()
        {
            return Grid.getCrates().Where(_ => !_.Status).Count() == 0;
        }
    }
}
