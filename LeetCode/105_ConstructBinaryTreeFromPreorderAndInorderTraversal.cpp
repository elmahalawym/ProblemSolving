// https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/

#include <iostream>
#include <cstdio>
#include <vector>
#include <queue>
#include <cstring>
#include <sstream>

using namespace std;

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
    
    int search(int arr[], int key, int start, int end) {
		for (int i = start; i <= end; ++i) {
			if (key == arr[i])
				return i;
		}
		return -1;
	}
    
    TreeNode* buildTree(int preorder[], int inorder[], int preorderStart, int preorderEnd, int inorderStart, int inorderEnd) {
		
		if (preorderEnd < preorderStart)
			return NULL;
		
		TreeNode* root = new TreeNode(preorder[preorderStart]);

		int idx = search(inorder, root->val, inorderStart, inorderEnd);

		root->left = buildTree(preorder, inorder, preorderStart + 1, preorderStart + idx - inorderStart, inorderStart, idx - 1);
		root->right = buildTree(preorder, inorder, preorderStart + idx - inorderStart + 1, preorderEnd, idx + 1, inorderEnd);

		return root;
	}
	
public:
    TreeNode* buildTree(vector<int>& preorder, vector<int>& inorder) {
        return buildTree(&preorder[0], &inorder[0], 0, preorder.size() - 1, 0, inorder.size() - 1);
    }
};