using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class Ground : Box
    {
        public static readonly Image IMAGE_GROUND = Properties.Resources.ground;

        public Ground(Position p, Entity e = null) : base(p, e)
        {
        }

        public override List<Image> Draw()
        {
            List<Image> imgs = new List<Image>();
            imgs.Add(IMAGE_GROUND);

            if (Entity != null)
            {
                imgs.Add(Entity.Draw());
            }

            return imgs;
        }
    }
}
