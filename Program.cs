namespace validate_binary_search_tree
{
    internal class Program
    {
        //Problem link: https://leetcode.com/problems/validate-binary-search-tree/description
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public bool IsValidBST(TreeNode root)
        {
            return IsValidBSTHelper(root, long.MinValue, long.MaxValue);
        }

        private bool IsValidBSTHelper(TreeNode node, long lower, long upper)
        {
            if (node == null)
            {
                return true;
            }

            // The current node's value must be greater than the lower bound and less than the upper bound.
            if (node.val <= lower || node.val >= upper)
            {
                return false;
            }

            // Recursively check the left and right subtrees with updated bounds.
            return IsValidBSTHelper(node.left, lower, node.val) &&
                   IsValidBSTHelper(node.right, node.val, upper);
        }
    }

}
