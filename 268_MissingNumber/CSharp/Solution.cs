
/**
三种方式：
第一种，求和
先求出数组元素的和，然后通过公式计算 (l*(l+1))/2计算原本不缺数字时的和，其中l是数组的长度。
两个和的差就是缺失的数字了

第二种，亦或的方式
以后有如下特性：
a^a=0
a^b^c^b^a = b;
所以可以利用此特性来寻找缺失的数字

public class Solution {
    public int MissingNumber(int[] nums) {
        int sum=0;
        for(int i=0;i<nums.Length;i++){
            sum+=nums[i];
        }
        
        return (nums.Length*(nums.Length+1))/2-sum;
    }
}
**/

public class Solution {
    public int MissingNumber(int[] nums) {
        int xor = 0 ;
        for(int i=0;i<nums.Length;i++){
            xor =xor^i^nums[i];
        }
        
        return xor^nums.Length;//最终别忘记还有最后一个数，因为缺少了一个啊
    }
}
