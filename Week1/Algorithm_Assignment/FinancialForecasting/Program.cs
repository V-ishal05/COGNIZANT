using System;
using FinancialForecasting.Services;

namespace FinancialForecasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForecastService forecast = new ForecastService();

            double currentRevenue = 100000;
            double growthRate = 0.10; // 10%
            int years = 5;

            double predictedRevenue =
                forecast.PredictFutureValue(currentRevenue, growthRate, years);

            Console.WriteLine("Current Revenue : " + currentRevenue);

            Console.WriteLine("Growth Rate : " + (growthRate * 100) + "%");

            Console.WriteLine("Years : " + years);

            Console.WriteLine();

            Console.WriteLine("Predicted Revenue after " + years +
                              " years = " + predictedRevenue);

            Console.ReadKey();
        }
    }
}