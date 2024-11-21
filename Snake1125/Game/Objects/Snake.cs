using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake1125.Game.Objects
{
    internal class Snake : GameObject
    {
        public GameObject Tale { get => cells.Last(); }
        public Direction Direction { get; set; }

        List<GameObject> cells;

        public Snake(int x, int y)
        {
            cells = new() { new GameObject { X = x, Y = y } };
        }

        internal void Move()
        {
            for (int i = cells.Count - 1; i > 0; i--)
            {
                cells[i].X = cells[i - 1].X;
                cells[i].Y = cells[i - 1].Y;
            }
            switch (Direction)
            {
                case Direction.up:
                    cells[0].Y -= 10;
                    break;
                case Direction.down:
                    cells[0].Y += 10;
                    break;
                case Direction.left:
                    cells[0].X -= 10;
                    break;
                case Direction.right:
                    cells[0].X += 10;
                    break;
            }
        }
    }
}
