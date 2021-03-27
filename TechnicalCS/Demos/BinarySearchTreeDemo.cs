using System;
using System.Collections.Generic;
using System.Text;
using TechnicalCS.TechDemos.DataStructures;

namespace TechnicalCS.TechDemos
{
    class BinarySearchTreeDemo : BaseTechDemo
    {
        BinarySearchTree<string> tree = new BinarySearchTree<string>();

        public BinarySearchTreeDemo() : base("Binary Search Tree")
        {

        }

        protected override void Run()
        {
            Console.WriteLine("A binary search tree is a binary tree where all keys in each node's left subtree are less than its key\n" +
                "and keys in the node's right subtree are greater than its key.");

            PrintSeparator();
            SeedTree();
            tree.PrintAsTree();
            PrintSeparator();
            SearchForExistingKey();
            PrintSeparator();
            DeleteExistingKey(10);
            DeleteExistingKey(15);
            DeleteExistingKey(40);
            DeleteExistingKey(30);
        }

        void SeedTree()
        {
            tree = new BinarySearchTree<string>();
            Console.WriteLine("Inserting nodes with keys: 30, 10, 20, 40, 50, 15");
            tree.Insert(new BSTNode<string>(30, "30"));
            tree.Insert(new BSTNode<string>(10, "10"));
            tree.Insert(new BSTNode<string>(20, "20"));
            tree.Insert(new BSTNode<string>(40, "40"));
            tree.Insert(new BSTNode<string>(50, "50"));
            tree.Insert(new BSTNode<string>(15, "15"));
            tree.Insert(new BSTNode<string>(35, "35"));
        }

        void SearchForExistingKey()
        {
            Console.WriteLine("Searching for key: 10");
            var node = tree.Search(10);
            Console.WriteLine(String.Format(" \\- Found node -> key = {0:d} and value = {1}", node.Key, node.Value));
        }

        void DeleteExistingKey(int key)
        {
            Console.WriteLine(String.Format("Deleted key: {0:d}", key));
            tree.Delete(key);
            tree.PrintAsTree();
            PrintSeparator();
        }

    }
}
