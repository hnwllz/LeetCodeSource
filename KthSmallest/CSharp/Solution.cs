/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
/**
解题思路：
设x是二叉搜索树中的一个结点。如果y是x左子树中的一个结点，那么会有y.key<=x.key；如果y是x右子树中的一个节点，那么有y.key>=x.key。
所以利用二叉树的先序遍历，即可按顺序统计前k个节点。
**/
public class Solution {
    public int KthSmallest(TreeNode root, int k) {
        if(root == null){
            return -1;
        }
        
        TreeNode cur = root;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        int index = 0;
        while(cur != null || stack.Count > 0){
            while(cur != null){
                stack.Push(cur);
                cur = cur.left;
            }
            
            if(stack.Count>0){
                index++;
                cur = stack.Pop();
                if(index == k){
                    return cur.val;
                }
                
                cur = cur.right;
            }
        }
        
        return -1;
    }
}
