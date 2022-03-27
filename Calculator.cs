using System;

class Calculator
{
    public static float Addition(float sum, float number) { return sum += number; }

    public static float Subtraction(float sum, float number) { return sum -= number; }

    public static float Multiplication(float sum, float number) { return sum *= number; }

    public static float Division(float sum, float number)
    {
        if (number == 0)
            throw new ArgumentException("Cannot divide by zero.");

        return sum /= number;
    }
}