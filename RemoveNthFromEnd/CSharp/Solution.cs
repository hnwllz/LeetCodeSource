/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
/*
方法一：
1.先计算链表的长度
2.再计算倒数n对应的索引位置index
3.移除index对应的ListNode
*/
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode point = head;
        int count = 0;
        while(point != null){
            point = point.next;
            count++;
        }
        
       int index = 0;
       point = head;
       ListNode pre=null;
       while(point != null && index != (count-n)){
           index++;
           pre = point;
           point = point.next;
          
       }
        
       if(pre==null){
           head = point.next;
       }
        else if(point!=null){
            pre.next = point.next;
        }
        
        return head;
    }
}
