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

        public bool Search(int value)
        {
            bool searchValue = false;
            if (RootNode.data == value)
            {
                searchValue = true;
            }
            else
            {
                Node currentNode = RootNode;
                while (true)
                {
                    if (value < currentNode.data)
                    {
                        if (currentNode.LeftNode == null)
                        {
                            break;
                        }         
                        else if (currentNode.LeftNode.data == value)
                        {
                            searchValue = true;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.LeftNode;
                        }
                     }
                    else if (value > currentNode.data)
                    {
                        if (currentNode.RightNode == null)
                        {
                            break;
                        }
                        else if ( currentNode.RightNode.data == value)
                        {
                            searchValue = true;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.RightNode;
                        }
                    }
                }                 
            }
            //return true in the 3rd condition
            return searchValue;
        }
    }
}
