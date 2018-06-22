/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
/*
这种问题有一下几种方式：
1.使用数组或者List保存链表中的节点，将判断回文链表转换为判断回文数组问题。
  但是这种方式的时间复杂度为O(n)，空间复杂度为O(n)。不符合进阶要求
  
2.寻找链表的中间节点，然后将后半段链表反序，然后和前半段链表比对，如果对应位置的值都一样，则是回文链表。
寻找链表中间节点方式
a.统计链表节点数量，然后通过位移n/2来查找
b.通过快慢指针来查找（当前使用的方式）

*/
public class Solution {
    public bool IsPalindrome(ListNode head) {
       ListNode fast = head,slow=head;
       ListNode tail = null;
        //利用快慢指针的方法找到链表的中央的节点
        while(fast!=null && fast.next!=null){
            slow = slow.next;
            fast = fast.next.next;
        }
        
        if(fast == null){
            tail = ReverseList(slow);
        }
        else{
            tail = ReverseList(slow.next);
        }
        
        while(head!=null&&tail!=null){
            if(head.val != tail.val){
                return false;
            }
            
            head = head.next;
            tail = tail.next;
        }
        
        return true;
    }
    
    private ListNode ReverseList(ListNode head) {
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
