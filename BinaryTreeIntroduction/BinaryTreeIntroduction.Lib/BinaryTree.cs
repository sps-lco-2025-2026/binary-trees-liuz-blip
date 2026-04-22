using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.IO.Pipelines;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeIntroduction.Lib
{
    public class BinaryTree
    {
        BinaryTreeNode _root;

        public BinaryTree()
        {
            _root = null;
        }

        public BinaryTree(int v)
        {
            _root = new BinaryTreeNode(v);
        }

        public void Insert(int v)
        {
            if (_root == null)
                _root = new BinaryTreeNode(v);
            else
                _root.Insert(v);
        }

        public int Sum()
        {
            return _root.Sum();
        }

        public override string ToString()
        {
            if (_root == null) return "";
            return _root.ToString();
        }

        public bool HasDupes()
        {
            List<int> leaves = new List<int>();
            return _root.HasDupes(leaves);
        }
    }

    internal class BinaryTreeNode
    {
        internal int _value;
        internal BinaryTreeNode _root;
        internal BinaryTreeNode _left;
        internal BinaryTreeNode _right;

        internal BinaryTreeNode(int v)
        {
            _value = v;
            _left = null;
            _right = null;
        }

        internal void Insert(int v)
        {
            if (v < _value)
            {
                if (_left == null) _left = new BinaryTreeNode(v);
                else _left.Insert(v);
            }
            else
            {
                if (_right == null) _right = new BinaryTreeNode(v);
                else _right.Insert(v);
            }
        }

        public int Sum()
        {
            int tree_sum = _value;

            if (_left != null)
                tree_sum = _left.Sum() + tree_sum;
            if (_right != null)
                tree_sum = tree_sum + _right.Sum();
            return tree_sum;
        }

        public override string ToString()
        {
            string tree_str = _value.ToString();

            if (_left != null)
                tree_str = _left.ToString() + ", " + tree_str;
            if (_right != null)
                tree_str = tree_str + ", " + _right.ToString();
            return tree_str;
        }

        public bool HasDupes(List<int> leaves)
        {
            if (leaves.Contains(_value)) return true;
            leaves.Add(_value);
            if (_left != null && _left.HasDupes(leaves)) return true;
            if (_right != null && _right.HasDupes(leaves)) return true;
            return false;
        }
    }
}

