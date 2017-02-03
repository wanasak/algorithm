using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public class Queue
        {
            private int[] intArray;
            private int front;
            private int rear;
            private int itemCount;
            private int size;
            public Queue(int size)
            {
                intArray = new int[size];
                this.size = size;
                front = 0;
                rear = -1;
                itemCount = 0;
            }
            public bool isFull()
            {
                return itemCount == size;
            }
            public void enqueue(int data)
            {
                if (!isFull())
                {
                    if (rear == size - 1) rear = -1;
                    intArray[++rear] = data;
                    itemCount++;
                }
            }
            public void dequeue()
            {
                int data = intArray[front];
                Console.WriteLine("Dequeue " + data + " from the queue.");
                intArray[front++] = -1;
                if (front == size) front = 0;
                itemCount--;
            }
            public string toString()
            {
                string index = "";
                string queue = "";
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("--------------------");
                sb.AppendLine("// front : " + front);
                sb.AppendLine("// rear : " + rear);
                for (int i = 0; i < size; i++)
                {
                    if (intArray[i] > -1)
                    {
                        index += " " + i.ToString();
                        queue += " " + intArray[i].ToString();
                    }
                }
                sb.AppendFormat("// index :{0}", index);
                sb.AppendLine();
                sb.AppendFormat("// queue :{0}", queue);
                sb.AppendLine();
                // sb.Append("--------------------");
                return sb.ToString();
            }
        }
        public static void Main(string[] args)
        {
            // Stack stack = new Stack(5);
            // stack.push("1");
            // stack.push("2");
            // stack.push("3");
            // stack.push("4");
            // stack.push("5");
            // stack.push("6");
            // Console.WriteLine("Pop statck (5): " + stack.pop());
            // Console.WriteLine("Peek statck (4): " + stack.peek());
            // stack.pop();
            // stack.pop();
            // stack.pop();
            // stack.pop();
            // Console.WriteLine("Peek statck (empty): " + stack.pop());

            Queue queue = new Queue(5);
            queue.enqueue(11);
            queue.enqueue(12);
            queue.enqueue(13);
            queue.enqueue(14);
            queue.enqueue(15);
            queue.enqueue(16);
            Console.WriteLine(queue.toString());
            queue.dequeue();
            Console.WriteLine(queue.toString());
            queue.dequeue();
            Console.WriteLine(queue.toString());
            queue.enqueue(16);
            Console.WriteLine(queue.toString());
        }
    }
}
