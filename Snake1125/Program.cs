namespace Snake1125
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нажми Enter для запуска");
            Console.ReadLine();
            SnakeGame game = new SnakeGame();
            game.Start();
        }
    }
}
