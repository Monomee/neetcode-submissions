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
        ListNode _pre = null;

        while (head != null){
            ListNode temp = head.next;
            head.next = _pre;
            _pre = head;
            head = temp;
        }

        return _pre;
    }
}
