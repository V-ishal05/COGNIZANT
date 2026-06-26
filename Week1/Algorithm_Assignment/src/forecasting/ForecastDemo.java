package forecasting;

public class ForecastDemo {

    public static void main(String[] args) {

        double initialAmount = 10000;
        double growthRate = 0.10;
        int yearsToForecast = 5;

        double estimatedValue =
                FinancialForecast.predictValue(
                        initialAmount,
                        growthRate,
                        yearsToForecast);

        System.out.printf(
                "Estimated Value after %d years: %.2f%n",
                yearsToForecast,
                estimatedValue);
    }
}