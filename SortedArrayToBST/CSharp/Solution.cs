/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        return SortedArrayToBSTByIndex(nums,0,nums.Length - 1);
    }
    
    private TreeNode SortedArrayToBSTByIndex(int[] nums,int start,int end){
        if(start > end)
        {
            return null;
        }
        
        if(start == end){
            return new TreeNode(nums[start]);
        }
        
        int mid = (int)Math.Ceiling((start+end)/2.0d);
        TreeNode node = new TreeNode(nums[mid]);
        node.left = SortedArrayToBSTByIndex(nums,start,mid-1);
        node.right = SortedArrayToBSTByIndex(nums,mid+1,end);        
        
        return node;
    }
}
