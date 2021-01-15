using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree myBST = new BinarySearchTree();

            Node node5 = new Node(5);
            Node node2 = new Node(2);
            Node node11 = new Node(11);
            Node node18 = new Node(18);
            Node node1 = new Node(1);
            Node node33 = new Node(33);
            Node node7 = new Node(7);

            myBST.AddNode(node5);
            myBST.AddNode(node2);
            myBST.AddNode(node11);
            myBST.AddNode(node18);
            myBST.AddNode(node1);
            myBST.AddNode(node33);
            myBST.AddNode(node7);
            Console.WriteLine("TEST COMPLETE");
            Console.ReadLine();
        }
    }
}
