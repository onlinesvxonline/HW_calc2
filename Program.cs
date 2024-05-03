using System;

public class Calculator
{
    public static int Plus(int a, int b)
    {
        return a + b;
    }

    public static double Plus(double a, double b)
    {
        return a + b;
    }

    public static int Minus(int a, int b)
    {
        return a - b;
    }

    public static double Minus(double a, double b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException();
        }

        return a / b;
    }

    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException();
        }

        return a / b;
    }
}

class Program
{
    static void Main()
    {
        int a = 10;
        int b = 5;

        Console.WriteLine($"Сложение целых чисел: {Calculator.Plus(a, b)}");
        Console.WriteLine($"Вычитание целых чисел: {Calculator.Minus(a, b)}");
        Console.WriteLine($"Умножение целых чисел: {Calculator.Multiply(a, b)}");
        Console.WriteLine($"Деление целых чисел: {Calculator.Divide(a, b)}");

        Console.WriteLine();

        double x = 10.5;
        double y = 3.7;

        Console.WriteLine($"Сложение дробных чисел: {Calculator.Plus(x, y)}");
        Console.WriteLine($"Вычитание дробных чисел: {Calculator.Minus(x, y)}");
        Console.WriteLine($"Умножение дробных чисел: {Calculator.Multiply(x, y)}");
        Console.WriteLine($"Деление дробных чисел: {Calculator.Divide(x, y)}");
    }
}