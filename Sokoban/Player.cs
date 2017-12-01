using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public class Player : Entity, IMovable
    {

        public static readonly Image[] ASSETS = {
            Properties.Resources.player_up,
            Properties.Resources.player_down,
            Properties.Resources.player_left,
            Properties.Resources.player_right
        };

        private Direction direction;

        public Grid Grid { get; set; }

        public Player(Position p, Grid g) : base(p, new List<Image>(ASSETS))
        {
            direction = Direction.DOWN;
            Grid = g;
        }

        public override Image Draw()
        {
            Image i;
            switch (direction)
            {
                case Direction.UP:
                    i = Images[0];
                    break;
                case Direction.DOWN:
                    i = Images[1];
                    break;
                case Direction.LEFT:
                    i = Images[2];
                    break;
                case Direction.RIGHT:
                    i = Images[3];
                    break;
                default:
                    i = Images.FirstOrDefault();
                    break;
            }

            return i;
        }

        public bool Move(Direction d, Box box)
        {
            direction = d;

            if (box.Entity == null)
            {
                return true;
            }
            else if (box.Entity is Crate)
            {
                Crate crate = box.Entity as Crate;
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

                Box start = Grid.Boxes[crate.Pos.Y, crate.Pos.X];
                Position p = pos + crate.Pos;
                Box end = Grid.Boxes[p.Y, p.X];

                if (crate.Move(d, end))
                {
                    crate.Pos = p;
                    Grid.Move(start, end);
                    return true;
                }
            }

            return false;
        }
    }
}
