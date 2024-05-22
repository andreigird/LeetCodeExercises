//You are given an integer array prices where prices[i]
//is the price of a given stock on the ith day.

//On each day, you may decide to buy and/or sell the stock.
//You can only hold at most one share of the stock at any time.
//However, you can buy it then immediately sell it on the same day.

//Find and return the maximum profit you can achieve.
//You are given an integer array prices where prices[i]
//is the price of a given stock on the ith day.

//On each day, you may decide to buy and/or sell the stock.
//You can only hold at most one share of the stock at any time.
//However, you can buy it then immediately sell it on the same day.

//Find and return the maximum profit you can achieve.
class Program
{
    public int MaxProfit(int[] prices)
    {
        var profit = 0;

        int buyDay = 0;
        int sellDay = 0;

        int buy = prices[buyDay];
        int sell = prices[sellDay];

        for (int i = 1; i < prices.Length; i++)
        {

            if (buy >= prices[i - 1] && buyDay <= i - 1 && i - 1 >= sellDay)
            {
                buy = prices[i - 1];
                buyDay = i - 1;
                sell = buy;
            }
            if (buy > prices[i] && buyDay <= i && i >= sellDay)
            {
                buy = prices[i];
                buyDay = i;
                sell = buy;
            }
            if (sell < prices[i] && i > sellDay)
            {
                sell = prices[i];
                sellDay = i;
            }
            if (sell - buy > 0)
            {
                profit = profit + (sell - buy);
                buy = prices.Max();
                sell = 0;
            }

        }
        return profit;
    }
    static void Main(string[] args)
    {
        int[] prices = [7, 6, 4, 3, 1];
        //[6,1,3,2,4,7]

        var profit = new Program().MaxProfit(prices);
        
        Console.WriteLine("Profit: " + profit);

    }

}