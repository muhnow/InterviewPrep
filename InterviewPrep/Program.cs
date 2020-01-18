using System;

namespace BFSandDFS
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Node tree = GetSampleTree();

            //RunBFSTraversal(tree);
            RunDFSTraversal(tree, "F");

        }

        public static Node GetSampleTree()
        {
            // Leafs
            Node H = new Node("H");
            Node F = new Node("F");
            Node C = new Node("C");
            Node D = new Node("D");

            Node G = new Node("G", H, null);
            Node E = new Node("E", F, G);
            Node B = new Node("B", C, D);
            Node A = new Node("A", B, E);

            return A;
        }
    }
}
