using System;

class Program
{

    //Sum of numbers within a number
    public static int SumOfNumbers(int a)
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
    public static int Reverse(int a)
    {
        int result = 0;
        while (a > 0)
        {
            result *= 10;
            result += a % 10;
            a = a / 10;
        }
        return result;
    }

    //count of numbers
    public static int Count(int a)
    {
        int result = 0;
        while (a > 0)
        {
            a /= 10;
            result++;
        }
        return result;
    }

    //odd or even value
    public static void OddOrEven(int a)
    {
        if (a == 0 || a % 2 == 0)
        {
            Console.WriteLine("The number {0} is odd", a);
        }
        else
        {
            Console.WriteLine("The number {0} is even", a);
        }
    }

    //prime numbers chain
    public static void PrimeNumbers(int a)
    {
        int j = 2;
        bool prime;
        for (int i = 1; i < a; i++)
        {
            prime = true;

            for (j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    prime = false;
                    break;
                }
            }
            
            if (prime)
                Console.Write(i + " ");         
       
        }

    }

    //fibonacci sequence
    public static void FibonacciSequence (int a)
    {
        int firstNum = 0;
        int secondNum = 1;
        int nextNum = 0;
        Console.Write(firstNum + " " +secondNum+" ");
        while (nextNum < a)
        {
            nextNum = firstNum + secondNum;
            if (nextNum > a)
                break;
            Console.Write(nextNum + " ");
            firstNum = secondNum;
            secondNum = nextNum;
        } 
    }


    static void Main()
    {
        Console.WriteLine(SumOfNumbers(34234));
        Console.WriteLine(Reverse(1234));
        Console.WriteLine(Count(23456));
        OddOrEven(342);
       // PrimeNumbers(200);
        FibonacciSequence(200);
    }
}