

/*
解决方案一：
按照常规的思考方式，将第二个数组的元素按照顺序依次插入到第一个数组中，这样需要解决的是插入的位置及后面的元素需要后移一位。
这样这种算法的时间复杂度为O(m*n),空间复杂度为O(1)
*/
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        
        int q = 0;
        for(int i=0;i<n;i++){
            while(nums1[q]<=nums2[i]&&q<m){
                q++;
            }
            
            int p=m;
            while(p>q){
                nums1[p]=nums1[p-1];
                p--;
            }
            
            nums1[q] = nums2[i];
            q++;
            m++;
        }
    }
}
