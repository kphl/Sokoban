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

        public Player(Position p) : base(p, new List<Image>(ASSETS))
        {
            direction = Direction.DOWN;
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

            if (box.Entity == null || box.Entity is Crate)
            {
                return true;
            }

            return false;
        }
    }
}
