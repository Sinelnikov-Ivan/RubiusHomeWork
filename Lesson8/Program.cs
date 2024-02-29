namespace Lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {        
        Handler1 handler1 = new Handler1(); 
        Handler2 handler2 = new Handler2();
        Counter counter = new Counter();
        counter.myEvent += handler1.Say;
        counter.myEvent += handler2.Say;
        counter.startCounter();   
        }
    }
}