using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public class Box
    {
        //public static readonly Image IMAGE_GROUND = Properties.Resources.ground;

        public Entity Entity { get; set; }
        public Position Pos { get; }

        public Box(Position p, Entity e = null)
        {
            Pos = p;
            Entity = e;
        }

        public virtual List<Image> Draw()
        {
            return new List<Image>();
        }
    }
}
