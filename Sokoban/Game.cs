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
        string[] lvl1 =
        {
            "WWWWWWWWWW",
            "W........W",
            "W........W",
            "W..P.C...W",
            "W....TX..W",
            "W........W",
            "W.C......W",
            "W.....T..W",
            "W........W",
            "WWWWWWWWWW"
        };

        public static readonly Dictionary<Keys, Direction> DIC_KEY_DIR = new Dictionary<Keys, Direction>(){
            { Keys.Down, Direction.DOWN },
            { Keys.Up, Direction.UP },
            { Keys.Left, Direction.LEFT },
            { Keys.Right, Direction.RIGHT }

        };

        public Grid Grid { get; private set; }
        //public List<Coup> coups;

        public Game()
        {
            Grid = new Grid(lvl1);
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

                if (CheckSuccess())
                {
                    throw new Exception("You Win \\o/");
                }
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
