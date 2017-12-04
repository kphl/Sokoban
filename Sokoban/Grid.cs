using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public class Grid
    {
        public Box[,] Boxes { get; set; }

        public Grid(String[] level)
        {
            Boxes = new Box[10, 10];

            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    char c = level[i][j];
                    switch (c)
                    {
                        case 'P':
                            Boxes[i, j] = new Box(new Position(j, i), new Player(new Position(j, i), this));
                            break;
                        case 'W':
                            Boxes[i, j] = new Box(new Position(j, i), new Wall(new Position(j, i)));
                            break;
                        case 'C':
                            Boxes[i, j] = new Box(new Position(j, i), new Crate(new Position(j, i)));
                            break;
                        case 'X':
                            Boxes[i, j] = new Target(new Position(j, i), new Crate(new Position(j, i)));
                            break;
                        case 'T':
                            Boxes[i, j] = new Target(new Position(j, i));
                            break;
                        default:
                            Boxes[i, j] = new Box(new Position(j, i));
                            break;
                    }
                }
            }
        }

        public Player getPlayer()
        {
            Player p = null;
            foreach (Box b in Boxes)
            {
                if (b.Entity is Player)
                {
                    p = b.Entity as Player;
                }
            }
            return p;
        }

        public List<Crate> getCrates()
        {
            List<Crate> crates = new List<Crate>();
            foreach (Box b in Boxes)
            {
                if (b.Entity is Crate)
                {
                    crates.Add(b.Entity as Crate);
                }
            }
            return crates;
        }

        public void Move(Entity e, Box start, Box end)
        {
            e.Pos = end.Pos;
            end.Entity = start.Entity;
            start.Entity = null;

            if (end.Entity is Crate)
            {
                ((Crate)end.Entity).Status = (end is Target);
            }
        }
    }
}
