using System;

class FinancialForecasting
{
    // Recursive method
    static double PredictFutureValue(
        double currentValue,
        double growthRate,
        int years)
    {
        // Base Case
        if (years == 0)
            return currentValue;

        // Recursive Call
        return PredictFutureValue(
            currentValue * (1 + growthRate),
            growthRate,
            years - 1);
    }

    static void Main()
    {
        double currentValue = 10000;

        double growthRate = 0.10; // 10%

        int years = 3;

        double futureValue =
            PredictFutureValue(
                currentValue,
                growthRate,
                years);

        Console.WriteLine(
            "Future Value = " + futureValue);
    }
}





// 1. Recursion (Theory)
// What is Recursion?

// Recursion is a technique where a method calls itself to solve a smaller version of the same problem.

// Example
// void CountDown(int n)
// {
//     if(n == 0)
//         return;

//     Console.WriteLine(n);

//     CountDown(n - 1);
// }

// Here the function calls itself.

// 2. Problem

// Suppose:

// Current Value = 10000

// Growth Rate = 10%

// Years = 3

// Then:

// Year 1 = 11000

// Year 2 = 12100

// Year 3 = 13310

// We will calculate this recursively.