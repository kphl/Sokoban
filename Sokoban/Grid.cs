using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public class Grid
    {
        public Box[,] Boxes { get; private set; }

        public Grid(String[] level)
        {
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 10; ++i)
                {
                    char c = level[i][j];
                    switch (c)
                    {
                        case 'P':
                            Boxes[i, j] = new Box(new Position(i, j), new Player(new Position(i, j)));
                            break;
                        case 'W':
                            Boxes[i, j] = new Box(new Position(i, j), new Wall(new Position(i, j)));
                            break;
                        case 'C':
                            Boxes[i, j] = new Box(new Position(i, j), new Crate(new Position(i, j)));
                            break;
                        case 'X':
                            Boxes[i, j] = new Target(new Position(i, j), new Crate(new Position(i, j)));
                            break;
                        case 'T':
                            Boxes[i, j] = new Target(new Position(i, j), new Crate(new Position(i, j)));
                            break;
                        default:
                            Boxes[i, j] = new Box(new Position(i, j));
                            break;
                    }
                }
            }
        }

    }
}
