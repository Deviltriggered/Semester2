using KudryashovLab3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace KudryashovLab3
{
    public partial class ChildrenFormOne : Form
    {
        public ChildrenFormOne()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        public static DichotomyTree T = new DichotomyTree();
        public void ChildrenFormOne_Load(object sender, EventArgs e)
        {
            CreateTreeView.Nodes.Clear();
            T.Print(CreateTreeView, null, T.Root);
            CreateTreeView.ExpandAll();
        }
        private void Action_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "" || inputBox.Text == " ")
            { MessageBox.Show("Введите значения ключей"); }
            else
            {
                string input = inputBox.Text;
                int[] keys = Essentials.Convert(input);
                if (keys.Length > 0)
                {
                    int lit = 65;
                    foreach (int i in keys)
                    { T.Root = T.Insert(T.Root, (char)lit, i); lit++; }
                }
                CreateTreeView.Nodes.Clear();
                T.Print(CreateTreeView, null, T.Root);
                CreateTreeView.ExpandAll();
            }
        }
        private void Destroy_Click(object sender, EventArgs e)
        {
            if (T.Root != null)
            {
                T.Destroy();
                CreateTreeView.Nodes.Clear();
                T.Print(CreateTreeView, null, T.Root);
                CreateTreeView.ExpandAll();
                MessageBox.Show("Дерево удалено.");
            }
            else
            {
                MessageBox.Show("Дерево отсутствует.");
            }
        }
        private void inputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar))) || (e.KeyChar == '.'))
            {
                if (!char.IsWhiteSpace(e.KeyChar))
                { e.Handled = true; }
            }
        }
        public void DisableAll()
        {
            ActionTitle.Visible = false;
            Action.Visible = false;
            inputBox.Visible = false;
            Destroy.Visible = false;
        }
        public void EnableCreate()
        {
            ActionTitle.Visible = true;
            Action.Visible = true;
            inputBox.Visible = true;
        }
        public void EnableDestroy()
        {
            Destroy.Visible = true;
        }
    }
}
