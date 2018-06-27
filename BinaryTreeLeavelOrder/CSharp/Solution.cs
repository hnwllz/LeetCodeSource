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
按层次遍历二叉树，首先想到的是广度遍历的方式，但是如何区分同一层次的节点。
可以维护两个集合，一个保存当前处理层次下的所有节点，另一用于保存下一层次的节点；当前层次处理完后，切换到下一层次即可。
*/
public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        List<IList<int>> result = new  List<IList<int>>();
        
        if(root == null){
            return result;
        }
        
        List<TreeNode> curNodes = new List<TreeNode>(){root};
        while(curNodes.Count>0){
            List<TreeNode> nextNodes = new List<TreeNode>();
            List<int> lst = new List<int>();
            for(int i=0; i<curNodes.Count;i++){                
                lst.Add(curNodes[i].val);
                
                if(curNodes[i].left!=null){
                    nextNodes.Add(curNodes[i].left);
                }
                if(curNodes[i].right!=null){
                    nextNodes.Add(curNodes[i].right);
                }
            }
            
            result.Add(lst);
            curNodes = nextNodes;
        }
        
        return result;
    }
}
