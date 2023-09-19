using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestProject1;

namespace KudryashovLab2
{
    public partial class ChildrenFormOneSub : Form
    {
        public static SingleLinkedList L1 = ChildrenFormOne.L;
        public ChildrenFormOneSub()
        {
            InitializeComponent();
            LinkedListBox.Items.Clear();
            L1.Print(LinkedListBox);
        }
        public void DisableAll()
        {
            AddLabel.Enabled = false;
            EnterLabel.Enabled = false;
            elemBox.Enabled = false;
            elemBox.Clear();
            addFirstButton.Enabled = false;
            addLastButton.Enabled = false;
            indLabel1.Enabled = false;
            indBox1.Enabled = false;
            indBox1.Clear();
            addIndButton.Enabled = false;
            RemoveLabel.Enabled = false;
            delFirstButton.Enabled = false;
            delLastButton.Enabled = false;
            indLabel2.Enabled = false;
            indBox2.Enabled = false;
            indBox2.Clear();
            delIndButton.Enabled = false;
            delListButton.Enabled = false;
            HandleLabel.Enabled = false;
            ComboLabel.Enabled = false;
            comboBox.Enabled = false;
            comboBox.Clear();
            comboButton.Enabled = false;
            AddLabel.Visible = false;
            EnterLabel.Visible = false;
            elemBox.Visible = false;
            elemBox.Clear();
            addFirstButton.Visible = false;
            addLastButton.Visible = false;
            indLabel1.Visible = false;
            indBox1.Visible = false;
            indBox1.Clear();
            addIndButton.Visible = false;
            RemoveLabel.Visible = false;
            delFirstButton.Visible = false;
            delLastButton.Visible = false;
            indLabel2.Visible = false;
            indBox2.Visible = false;
            indBox2.Clear();
            delIndButton.Visible = false;
            delListButton.Visible = false;
            HandleLabel.Visible = false;
            ComboLabel.Visible = false;
            comboBox.Visible = false;
            comboBox.Clear();
            comboButton.Visible = false;
        }
        public void EnableAddition()
        {
            AddLabel.Visible = true;
            EnterLabel.Visible = true;
            elemBox.Visible = true;
            addFirstButton.Visible = true;
            addLastButton.Visible = true;
            indLabel1.Visible = true;
            indBox1.Visible = true;
            addIndButton.Visible = true;
        }
        public void EnableDeletion()
        {
            RemoveLabel.Visible = true;
            delFirstButton.Visible = true;
            delLastButton.Visible = true;
            indLabel2.Visible = true;
            indBox2.Visible = true;
            delIndButton.Visible = true;
            delListButton.Visible = true;
        }
        public void EnableHandling()
        {
            HandleLabel.Visible = true;
            ComboLabel.Visible = true;
            comboBox.Visible = true;
            comboButton.Visible = true;
        }
        public void EnableAddFirst()
        {
            AddLabel.Enabled = true;
            EnterLabel.Enabled = true;
            elemBox.Enabled = true;
            addFirstButton.Enabled = true;
        }
        public void EnableAddLast()
        {
            AddLabel.Enabled = true;
            EnterLabel.Enabled = true;
            elemBox.Enabled = true;
            addLastButton.Enabled = true;
        }
        public void EnableAddInd()
        {
            AddLabel.Enabled = true;
            EnterLabel.Enabled = true;
            elemBox.Enabled = true;
            indLabel1.Enabled = true;
            indBox1.Enabled = true;
            addIndButton.Enabled = true;
        }
        public void EnableDelFirst()
        {
            RemoveLabel.Enabled = true;
            delFirstButton.Enabled = true;
        }
        public void EnableDelLast()
        {
            RemoveLabel.Enabled = true;
            delLastButton.Enabled = true;
        }
        public void EnableDelInd()
        {
            RemoveLabel.Enabled = true;
            indLabel2.Enabled = true;
            indBox2.Enabled = true;
            delIndButton.Enabled = true;
        }
        public void EnableDelList()
        {
            RemoveLabel.Enabled = true;
            delListButton.Enabled = true;
        }
        public void EnableHandle()
        {
            HandleLabel.Enabled = true;
            ComboLabel.Enabled = true;
            comboBox.Enabled = true;
            comboButton.Enabled = true;
        }
        private void ChildrenFormOneSub_Load(object sender, EventArgs E)
        {
            LinkedListBox.Items.Clear();
            L1.Print(LinkedListBox);
        }
        private void elemBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((!char.IsControl(e.KeyChar)) && (char.IsDigit(e.KeyChar))) || (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
        private void indBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar))) || (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
        private void addFirstButton_Click(object sender, EventArgs e)
        {
            if (elemBox.Text == "" || elemBox.Text == " ")
            { MessageBox.Show("Введите значение элемента"); }
            else
            {
                string data = elemBox.Text;
                L1.InsertFirst(data);
                LinkedListBox.Items.Clear();
                L1.Print(LinkedListBox);
            }
        }
        private void addLastButton_Click(object sender, EventArgs e)
        {
            if (elemBox.Text == "" || elemBox.Text == " ")
            { MessageBox.Show("Введите значение элемента"); }
            else
            {
                string data = elemBox.Text;
                L1.InsertLast(data);
                LinkedListBox.Items.Clear();
                L1.Print(LinkedListBox);
            }
        }
        private void addIndButton_Click(object sender, EventArgs e)
        {
            if (indBox1.Text == "" || indBox1.Text == " ")
            { MessageBox.Show("Введите номер элемента"); }
            else if (elemBox.Text == "" || elemBox.Text == " ")
            { MessageBox.Show("Введите значение элемента"); }
            else
            {
                int index = int.Parse(indBox1.Text);
                string data = elemBox.Text;
                if (index <= LinkedListBox.Items.Count)
                {
                    L1.InsertCurrent(data, index);
                    LinkedListBox.Items.Clear();
                    L1.Print(LinkedListBox);
                }
                else if (index == LinkedListBox.Items.Count + 1)
                {
                    L1.InsertLast(data);
                    LinkedListBox.Items.Clear();
                    L1.Print(LinkedListBox);
                }
                else
                { MessageBox.Show("Номер выходит за пределы списка"); }
            }
        }
        private void delFirstButton_Click(object sender, EventArgs e)
        {
            if (SingleLinkedList.Check(L1))
            {
                L1.DeleteFirst();
                LinkedListBox.Items.Clear();
                L1.Print(LinkedListBox);
            }
            else
            { MessageBox.Show("Список пуст, операция невозможна"); }
        }
        private void delLastButton_Click(object sender, EventArgs e)
        {
            if (SingleLinkedList.Check(L1))
            {
                L1.DeleteLast();
                LinkedListBox.Items.Clear();
                L1.Print(LinkedListBox);
            }
            else
            { MessageBox.Show("Список пуст, операция невозможна"); }
        }
        private void delIndButton_Click(object sender, EventArgs e)
        {
            if (indBox2.Text == "" || indBox2.Text == " ")
            { MessageBox.Show("Введите номер элемента"); }
            else
            {
                int index = int.Parse(indBox2.Text);
                if (SingleLinkedList.Check(L1))
                {
                    if (index <= LinkedListBox.Items.Count)
                    {
                        L1.DeleteCurrent(index);
                        LinkedListBox.Items.Clear();
                        L1.Print(LinkedListBox);
                    }
                    else if (index == 1)
                    {
                        L1.DeleteFirst();
                        LinkedListBox.Items.Clear();
                        L1.Print(LinkedListBox);
                    }
                    else if (index == LinkedListBox.Items.Count)
                    {
                        L1.DeleteLast();
                        LinkedListBox.Items.Clear();
                        L1.Print(LinkedListBox);
                    }
                    else
                    { MessageBox.Show("В списке нет элемента с таким номером"); }
                }
                else
                { MessageBox.Show("Список пуст, операция невозможна"); }
            }
        }
        private void delListButton_Click(object sender, EventArgs e)
        {
            if (SingleLinkedList.Check(L1))
            {
                L1.Destroy();
                LinkedListBox.Items.Clear();
                L1.Print(LinkedListBox);
            }
            else
            { MessageBox.Show("Список пуст, операция невозможна"); }
        }
        private void comboButton_Click(object sender, EventArgs e)
        {
            if (SingleLinkedList.Check(L1))
            {
                string seeking = comboBox.Text;
                L1.Handle(seeking);
                LinkedListBox.Items.Clear();
                L1.Print(LinkedListBox);
            }
            else
            { MessageBox.Show("Список пуст, операция невозможна"); }
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            LinkedListBox.Items.Clear();
            L1.Print(LinkedListBox);
        }
    }
}
