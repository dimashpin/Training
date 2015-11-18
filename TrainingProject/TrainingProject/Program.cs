using System;
using System.Runtime.InteropServices; //used for the 4th method

class Program
{
    //1. Using params keyword
    public static void Sum1(int firstNumber, int secondNumber, params object[] otherNumbers)
    {
        int sum = firstNumber + secondNumber;
        if (otherNumbers != null)
        {
            foreach (int n in otherNumbers)
            {
                sum += n;
            }
        }
        Console.WriteLine("Sum1 = {0}", sum);
    }

    //2. Using overloading methods
    public static void Sum2(int firstNumber, int secondNumber, int[] otherNumbers)
    {
        int sum = firstNumber + secondNumber;
        if (otherNumbers != null)
        {
            foreach (int n in otherNumbers)
            {
                sum += n;
            }
        }
        Console.WriteLine("Sum2 = {0}", sum);
    }

    public static void Sum2(int firstNumber, int secondNumber)
    {
        Sum2(firstNumber, secondNumber, null);
    }

    //3. Specifing default method's parameters values
    public static void Sum3(int firstNumber, int secondNumber, int[] otherNumbers = null)
    {
        int sum = firstNumber + secondNumber;
        if (otherNumbers != null)
        {
            foreach (int n in otherNumbers)
            {
                sum += n;
            }
        }
        Console.WriteLine("Sum3 = {0}", sum);
    }

    //4. Using OptionalAttribute
    public static void Sum4(int firstNumber, int secondNumber, [OptionalAttribute] int[] otherNumbers)
    {
        int sum = firstNumber + secondNumber;
        if (otherNumbers != null)
        {
            foreach (int n in otherNumbers)
            {
                sum += n;
            }
        }
        Console.WriteLine("Sum4 = {0}", sum);
    }


    static void Main()
    {
        //Testing
        Sum1(23, 2);
        Sum1(32, 22, 12);

        Sum2(34, 2);
        Sum2(2, 13, new int[] {11,9,2});

        Sum3(4, 2);
        Sum3(2, 13, new int[] { 11, 9});

        Sum4(3, 2);
        Sum4(2, 13, new int[] { 11, 52, 2 });
    }
}

