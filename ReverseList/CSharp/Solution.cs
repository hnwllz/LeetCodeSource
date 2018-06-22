/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if(head == null){
            return null;
        }
        
        ListNode newHead = head;
        ListNode next = head.next;
        newHead.next = null;
        
        while(next != null){            
            ListNode nnext = next.next;
            next.next = newHead;
            newHead = next;
            next = nnext;
        }
        
        return newHead;
    }
}
