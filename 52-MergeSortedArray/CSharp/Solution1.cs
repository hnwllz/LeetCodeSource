
/*
解决方案二：
上面的方法一，是按顺序将数组二的元素插入到数组1，这样会存在位移的情况，但是，如果我们将数组1和数组2反序比较并从数组1的尾部开始插入，这样
就不存在移动数据的问题。
时间复杂度：O(m+n),空间复杂度O(1)
*/
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        /*
        while(m>0||n>0){
            if(m>0&&n>0){
                if(nums1[m-1]>nums2[n-1]){
                    nums1[m+n-1] = nums1[m-1];
                    m--;
                }else{
                    nums1[m+n-1] = nums2[n-1];
                    n--;
                }
            }
            else if(m>0){
                nums1[m+n-1] = nums1[m-1];
                m--;
            }
            else if(n>0){
                nums1[m+n-1] = nums2[n-1];
                n--;
            }
        }
        */
        if(m==0){
            while(n>0){
                nums1[n-1] = nums2[n-1];
                n--;
            }
            
            return;
        }
        
        if(n == 0){
            return;
        }
        
        int n1 = m-1;
        int n2 = n-1;
        
        for(int i=m+n-1;i>=0;i--){
            if(n2<0||(n1>=0 && nums1[n1] >= nums2[n2])){
                nums1[i] = nums1[n1];
                n1--;
            }
            else{
                nums1[i] = nums2[n2];
                n2--;
            }
            
        }
    }
}
