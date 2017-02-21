using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class InOrderTreeTraversal
    {
        public static void Traverse(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            var current = root;

            while(stack.Count!=0||current!=null)
            {
                if (current!=null)
                {
                    stack.Push(current);
                    current = current.Left;
                } else
                {
                    var node = stack.Pop();
                    Console.WriteLine(node.Data);
                    current = node.Right;
                }
                
            }
        }
        public static void InOrderTraversal()
        {
            TreeNode root = TreeNode.GenerateTree();
            Traverse(root);
        }
    }
}
