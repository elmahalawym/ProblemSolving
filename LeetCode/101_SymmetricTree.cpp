// https://leetcode.com/problems/symmetric-tree/
// 101. Symmetric Tree

/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode(int x) : val(x), left(NULL), right(NULL) {}
 * };
 */

 // recursive
class Solution {
    
    bool areTreesEqual(TreeNode* node1, TreeNode* node2) {
        
        if(node1 == NULL && node2 == NULL)
            return true;
        
        if(node1 == NULL || node2 == NULL)
            return false;
        
        return node1->val == node2->val &&
               areTreesEqual(node1->left, node2->right) &&
               areTreesEqual(node1->right, node2->left);
    }
    
public:
    bool isSymmetric(TreeNode* root) {
        
        if(root == NULL)
            return true;
            
        return areTreesEqual(root->left, root->right);
    }
};


// iterative
class Solution {
    
public:
    bool isSymmetric(TreeNode* root) {
        
        if(root == NULL)
            return true;
        
        pair<TreeNode*, TreeNode*> cur(root->left, root->right);
        queue<pair<TreeNode*, TreeNode*> > q;
        q.push(cur);
        
        while(!q.empty()) {
            pair<TreeNode*, TreeNode*> cur = q.front();
            
            TreeNode* n1 = cur.first;
            TreeNode* n2 = cur.second;
            
            // if only one of the two nodes is null
            if((n1 == NULL && n2 != NULL) ||
                (n1 != NULL && n2 == NULL))
                return false;
            
            if(n1 != NULL && n2 != NULL &&
                (n1->val != n2->val))
                return false;

            if(n1 != NULL && n2 != NULL) {
                q.push(make_pair(n1->left, n2->right));
                q.push(make_pair(n1->right, n2->left));
            }
            
            q.pop();
        }
        
        return true;
    }
};