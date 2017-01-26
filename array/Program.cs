using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace array
{
    public class Program
    {
        private int[] array = new int[50];
        private int arraySize = 20;
        public void generateRandomArray()
        {
            Random rnd = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = (int)rnd.Next(1, 20);
            }
        }
        public void printArray()
        {
            Console.WriteLine("----------");
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("| " + i + " | ");
                Console.WriteLine(array[i] + " |");
                Console.WriteLine("----------");
            }
        }
        public int getValueAtIndex(int index)
        {
            if (index < arraySize) return array[index];
            return 0;
        }
        public bool isArrayContainThisValue(int searchValue)
        {
            for (int i = 0; i < arraySize; i++)
            {
                if (array[i] == searchValue) return true;
            }

            return false;
        }
        public void deleteIndex(int index)
        {
            if (index < arraySize)
            {
                for (int i = index; i < (arraySize - 1); i++)
                {
                    array[i] = array[i + 1];
                }
            }
            arraySize--;
        }
        public void insertValue(int value)
        {
            array[arraySize] = value;
            arraySize++;
        }
        public string linearSearch(int value)
        {
            bool isMatch = false;
            string indexsWithMatch = "";

            for (int i = 0; i < arraySize; i++)
            {
                if (array[i] == value)
                {
                    isMatch = true;
                    indexsWithMatch += i + " ";
                }
            }

            if (isMatch)
                return "The value was found in the following: " + indexsWithMatch;
            else 
                return "Not found";
        }
        public static void Main(string[] args)
        {
            Program prg = new Program();
            prg.generateRandomArray();
            prg.printArray();

            Console.WriteLine(prg.getValueAtIndex(3));
            Console.WriteLine(prg.isArrayContainThisValue(11));
            //  delete
            prg.deleteIndex(7);
            prg.printArray();
            // insert
            prg.insertValue(44);
            prg.printArray();
            // linear search
            Console.WriteLine(prg.linearSearch(4));
        }
    }
}
