using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace array
{
    public class Program
    {
        public class Stack
        {
            private string[] array;
            private int size;
            private int index;
            public Stack(int size)
            {
                this.size = size;
                this.array = new string[size];
                index = -1;
            }
            public void push(string data)
            {
                if (index + 1 < size)
                    this.array[++index] = data;
            }
            public string pop()
            {
                if (index >= 0)
                    return this.array[index--];
                else
                    return "empty";
            }
            public string peek()
            {
                if (index >= 0)
                    return this.array[index];
                else
                    return "empty";
            }
        }
        public static void Main(string[] args)
        {
            Stack stack = new Stack(5);
            stack.push("1");
            stack.push("2");
            stack.push("3");
            stack.push("4");
            stack.push("5");
            stack.push("6");
            Console.WriteLine("Pop statck (5): " + stack.pop());
            Console.WriteLine("Peek statck (4): " + stack.peek());
            stack.pop();
            stack.pop();
            stack.pop();
            stack.pop();
            Console.WriteLine("Peek statck (empty): " + stack.pop());
        }
    }
}
