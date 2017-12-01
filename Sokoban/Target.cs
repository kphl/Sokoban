using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class Target : Box
    {
        public static readonly Image IMAGE_TARGET = Properties.Resources.target;

        public Target(Position p, Entity e) : base(p, e)
        { }

        public override List<Image> Draw()
        {
            List<Image> imgs = new List<Image>();
            imgs.Add(IMAGE_GROUND);
            imgs.Add(IMAGE_TARGET);

            if (Entity != null)
            {
                imgs.Add(Entity.Draw());
            }

            return imgs;
        }
    }
}
