﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class Target : Box
    {
        public static readonly Image[] ASSETS = {
            Properties.Resources.ground,
            Properties.Resources.target
        };

        public Target(Position p, Entity e = null) : base(p, e)
        {
            if (Entity is Crate)
            {
                ((Crate)Entity).Status = true;
            }
        }

        public override List<Image> Draw()
        {
            List<Image> imgs = new List<Image>();
            imgs.Add(ASSETS[0]);
            imgs.Add(ASSETS[1]);

            if (Entity != null)
            {
                imgs.Add(Entity.Draw());
            }

            return imgs;
        }
    }
}
