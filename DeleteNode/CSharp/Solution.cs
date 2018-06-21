/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
        /*
        在做这道题时，思想有点限制于一定在于删除给定的node，所以总想知道head的存在
        实际是可以将要删除的node的后一个node状态复制过来，然后将node当head来删除下一个node。
        但是这种方式只能用于要删除的node不是最后的一个
        */
       node.val = node.next.val;
       node.next = node.next.next;
    }
}
