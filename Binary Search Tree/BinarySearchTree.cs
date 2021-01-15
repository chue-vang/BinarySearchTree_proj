using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class BinarySearchTree
    {
        public Node RootNode;

        public BinarySearchTree()
        {

        }

        public void AddNode(Node nodeToAdd)
        {
            if (RootNode == null)
            {
                RootNode = nodeToAdd;
            }
            else
            {
                Node currentNode = RootNode;
                while (true)
                {
                    if (nodeToAdd.data < currentNode.data)
                    {
                        if (currentNode.LeftNode == null)
                        {
                            currentNode.LeftNode = nodeToAdd;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.LeftNode;
                        }
                    }
                    else if (nodeToAdd.data > currentNode.data)
                    {
                        if (nodeToAdd.data > currentNode.data)
                        {
                            if (currentNode.RightNode == null)
                            {
                                currentNode.RightNode = nodeToAdd;
                                break;
                            }
                            else
                            {
                                currentNode = currentNode.RightNode;
                            }
                        }
                    }
                }
            }
        }
    }
}
