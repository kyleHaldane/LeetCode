/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if(root == null)
            return null;
        TreeNode newRoot = new TreeNode(root.val);
        newRoot = createInverse(root, newRoot);
        return newRoot;
        
    }
    public TreeNode createInverse(TreeNode oldRoot, TreeNode newRoot)
        {
            if(oldRoot.left != null)
            {
                TreeNode rightNode = new TreeNode(oldRoot.left.val);
                newRoot.right = rightNode;
                createInverse(oldRoot.left, newRoot.right);
            }
            if(oldRoot.right != null)
            {
                TreeNode leftNode = new TreeNode(oldRoot.right.val);
                newRoot.left = leftNode;
                createInverse(oldRoot.right, newRoot.left);
            }
            return newRoot;
        }
}
        