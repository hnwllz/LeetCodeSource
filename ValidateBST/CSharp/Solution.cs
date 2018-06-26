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
 *解决方法一：
 算法思路：
 1.根节点的值大于左子树所有的节点
 2.根节点的值小于右子树所有的节点
 3.根节点的左右子树都是合法的搜索二叉树(BST:binary search tree)

 分析：
 时间复杂度O(n*n),空间复杂度O(1)
 */
public class Solution {
    public bool IsValidBST(TreeNode root) {
        if(root==null){
            return true;
        }
        
        if(noGreater(root.left,root.val)&&noLess(root.right,root.val)
          &&IsValidBST(root.left)&&IsValidBST(root.right)){
            return true;
        }
        
        return false;
    }
    
    private bool noGreater(TreeNode node,int max){
        if(node == null){
            return true;
        }
        
        if(node.val < max && noGreater(node.left,max) && noGreater(node.right,max)){
            return true;
        }
        
        return false;
    }
    
    private bool noLess(TreeNode node,int min){
        if(node == null){
            return true;
        }
        
        if(node.val > min && noLess(node.left,min) && noLess(node.right,min)){
            return true;
        }
        
        return false;
    }
}
