using System;
using System.Collections.Generic;
using System.Text;
using TechnicalCS.TechDemos.Printers;

namespace TechnicalCS.TechDemos.DataStructures
{

    class BinarySearchTree<T>
    {
        public BSTNode<T> Root;

        public void Insert(BSTNode<T> nodeIn)
        {
            if (Root == null)
            {
                Root = nodeIn;
                return;
            }

            BSTNode<T> currentNode = Root;

            BSTNode<T> previousNode = null;

            // Find where to insert nodeIn
            while (currentNode != null)
            {
                previousNode = currentNode;
                if (nodeIn.Key < currentNode.Key)
                {
                    currentNode = currentNode.Left;
                }
                else
                {
                    currentNode = currentNode.Right;
                }
            }

            // Add nodeIn to the subtree of the last traversed node.
            if (nodeIn.Key < previousNode.Key)
            {
                previousNode.Left = nodeIn;
            }
            else
            {
                previousNode.Right = nodeIn;
            }

        }

        public BSTNode<T> Search(int key)
        {
            var currentNode = Root;

            while (currentNode != null)
            {
                if (key == currentNode.Key)
                {
                    return currentNode; //Found item for key
                }

                if (key < currentNode.Key)
                {
                    currentNode = currentNode.Left;
                }
                else if (key > currentNode.Key)
                {
                    currentNode = currentNode.Left;
                }
            }

            return null; //Did not find item for given key
        }

        public void Delete(int key)
        {

            if (key == Root.Key)
            {
                var toDeleteNode = Root;
                var successor = FindInorderSuccessor(toDeleteNode);
                Root = successor[1]; //set to successor
                CopyLinks(toDeleteNode, Root);
                //remove link from parent of successor to successor
                if (successor[0] != null)
                {
                    var pos = CheckNodeChildrenForKey(successor[0], successor[1].Key);
                    successor[0][pos] = null; //set link from parent to child to null
                }
            }

            var currentNode = Root;
            while (currentNode != null)
            {
                NodePosition foundNodePosition = CheckNodeChildrenForKey(currentNode, key);
                BSTNode<T> toDeleteNode = currentNode[foundNodePosition];

                if (toDeleteNode != null) // found node with key
                {
                    var childrenPositions = GetChildPositions(toDeleteNode);

                    if (childrenPositions.Count == 0) //LEAF Node
                    {
                        // Just remove the link to the node that should be deleted
                        currentNode[foundNodePosition] = null;
                        return;
                    }
                    else if (childrenPositions.Count == 1)
                    {
                        // Set the link to the node to the only child of the node that is being deleted
                        currentNode[foundNodePosition] = toDeleteNode[childrenPositions[0]];
                    }
                    else if (childrenPositions.Count == 2)
                    {
                        // Set the link to the node to the inorder successor of the node that's being deleted
                        var successor = FindInorderSuccessor(toDeleteNode);
                        currentNode[foundNodePosition] = successor[1];
                        CopyLinks(toDeleteNode, currentNode[foundNodePosition]);

                        //remove link from parent of successor to successor
                        if (successor[0] != null)
                        {
                            var pos = CheckNodeChildrenForKey(successor[0], successor[1].Key);
                            successor[0][pos] = null; //set link from parent to child to null
                        }

                    }
                }
                else
                {
                    if (key < currentNode.Key)
                    {
                        currentNode = currentNode.Left;
                    }
                    else
                    {
                        currentNode = currentNode.Right;
                    }
                }
            }
        }

        public void CopyLinks(BSTNode<T> from, BSTNode<T> to)
        {
            if (from.Left != null && from.Left != to)
            {
                to.Left = from.Left;
            }
            if (from.Right != null && from.Right != to)
            {
                to.Right = from.Right;
            }
        }

        public BSTNode<T>[] FindInorderSuccessor(BSTNode<T> node)
        {
            return FindMinNode(node.Right);
        }

        public BSTNode<T>[] FindMinNode(BSTNode<T> node)
        {
            BSTNode<T> previous = null;
            var current = node;
            while (current.Left != null)
            {
                previous = current;
                current = current.Left;
            }
            return new BSTNode<T>[] { previous, current };
        }

        public NodePosition CheckNodeChildrenForKey(BSTNode<T> parent, int key)
        {
            if (parent.Left != null)
            {
                if (parent.Left.Key == key)
                {
                    return NodePosition.LEFT;
                }
            }
            if (parent.Right != null)
            {
                if (parent.Right.Key == key)
                {
                    return NodePosition.RIGHT;
                }
            }
            return NodePosition.NONE;

        }

        public bool IsLeafNode(BSTNode<T> node)
        {
            return node.Left == null && node.Right == null;
        }

        public List<NodePosition> GetChildPositions(BSTNode<T> node)
        {
            var positions = new List<NodePosition>();
            if (node.Left != null)
            {
                positions.Add(NodePosition.LEFT);
            }
            if (node.Right != null)
            {
                positions.Add(NodePosition.RIGHT);
            }
            return positions;
        }

        public void BreadthFirstTraverse(Action<BSTNode<T>> nodeFoundAction)
        {
            Queue<BSTNode<T>> nodesToWalk = new Queue<BSTNode<T>>();

            nodesToWalk.Enqueue(Root);

            while (nodesToWalk.Count > 0)
            {
                var node = nodesToWalk.Dequeue();

                nodeFoundAction(node);

                if (node.Left != null)
                {
                    nodesToWalk.Enqueue(node.Left);
                }
                if (node.Right != null)
                {
                    nodesToWalk.Enqueue(node.Right);
                }
            }
        }

        public void PrintAsTree()
        {
            Root.Print();
        }

    }
}
