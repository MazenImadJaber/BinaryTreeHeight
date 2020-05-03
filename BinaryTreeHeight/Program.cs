using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeHeight
{
    // A Binary Tree Node
    class node
    {
        public node left;
        public int data;
        public node right;
    }

  

    class Program
    {
        // Iterative method to find height of Bianry Tree
        static int treeHeight(node root)
        {
            // Base Case
          if (root == null)
            {
                return 0;
            }
                
         
            // Create an empty queue of node pointers for level order traversal
            Queue<node> q = new Queue<node>();

            // Enqueue Root and initialize height
            q.Enqueue(root);
            int hight = 0 ;
          
            while (true)
            {
                // nodeCount (queue size) indicates number of nodes
                // at current lelvel.
                int nodeCount = q.Count;
                if(nodeCount == 0)
                {
                    return hight;
                }


                hight++;
                // Dequeue all nodes of current level and Enqueue all
                // nodes of next level
                while (nodeCount > 0)
                {

                    node node = q.Peek();
                    q.Dequeue();

                    if(node.left != null)
                    {
                        q.Enqueue(node.left);
                    }
                    if(node.right != null)
                    {
                        q.Enqueue(node.right);
                    }
                    nodeCount--;
                }
            }
        }


        // Utility function to create a new tree node
        static node newNode(int data)
        {
            node temp = new node();
            temp.data = data;
            temp.left = null;
            temp.right = null;
            return temp;
        }
        static void Main(string[] args)
        {
            // Let us create binary tree shown in above diagram
            node root = newNode(1);
            root.left = newNode(2);
            root.right = newNode(3);
            root.left.left = newNode(4);
            root.left.right = newNode(5);

            Console.WriteLine( "Height of tree is " + treeHeight(root));
            Console.ReadLine();
        }


    }
}
