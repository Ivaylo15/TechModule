using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numberOfPrices = int.Parse(Console.ReadLine());
        double significanceThreshold = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPrices - 1; i++)
        {
            double prices = double.Parse(Console.ReadLine());
            double difrenceInPrices = DifrenceInPrices(lastPrice, prices);
            bool IsThereADifrenc = IsThereADifrence(difrenceInPrices, significanceThreshold);
            Console.WriteLine(conditionOfPrice(prices, lastPrice, difrenceInPrices, IsThereADifrenc));
            lastPrice = prices;
        }
    }
    private static string conditionOfPrice(double prices, double lastPrice, double difrenceInPrices, bool IsThereADifrence)
    {
            string changeOfPrice = "";
        if (difrenceInPrices == 0)
        {
            changeOfPrice = string.Format($"NO CHANGE: {prices}");
        }
        else if (!IsThereADifrence)
        {
            changeOfPrice = string.Format($"MINOR CHANGE: {lastPrice} to {prices} ({difrenceInPrices * 100:F2}%)");
        }
        else if (IsThereADifrence && (difrenceInPrices > 0))
        {
            changeOfPrice = string.Format($"PRICE UP: {lastPrice} to {prices} ({difrenceInPrices * 100:F2}%)");
        }
        else if (IsThereADifrence && (difrenceInPrices < 0))
        {
            changeOfPrice = string.Format($"PRICE DOWN: {lastPrice} to {prices} ({difrenceInPrices * 100:F2}%)");
        }
        return changeOfPrice;
    }
    private static bool IsThereADifrence(double significanceThreshold, double difrenceInPrices)
    {
        if (Math.Abs(significanceThreshold) >= difrenceInPrices)
        {
            return true;
        }
        return false;
    }
    private static double DifrenceInPrices(double lastPrice, double prices)
    {
        double difrenceInPrices = (prices - lastPrice) / lastPrice;
        return difrenceInPrices;
    }
}
