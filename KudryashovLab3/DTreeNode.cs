using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KudryashovLab3
{
    public class DTreeNode
    {
        private char info;
        private int key;
        private DTreeNode left;
        private DTreeNode right;
        public char Info
        {
            get { return info; }
            set { info = value; }
        }
        public int Key
        {
            get { return key; }
            set { key = value; }
        }
        public DTreeNode Left
        {
            get { return left; }
            set { left = value; }
        }
        public DTreeNode Right
        {
            get { return right; }
            set { right = value; }
        }
        public DTreeNode() { }
        public DTreeNode(char info, int key)
        {
            Info = info;
            Key = key;
        }
        public DTreeNode(char info, int key, DTreeNode left, DTreeNode right)
        {
            Info = info;
            Key = key;
            Left = left;
            Right = right;
        }
    }
}
