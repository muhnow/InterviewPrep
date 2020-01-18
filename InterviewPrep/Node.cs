using System;
using System.Collections.Generic;
using System.Text;

namespace BFSandDFS
{
    public class Node
    {
        public string Data { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }

        public Node(string data, Node left, Node right)
        {
            this.Data = data;
            this.Left = left;
            this.Right = right;
        }

        public Node(string data)
        {
            this.Data = data;
            this.Left = this.Right = null;
        }
    }   
}
