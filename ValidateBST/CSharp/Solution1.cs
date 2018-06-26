/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
/*
解决方法二：
解题思路：
1.在对合法二叉树进行遍历时，中序遍历的方式能够得到一个有序的数组
2.该数组是一个递增的数组，前一个元素小于后一个元素

分析：
时间复杂度O(n)，空间复杂度(1)。如果不用一个遍历pre存储上一个元素，而是用数组来存储所有元素空间复杂度为O(n)
*/
public class Solution {
    
    private TreeNode pre = null;
    public bool IsValidBST(TreeNode root) {
        if(root==null){
            return true;
        }
        if(!IsValidBST(root.left)){
            return false;
        }
        if(pre != null && pre.val >= root.val){
            return false;
        }
        
        pre = root;
        
        if(!IsValidBST(root.right)){
            return false;
        }
        
        return true;
    }
}
