using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public class Crate : Entity, IMovable
    {
        public static readonly Image[] ASSETS = { Properties.Resources.crate };

        public Crate(Position p) : base(p, new List<Image>(ASSETS))
        { }

        public override Image Draw()
        {
            return Images[0];
        }

        public bool Move(Direction d)
        {
            return false;
        }
    }
}
