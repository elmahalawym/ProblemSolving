// https://leetcode.com/problems/add-two-numbers/description/
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        
        ListNode head = null;
        ListNode current = null;
        int carry = 0;
        
        while(l1 != null || l2 != null) {
            int currentCount = 0;
            
            if(l1 != null) {
                currentCount += l1.val;
                l1 = l1.next;
            }
            
            if(l2 != null) {
                currentCount += l2.val;
                l2 = l2.next;
            }
            
            currentCount += carry;
            int newValue = currentCount%10;
            carry = currentCount/10;
            
            if(current == null) {
                current = new ListNode(newValue);
                head = current;
            }
            else {
                current.next = new ListNode(newValue);
                current = current.next;
            }
        }
        
        if(carry != 0)
            current.next = new ListNode(carry);
        
        return head;
    }
}