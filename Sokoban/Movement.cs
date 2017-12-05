using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public class Movement
    {
        public Box Start { get; set; }
        public Box End { get; set; }
        public Entity Entity { get; set; }
        public Direction Direction { get; set; }

        public Movement CrateMovement { get; set; }

        public Movement(Box start, Box end, Entity entity, Direction direction)
        {
            Start = start;
            End = end;
            Entity = entity;
            Direction = direction;
        }
    }
}
