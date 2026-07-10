public class Solution {
    public int MaxProfit(int[] prices) {
        int left = 0;
        int right = 1;
        int maxProfit = 0;

        while(right < prices.Length){
            if (prices[right] < prices[left]){
                left = right;
            }else{
                if (prices[right] - prices[left] > maxProfit){
                    maxProfit = prices[right] - prices[left];
                }
            }
            right += 1;
        }

        return maxProfit;
    }
}
