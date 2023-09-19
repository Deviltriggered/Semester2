using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KudryashovLab3
{
    public class DichotomyTree
    {
        private DTreeNode root;
        public DTreeNode Root 
        { 
            get { return root; } 
            set { root = value; }
        }
        public DichotomyTree()
        {
            root = null;
        }
        public DTreeNode Insert(DTreeNode root, char info, int key)
        {
            if (root == null)
            { root = new DTreeNode(info, key, null, null); }
            else
            {
                if (key < root.Key)
                { root.Left = Insert(root.Left, info, key); }
                else if (key > root.Key)
                { root.Right = Insert(root.Right, info, key); }
                else
                { MessageBox.Show("Введено два ключа со значением" + " " + key.ToString() + ", одно будет удалено."); }
            }
            return root;
        }
        public void Print(TreeView treeView, TreeNode treeNode, DTreeNode root)
        {
            if (root != null)
            {
                TreeNode p = new TreeNode(root.Key.ToString() + root.Info.ToString());
                if (treeNode == null)
                {
                    treeView.Nodes.Add(p);
                }
                else
                {
                    treeNode.Nodes.Add(p);
                }
                Print(treeView, p, root.Left);
                Print(treeView, p, root.Right);
            }
        }
        public void Handle(DichotomyTree newTree, int[] keys)
        {
            foreach (int i in keys)
            {
                DTreeNode p = Find(Root, i);
                if (p != null)
                { newTree.Root = newTree.Insert(newTree.Root, p.Info, p.Key); }
                else
                { MessageBox.Show("Ключа со значением" + " " + i.ToString() + " " + "не существует."); }
            }
        }
        public void Destroy()
        { root = null; }
        public DTreeNode Find(DTreeNode root, int key)
        {
            DTreeNode p;
            if (root == null)
            { p = null; }
            else
            {
                if (key > root.Key)
                { p = Find(root.Right, key); }
                else if (key < root.Key)
                { p = Find(root.Left, key); }
                else
                { p = root; }
            }
            return p;
        }
    }
}