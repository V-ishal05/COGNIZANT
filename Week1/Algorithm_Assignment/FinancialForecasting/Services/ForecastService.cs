namespace FinancialForecasting.Services
{
    public class ForecastService
    {
        // Recursive Forecast Method
        public double PredictFutureValue(double currentValue, double growthRate, int years)
        {
            if (years == 0)
                return currentValue;

            return PredictFutureValue(currentValue * (1 + growthRate), growthRate, years - 1);
        }
    }
}