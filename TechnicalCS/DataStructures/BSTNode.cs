using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalCS.TechDemos.DataStructures
{
    public class BSTNode<T>
    {
        public int Key;
        public T Value;
        public BSTNode<T> Left;
        public BSTNode<T> Right;

        public BSTNode(int key, T value)
        {
            Key = key;
            Value = value;
        }

        // override [] operator
        public BSTNode<T> this[NodePosition p]
        {
            get
            {
                if (p == NodePosition.LEFT)
                {
                    return Left;
                }
                if (p == NodePosition.RIGHT)
                {
                    return Right;
                }
                return null;
            }

            set
            {
                if (p == NodePosition.LEFT)
                {
                    Left = value;
                }
                if (p == NodePosition.RIGHT)
                {
                    Right = value;
                }
            }
        }
    }



    public enum NodePosition
    {
        LEFT, RIGHT, NONE
    }
}
