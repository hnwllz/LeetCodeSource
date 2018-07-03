/**
方法一：
常规的方式，顺序遍历价格数组，然后和后续价格比较，保存价格收益最大的收益即可
时间复杂度：O(n-1 + n-2 + ...+ 1) = O((n-1)*(n-2)/2) = O(n^2);
空间复杂度：O(1)
public class Solution {
    public int MaxProfit(int[] prices) {
        int n = prices.Length;
        int max = 0;
        for(int i=0;i<n-1;i++){
            for(int j=i+1;j<n;j++){
                if(prices[j] - prices[i]>max ){
                    max = prices[j] - prices[i];
                }
            }
        }
        
        return max;
    }
}

方法二
动态规划的方式，
最优子结构f(n)为Max(f(n-1),p[n]-g(n)),其中g(n)为最低价格Min(g(n-1),p[n])
状态转移方程
        p[0] n==0
g(n) = 
        min(g(n-1),p[n]) n>0
      
        0 n==0
f(n) =
        max(f(n-1),p[n] - g(n)) n>1
**/ 

public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices==null || prices.Length <= 1){
            return 0;
        }
        
        int minPrice = prices[0];
        int maxProfit = 0;
        for(int i=1;i<prices.Length;i++){
            if(minPrice > prices[i]){
                minPrice = prices[i];
            }
            
            if(maxProfit < prices[i]-minPrice){
                maxProfit = prices[i]-minPrice;
            }
        }
        
        return maxProfit;
    }
}
