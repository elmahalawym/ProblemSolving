/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

// 1 -> 2 -> 3 -> 4 -> 5, n = 3
public class Solution {
    
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
     
        if(head == null)
            return null;
        
        ListNode prev = null;
        ListNode start = head;
        ListNode end = start;
        
        for(int i=0; i<n; i++) {
            end = end.next;
        }
        
        while(end != null) {
            end = end.next;
            prev = start;
            start = start.next;
        }
        
        if(prev == null)
            return head.next;
        
        prev.next = start.next;
        return head;
    }
}