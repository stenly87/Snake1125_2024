using Snake1125.Game.Objects;
using System.Drawing;

namespace Snake1125.Game.Drawing.DrawObjects
{
    internal class SnakeDraw : IDraw
    {
        public void Draw(GameObject gameObject, Graphics graphics)
        {
            Snake snake = (Snake)gameObject;
            graphics.FillEllipse(Brushes.Black, snake.Tale.X, snake.Tale.Y, 10, 10);
            graphics.FillEllipse(Brushes.Green, snake.X, snake.Y, 10, 10);
        }
    }
}