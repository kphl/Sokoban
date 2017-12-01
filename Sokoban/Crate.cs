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
        public static readonly Image[] ASSETS = { Properties.Resources.crate, Properties.Resources.crate_ok };
        public bool Status { get; set; }

        public Crate(Position p) : base(p, new List<Image>(ASSETS))
        {
            Status = false;
        }

        public override Image Draw()
        {
            return Images[Status ? 1 : 0];
        }

        public bool Move(Direction d, Box box)
        {
            return box.Entity == null;
        }
    }
}
