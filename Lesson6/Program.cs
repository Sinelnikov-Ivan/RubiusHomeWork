namespace Lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myStackInt = new Stack <int>();
            myStackInt.Push (11);
            myStackInt.Push (22);
            Console.WriteLine (myStackInt.Peek());
            Console.WriteLine (myStackInt.Pop());
            Console.WriteLine (myStackInt.Peek());
            Console.WriteLine (myStackInt.IsEmpty());          
            Console.WriteLine (myStackInt.Pop());
            Console.WriteLine (myStackInt.Pop());
            Console.WriteLine (myStackInt.IsEmpty());
            Console.WriteLine("______________________________________");

            var myStackStriing = new Stack<string>();
            myStackStriing.Push("Один");
            myStackStriing.Push("Два");
            Console.WriteLine(myStackStriing.Peek());
            Console.WriteLine(myStackStriing.Pop());
            Console.WriteLine(myStackStriing.Peek());
            Console.WriteLine(myStackStriing.IsEmpty());
            myStackStriing.Clear();
            Console.WriteLine(myStackStriing.Pop());
            Console.WriteLine(myStackStriing.IsEmpty());
            Console.WriteLine("______________________________________");

            var myStackDouble = new Stack<Double>();
            myStackDouble.Push(1.1234234);
            myStackDouble.Push(2.25522);
            Console.WriteLine(myStackDouble.Peek());
            Console.WriteLine(myStackDouble.Pop());
            Console.WriteLine(myStackDouble.Peek());
            Console.WriteLine(myStackDouble.IsEmpty());
            Console.WriteLine(myStackDouble.Pop());
            Console.WriteLine(myStackDouble.Pop());
            Console.WriteLine(myStackDouble.IsEmpty());
            Console.WriteLine("______________________________________");
        }
    }
}