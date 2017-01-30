using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace array
{
    public class Program
    {
        private int[] array = new int[50];
        private int arraySize = 10;
        public void generateRandomArray()
        {
            Random rnd = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = (int)rnd.Next(10, 20);
            }
        }
        public void printArrayHorizontal(int i, int j)
        {
            for (int n = 0; n < 51; n++) Console.Write("-");
            Console.WriteLine();
            for (int n = 0; n < arraySize; n++)
            {
                Console.Write("| " + n + "  ");
            }
            Console.WriteLine();
            for (int n = 0; n < 51; n++) Console.Write("-");
            Console.WriteLine();
            for (int n = 0; n < arraySize; n++)
            {
                Console.Write("| " + array[n] + " ");
            }
            Console.WriteLine("|");
            if (j != -1)
            {
                // ADD THE +2 TO FIX SPACING
                for (int k = 0; k < ((j * 5) + 2); k++) Console.Write(" ");
                Console.Write(j);
            }
            // THEN ADD THIS CODE
            if (i != -1)
            {
                // ADD THE -1 TO FIX SPACING
                for (int l = 0; l < (5 * (i - j) - 1); l++) Console.Write(" ");
                Console.Write(i);
            }
            Console.WriteLine();
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
        public void bubbleSort()
        {
            for (int i = arraySize - 1; i > 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        swapValues(j, j + 1);
                        printArrayHorizontal(i, j);
                    }
                }
            }
        }
        public void binarySearchValue(int value)
        {
            int lowerIndex = 0;
            int higherIndex = arraySize - 1;

            while (lowerIndex <= higherIndex)
            {
                int middleIndex = (higherIndex + lowerIndex) / 2;
                if (array[middleIndex] < value) lowerIndex = middleIndex + 1;
                else if (array[middleIndex] > value) higherIndex = middleIndex - 1;
                else
                {
                    Console.WriteLine("Found the value " + value + " at index " + middleIndex);
                    lowerIndex = higherIndex + 1;
                }
                printArrayHorizontal(middleIndex, -1);
            }
        }
        public void swapValues(int indexOne, int indexTwo)
        {
            int temp = array[indexOne];
            array[indexOne] = array[indexTwo];
            array[indexTwo] = temp;
        }
        public static void Main(string[] args)
        {
            Program prg = new Program();
            prg.generateRandomArray();

            // prg.printArrayHorizontal(-1, -1);
            prg.bubbleSort();
            prg.binarySearchValue(19);

        }
    }
}
