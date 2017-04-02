// https://leetcode.com/problems/reverse-linked-list/#/description

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
        
        if(head == null || head.next == null)
            return head;
        
        ListNode next = head.next;
        head.next = null;
        
        while(head != null && next != null) {
            ListNode temp = next.next;
            next.next = head;
            
            head = next;
            next = temp;
        }
        
        return head;
        
    }
}