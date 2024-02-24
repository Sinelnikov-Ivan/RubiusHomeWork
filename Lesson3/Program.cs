namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLenght;                            
            int valueOfArray;                          
            
            do
            {
                Console.WriteLine("Введите размер одномерного массива (целое, положительное значение, от 2 до 10:"); 
            }
            while
                (
                !((int.TryParse(Console.ReadLine(), out arrayLenght))   
                && (arrayLenght < 10)                                   
                && (arrayLenght > 1))                                   
                );

            int[] myArray = new int[arrayLenght];                       

            for (int i = 0; i < myArray.Length; i++)                
            {
                do
                { 
                    Console.WriteLine($"Введите целое значение элемента массива номер {i+1}"); 
                }
                while (!int.TryParse(Console.ReadLine(), out valueOfArray));            
            myArray[i] = valueOfArray;
            }

            int x1 = int.MinValue;                              
            int x2 = x1; 
            
            foreach (int value in myArray)
            {
            if (x1 <= value)
                {
                x2 = x1;
                x1 = value;
                }
            else if (x2 < value)
                {
                x2 = value;
                }
            }

            Console.WriteLine("Второе наибольшее значение в массиве:");
            Console.WriteLine(x2);
            Console.ReadLine();
        }
    }
}