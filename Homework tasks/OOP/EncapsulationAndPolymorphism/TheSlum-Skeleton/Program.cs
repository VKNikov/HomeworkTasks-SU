namespace TheSlum
{
    using TheSlum.GameEngine;

    public class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new NewGame();
            engine.Run();
        }
    }
}
