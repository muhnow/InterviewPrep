using System;
using System.Collections.Generic;
using System.Text;

namespace BFSandDFS
{
    partial class Program
    {
        public static void RunBFSTraversal(Node node)
        {
            Queue<Node> q = new Queue<Node>();

            q.Enqueue(node);

            while(q.Count > 0)
            {
                node = q.Dequeue();

                Console.WriteLine(node.Data);

                if(node.Left != null)
                {
                    q.Enqueue(node.Left);
                }

                if(node.Right != null)
                {
                    q.Enqueue(node.Right);
                }
            }
        }
    }
}
