/**
解决方法二：
和方法一类似，先需要对数组nums进行排序，排序的方法采用线性复杂度的计数排序的方式
时间会比快速排序快上很多。但是需要额外的空间。
**/
public class Solution {
    public int FindKthLargest(int[] nums, int k) {
       int max = nums[0];
        int min = nums[0];
        for(int i=0;i<nums.Length;i++){
            if(max<nums[i]){
                max = nums[i];
            }
            if(min>nums[i]){
                min = nums[i];
            }
        }
        
        int[] bucket=new int[max-min+1];
        for(int i=0;i<nums.Length;i++){
            bucket[nums[i]-min]++;
        }
        
        int index = bucket.Length-1;
        int count=0;
        while(index>=0&&(bucket[index]+count)<k){
            count+=bucket[index];
            index--;            
        }
        
        return index+min;
    }
    
    private void FastSort(int[] nums,int start,int end,int k){
        if(start >= end || start > k){
            return;
        }
        
        int index = start;
        int left = start;
        int right = end>k?k:end;
        while(left<right){
           while(left<right && nums[index]>nums[right]) {
               right--;
           }
            
           while(left<right && nums[index]<nums[left]) {
               left--;
           }
            
            int tmp = nums[left];
            nums[left]=nums[right];
            nums[right]=tmp;
        }
        
        int t = nums[index];
        nums[index]=nums[left];
        nums[left] = t;
        
        FastSort(nums,start,left-1,k);
        FastSort(nums,left+1,end,k);
    }
    
    
}
