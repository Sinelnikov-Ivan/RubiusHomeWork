namespace Lesson_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ping ping = new Ping();
            Pong pong = new Pong();
            Ping.DoPing();
        }
    }
}