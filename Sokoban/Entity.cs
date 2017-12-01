using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public abstract class Entity
    {
        protected Position Pos { get; set; }
        protected List<Image> Images { get; set; }

        public Entity(Position p, List<Image> assets)
        {
            Pos = p;
            Images = assets;
        }

        abstract public Image Draw();
    }
}
