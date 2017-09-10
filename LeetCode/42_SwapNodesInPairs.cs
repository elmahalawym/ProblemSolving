/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

public class Solution {
    public ListNode SwapPairs(ListNode head) {
        
        var start = head;
        ListNode prev = null;
        
        while(start != null && start.next != null) {
            var first = start;
            var second = start.next;
            var next = start.next.next;
            
            start = second;
            start.next = first;
            start.next.next = next;
            start = next;
            if(prev != null) prev.next = second;
            else head = second;
            prev = first;
        }
        return head;
    }
}