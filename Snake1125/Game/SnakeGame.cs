using Snake1125.Game.Drawing;
using Snake1125.Game.Drawing.DrawObjects;
using Snake1125.Game.Objects;
using Snake1125.Game.Drawing;
using Snake1125.Game.Objects;

namespace Snake1125
{
    internal class SnakeGame
    {
        Random random = new Random();
        DrawSystem draw;
        GameField field;
        Control control;
        Snake snake;
        public bool SnakeIsAlive { get; set; }
        internal void SendNewSnakeDirection(Direction direction)
        {
            snake.Direction = direction;
        }

        public SnakeGame()
        {
            draw = new DrawSystem();
            control = new Control();
            draw.RegistrationDraw(typeof(GameField), new GameFieldDraw());
            draw.RegistrationDraw(typeof(Snake), new SnakeDraw());
            draw.RegistrationDraw(typeof(Apple), new AppleDraw());
        }

        void CreateSnake()
        {
            snake = new Snake(50, 50);
            SnakeIsAlive = true;
        }

        internal void Start()
        {
            CreateSnake();
            field = new GameField();
            RunGame();
        }

        private void RunGame()
        {
            control.Run(this);
            draw.Draw(field);
            while (SnakeIsAlive)
            {
                snake.Move();
                draw.Draw(snake);
                field.CheckIntersect(snake);
                foreach (var obj in field.objects)
                    draw.Draw(obj);
                Thread.Sleep(500);
            }
        }
    }
}