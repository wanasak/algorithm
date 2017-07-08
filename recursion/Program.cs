using System;

class recursion
{
    static void Main(string[] args)
    {
        Console.WriteLine("Result is {0}", GetTriangleNumber(6));
        Console.WriteLine("Recusion Result is {0}", GetTriangleNumberRecursion(6));
    }

    public static int GetTriangleNumber(int number)
    {
        int result = 0;

        while (number > 0)
        {
            result += number;
            number--;
        }

        return result;
    }

    public static int GetTriangleNumberRecursion(int number)
    {
        if (number == 1)
            return 1;
        else
            return number + GetTriangleNumberRecursion(number - 1);
    }
}
