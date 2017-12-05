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

        public const int MAX_LEVEL = 7;

        public int CurrentLevel { get; private set; }

        public Grid Grid { get; private set; }
        public List<Movement> moves;

        public Game()
        {
            CurrentLevel = 1;
            LoadLevel(CurrentLevel);
            moves = new List<Movement>();
        }

        public void ResetLevel()
        {
            LoadLevel(CurrentLevel);
        }

        public void LoadNextLevel()
        {
            ++CurrentLevel;
            if (CurrentLevel > MAX_LEVEL)
            {
                throw new Exception("You win !");
            }

            LoadLevel(CurrentLevel);
        }

        public void LoadLevel(int level)
        {
            moves = new List<Movement>();
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
                Movement m = new Movement(start, end, player, d);
                bool ok = true;

                if (end.Entity is Crate)
                {
                    Crate c = end.Entity as Crate;
                    Box startC = Grid.Boxes[c.Pos.Y, c.Pos.X];
                    Position pC = pos + c.Pos;
                    Box endC = Grid.Boxes[pC.Y, pC.X];

                    if (c.Move(d, endC))
                    {
                        Grid.Move(startC, endC);
                        Movement mC = new Movement(startC, endC, c, d);
                        m.CrateMovement = mC;
                    }
                    else
                    {
                        ok = false;
                    }
                }

                if (ok)
                {
                    moves.Add(m);
                    Grid.Move(start, end);
                }

            }
        }

        public void Undo()
        {
            if (moves.Count == 0) return;
            Movement m = moves.Last();
            Grid.Move(m.End, m.Start);

            ((Player)m.Entity).Move(m.Direction, m.End);

            if(m.CrateMovement != null)
            {
                Grid.Move(m.CrateMovement.End, m.CrateMovement.Start);
            }
            moves.Remove(m);
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
