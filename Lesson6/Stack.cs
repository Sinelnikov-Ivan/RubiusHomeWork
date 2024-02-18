using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson6
{
    public class Stack <T>
    {
        public List<T> listOfItem = new List<T> ();

        public void Push (T item)
        {
            listOfItem.Add(item);
            Console.WriteLine($"В стек добавлен тип {typeof(T)} со значением {item}");
        }
        public T Pop()
        {
            if (listOfItem.Count == 0)
            {
                Console.WriteLine($"Стек пуст возвращаем тип {typeof(T)} значение {(default(T) == null ? "null" : default(T).ToString())}.");
                return default (T);                              
            }
            else
            {   
            var result = listOfItem [listOfItem.Count - 1];
            listOfItem.RemoveAt (listOfItem.Count-1);               
            return result;
            }
        }

        public T Peek()
        {
            if (listOfItem.Count == 0)
            {
                Console.WriteLine($"Стек пуст возвращаем тип {typeof(T)} значение {(default(T) == null ? "null" : default(T).ToString())}.");
                return default (T);
            }
            else
            {
                return listOfItem[listOfItem.Count - 1];
            }
        }

        public bool IsEmpty()
        {
            if (listOfItem.Count == 0)
                return true;
            else
                return false;
        }

        public void Clear()
        {
            listOfItem.Clear();
            Console.WriteLine ("Стек очищен");
        }
    }
}

