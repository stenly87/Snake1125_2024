using System.Drawing;

namespace Snake1125.Game.Objects
{
    internal class GameField : GameObject
    {
        public List<GameObject> objects { get; set; } = new();

        internal void AddObject(GameObject gameObject)
        {
            objects.Add(gameObject);
        }

        internal void CheckIntersect(Snake snake)
        {
            foreach (var obj in objects)
            {
                if (obj.X == snake.X && obj.Y == snake.Y)
                {

                }
            }
        }
    }
}