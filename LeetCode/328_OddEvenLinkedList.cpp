/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
class Solution {
public:
    ListNode* oddEvenList(ListNode* head) {
        
        if(head == NULL || head->next == NULL)
            return head;
        
        ListNode* n1 = head;
        ListNode* n2 = head->next;
        ListNode* evenHead = head->next;
        
        
        while(n2 && n2->next) {
            n1->next = n1->next->next;
            n2->next = n2->next->next;
            
            n1 = n1->next;
            n2 = n2->next;
        }
        
        n1->next = evenHead;
        
        return head;
    }
};