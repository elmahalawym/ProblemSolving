#include <stack>
/*
  Get Nth element from the end in a linked list of integers
  Number of elements in the list will always be greater than N.
  Node is defined as 
  struct Node
  {
     int data;
     struct Node *next;
  }
*/
int GetNode(Node *head,int positionFromTail)
{
    stack<Node*> stack;
    
    while(head != NULL) {
        stack.push(head);
        head = head->next;
    }
    
    while(positionFromTail--) stack.pop();
        
    return stack.top()->data;
}
