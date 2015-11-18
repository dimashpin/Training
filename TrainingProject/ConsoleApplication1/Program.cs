using System;

class Program
{

    //Sum of numbers within a number
    public static int SumOfNumbers (int a)
    {
        int result = 0;
        //execute when true
        while (a > 0)
        {
            result += a % 10;
            a = a / 10;
        }
        return result;
    }

    //reverse order of numbers
    public static int Reverse (int a)
    {
        int result = 0;
        while (a > 0)
        {
            result *= 10;
            result += a%10;
            a = a / 10;
        }
        return result;
    }

    static void Main()
    {
        Console.WriteLine(SumOfNumbers(34234));
        Console.WriteLine(Reverse(1234));
    }
}