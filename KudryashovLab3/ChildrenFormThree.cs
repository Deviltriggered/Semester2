using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KudryashovLab3
{
    public partial class ChildrenFormThree : Form
    {
        public ChildrenFormThree()
        {
            InitializeComponent();
            DeleteButton.Enabled = false;
            StartPosition = FormStartPosition.CenterScreen;
        }
        public static DichotomyTree T1 = ChildrenFormOne.T;
        public static DichotomyTree T2 = new DichotomyTree();
        private void ChildrenFormThree_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            T1.Print(treeView1, null, T1.Root);
            treeView1.ExpandAll();
        }
        private void HandleButton_Click(object sender, EventArgs e)
        {
            if (HandleBox.Text == "" || HandleBox.Text == " ")
            { MessageBox.Show("Введите значения ключей"); }
            else
            {
                string input = HandleBox.Text;
                int[] keys = Essentials.Convert(input);
                T1.Handle(T2, keys);
                treeView2.Nodes.Clear();
                T2.Print(treeView2, null, T2.Root);
                treeView2.ExpandAll();
                DeleteButton.Enabled = true;
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (T2.Root != null)
            {
                T2.Destroy();
                treeView2.Nodes.Clear();
                T2.Print(treeView2, null, T2.Root);
                MessageBox.Show("Новое дерево удалено.");
            }
            else
            { MessageBox.Show("Новое дерево отсутствует."); }
            DeleteButton.Enabled = false;
        }
        private void HandleBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar))) || (e.KeyChar == '.'))
            {
                if (!char.IsWhiteSpace(e.KeyChar))
                { e.Handled = true; }
            }
        }
    }
}
