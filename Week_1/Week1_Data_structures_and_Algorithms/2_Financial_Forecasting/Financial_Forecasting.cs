using System;

class FinancialForecast
{
    // Recursive method to calculate future value
    public static double PredictFutureValue(double currentValue, double growthRate, int years)
    {
        if (years == 0)
            return currentValue;

        return PredictFutureValue(currentValue * (1 + growthRate), growthRate, years - 1);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter current value:");
        double currentValue = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter annual growth rate (e.g., enter 0.10 for 10%):");
        double growthRate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter number of years to forecast:");
        int years = Convert.ToInt32(Console.ReadLine());

        double futureValue = PredictFutureValue(currentValue, growthRate, years);
        Console.WriteLine($"\nPredicted value after {years} years: {futureValue:F2}");
    }
}
