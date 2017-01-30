/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode(int x) : val(x), left(NULL), right(NULL) {}
 * };
 */
class Solution {
    void swapNodes(TreeNode* &node1, TreeNode* &node2) {
        TreeNode* temp = node1;
        node1 = node2;
        node2 = temp;
    }
public:
    TreeNode* invertTree(TreeNode* root) {
        
        if(root == NULL)
            return NULL;
            
        swapNodes(root->left, root->right);
        
        invertTree(root->left);
        invertTree(root->right);
        
        return root;
    }
};