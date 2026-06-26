package forecasting;

public class FinancialForecast {

    public static double predictValue(
            double initialAmount,
            double annualGrowth,
            int remainingYears) {

        if (remainingYears <= 0) {
            return initialAmount;
        }

        double updatedAmount = initialAmount + (initialAmount * annualGrowth);

        return predictValue(
                updatedAmount,
                annualGrowth,
                remainingYears - 1);
    }
}