/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head == null || head.next == head) return head;

        ListNode _cur = null;
        ListNode _next = head;

        while (_next != null){
            head = _next;
            _next = head.next;
            head.next = _cur;
            _cur = head;
        }

        return _cur;
    }
}
