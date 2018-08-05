/**
解决方法一：
利用快速排序的方式对数组nums进行降序排序，然后返回数组中的
第k个元素即可。最坏的时间复杂度O(n^2)，最好的时间复杂度O(lgn)
此题中还可以有优化的方式，快速排序是一个分治排序的过程，所以可以通过判断k所在的子枝
进行剪枝。
**/
public class Solution {
    public int FindKthLargest(int[] nums, int k) {
       return FastSort(ref nums,0,nums.Length-1,k);
    }
    
    private int FastSort(ref int[] nums,int start,int end,int k){
        if(start == end){
            return nums[start];
        }
        
        int tmp = nums[start];
        int left = start;
        int right = end;
        while(left<right){
           while(left<right && tmp>nums[right]) {
               right--;
           }
           nums[start]=nums[right];
               
           while(left<right && tmp<=nums[left]) {
               left++;
           }
            
           nums[right]=nums[left];
            nums[left]=nums[start];
        }
        
        nums[left] = tmp;
        
        if(left==k-1){
            return nums[left];
        }
        else if(k-1 < left)        
        {
            return FastSort(ref nums,start,left-1,k);            
        }
        else{
            return FastSort(ref nums,left+1,end,k);;
        }
    }
    
    
}
