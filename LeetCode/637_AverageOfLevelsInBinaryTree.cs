/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<double> AverageOfLevels(TreeNode root) {
        
        if(root == null)
            return new List<double>();
        
        List<double> result = new List<double>();
        
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while(queue.Count() > 0) {
            var current = new AverageAccumulator();
            int count = queue.Count();
            for(int i=0; i<count; i++) {
        
                var cur = queue.Peek();
                current.Add(cur.val);

                if(cur.left != null)
                    queue.Enqueue(cur.left);
                if(cur.right != null)
                    queue.Enqueue(cur.right);
                queue.Dequeue();
                   
            }
            result.Add(current.Average); 
        }
        return result;
    }
    
    private class AverageAccumulator {
        private int count = 0;
        private long sum = 0;
        
        public void Add(long num) {
            count++;
            sum += num;
        }
        
        public double Average => (double)sum/(double)count;
    }
}