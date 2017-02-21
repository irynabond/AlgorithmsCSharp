using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class TreeNode
    {
        public TreeNode(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }

        public int Data { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public static TreeNode GenerateTree()
        {
            TreeNode root = new TreeNode(1);
            root.Left = new TreeNode(2);
            root.Left.Left = new TreeNode(4);
            root.Left.Right = new TreeNode(5);
            root.Right = new TreeNode(3);
            return root;
        }
    }
    class PreOrderTreeTraversal
    {
        public static void Traverse(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count!=0)
            {
                var node = stack.Pop();
                Console.WriteLine(node.Data);

                if (node.Right!=null)
                {
                    stack.Push(node.Right);
                }
                if (node.Left!=null)
                {
                    stack.Push(node.Left);
                }
            }
        }

        public static void PreOrderTraversal()
        {
            TreeNode root = TreeNode.GenerateTree();
            Traverse(root);
        }
    }
}
