using Newtonsoft.Json.Linq;

namespace Lesson7

{
    public class StackTests
    {
        [Fact]
        public void PushIntTest()
        {
            var myStackIntTest = new Stack<int>();
            int current—ountStack = myStackIntTest.listOfItem.Count;
            Random rnd = new Random();
            var value = rnd.Next(0, 1000);
            myStackIntTest.Push(value);
            Assert.Equal(value, myStackIntTest.listOfItem[0]);
            Assert.Equal(current—ountStack, myStackIntTest.listOfItem.Count - 1);
        }
        [Fact]
        public void PopIntTest()
        {
            var myStackIntTest = new Stack<int>();
            Random rnd = new Random();
            var value = rnd.Next(0, 1000);
            myStackIntTest.Push(value);
            int current—ountStack = myStackIntTest.listOfItem.Count;
            Assert.Equal(value, myStackIntTest.Pop());
            Assert.Equal(current—ountStack, myStackIntTest.listOfItem.Count + 1);
        }
        [Fact]
        public void PeekIntTest()
        {
            var myStackIntTest = new Stack<int>();
            Random rnd = new Random();
            var value = rnd.Next(0, 1000);
            myStackIntTest.Push(value);
            int current—ountStack = myStackIntTest.listOfItem.Count;
            Assert.Equal(value, myStackIntTest.Peek());
            Assert.Equal(current—ountStack, myStackIntTest.listOfItem.Count);
        }
        [Fact]
        public void ClearAndEmptyIntTest()
        {
            var myStackIntTest = new Stack<int>();
            myStackIntTest.Push(100);
            myStackIntTest.Clear();
            Assert.True(myStackIntTest.IsEmpty());
        }
    }
}