using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public class Wall : Entity
    {
        public static readonly Image[] ASSETS = { Properties.Resources.wall };

        public Wall(Position p) : base(p, new List<Image>(ASSETS))
        { }

        public override Image Draw()
        {
            return Images[0];
        }
    }
}
