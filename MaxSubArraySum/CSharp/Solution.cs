/**
动态规划的实现方式
假设另状态dp[i]表示num[i]结尾的最大连续子序列和的最大值，那么dp[i]有以下两种情况
 1.这个最大和子序列只有nums[i]一个元素,那么dp[i] = nums[i];
 2.这个最大和子序列有多个，其实位置为nums[p]，其中p<i;那么dp[i] = dp[i-1]+nums[i];
所以状态转移方程为：
f(n) = max(nums[n],dp[n-1]+nums[n]) 其中n>0
f(n) = nums[n] n==0;
**/
public class Solution {
    public int MaxSubArray(int[] nums) {
        if(nums==null || nums.Length==0){
            return 0;
        }
        
        int max = nums[0];
        int[] dp=new int[nums.Length];
        dp[0] = nums[0];
        for(int i=1;i<nums.Length;i++){
            dp[i] = Math.Max(nums[i],dp[i-1]+nums[i]);
            if(max<dp[i]){
                max = dp[i];
            }
        }
        
        return max;
    }
}
