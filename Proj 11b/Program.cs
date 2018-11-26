using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_11b
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(4);
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());

            Console.WriteLine("_______________________");
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(4);
            while (s.peek() != -1)
            {
                Console.WriteLine(s.Pop());
            }

        }
    }
    class Stack
    {
        int[] values;
        int pointer;

        public Stack() : this(3) { }

        public Stack(int size)
        {
            values = new int[size];
            pointer = 0;

        }
        public void Push(int newValue)
        {
            if (pointer == values.Length)
            {
                Console.WriteLine("Stack is Full!");
            }
            else
            {
                values[pointer++] = newValue;
            }

        }
        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("pop ()- EMPTY!");
                return -1;
            }
            return values[--pointer];
        }
        public int peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("peek ()- EMPTY!");
                return -1;
            }
            return values[pointer - 1];

    }
    public bool IsEmpty()
    {
        return pointer == 0;
    }
}


}
