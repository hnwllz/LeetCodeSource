/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
/*
方法二：
1.重新定义链条的头dump，用于删除head
2.定义两个指针，分别指向链表的头dump和之后的n+1个node。这样两个指针的偏差相差n+1
3.移动连个指针，让第一个指针移动链表的末尾，这样第二个指针的下一个元素为需要删除的元素。
*/
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode dump = new ListNode(0);
        dump.next = head;
        ListNode first = dump;
        ListNode second = dump;
            
        for(int i = 0; i < n+1;i++){
            if(first == null){
                return head;
            } 
            first = first.next;                            
        }
        
        while(first != null){
            first = first.next;
            second = second.next;
        }
        
        second.next = second.next.next;
        
        return dump.next;
    }
}
