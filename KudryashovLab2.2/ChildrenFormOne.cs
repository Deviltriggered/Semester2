using KudryashovLab2;
using KudryashovLab2._2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TestProject1
{
    public partial class ChildrenFormOne: Form
    {
        public static CycleDoubleLinkedList L = new CycleDoubleLinkedList();
        public ChildrenFormOne()
        {
            InitializeComponent();
            L.Print(LinkedListBox);
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void ChildrenFormOne_Load(object sender, EventArgs E)
        {
            L.Print(LinkedListBox);
        }
        private void Action_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "" || inputBox.Text == " ")
            { MessageBox.Show("Введите элементы списка"); }
            else
            {
                string input = inputBox.Text;
                string[] arr = input.Split(" ");
                L.Create(arr);
                L.Print(LinkedListBox);
            }
        }
        private void inputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((!char.IsControl(e.KeyChar)) && (char.IsDigit(e.KeyChar))) || (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
    }
}
