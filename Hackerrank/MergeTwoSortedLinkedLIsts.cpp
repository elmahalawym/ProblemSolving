/*
  Merge two sorted lists A and B as one linked list
  Node is defined as 
  struct Node
  {
     int data;
     struct Node *next;
  }
*/

Node* GetSmallerNode(Node* node1, Node* node2) {
    return node1->data < node2->data ? node1 : node2;
}

Node* GetHeadOfNewList(Node* &headA, Node* &headB) {
    
    Node* result = GetSmallerNode(headA, headB);

    if(headA->data < headB->data)
        headA = headA->next;
    else
        headB = headB->next;
    
    return result;
}

void AppendListToNode(Node* node, Node* listHead) {
    while(listHead != NULL) {
        node->next = listHead;
        listHead = listHead->next;
        node = node->next;
    }
}

void MergeListsToHead(Node* head, Node* headA, Node* headB) {
   
    Node* cur = head;
    while(headA != NULL && headB != NULL) {
        cur->next = GetHeadOfNewList(headA, headB);
        cur = cur->next;
    } 
    
    AppendListToNode(cur, headA);
    AppendListToNode(cur, headB);
}

Node* MergeLists(Node *headA, Node* headB)
{
    if(headA == NULL) return headB;
    if(headB == NULL) return headA;
    
    Node* result = GetHeadOfNewList(headA, headB);
    
    MergeListsToHead(result, headA, headB);
    
    return result;
}
