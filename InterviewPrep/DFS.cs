using System;
using System.Collections.Generic;
using System.Text;

namespace BFSandDFS
{
    partial class Program
    {
        public static void RunDFSTraversal(Node node, string data)
        {
            if (node == null)
            {
                return;
            }

            if (node.Data == data)
            {
                Console.WriteLine("Found " + node.Data + ". Returning ...");
                return;
            }

            Console.WriteLine(node.Data + " ");
            RunDFSTraversal(node.Left, data);
            RunDFSTraversal(node.Right, data);
        }
    }
}
