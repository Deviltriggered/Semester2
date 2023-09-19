using KudryashovLab2;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        ChildrenFormOneSub sub = new ChildrenFormOneSub();
        private void openChildreFormOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            (new ChildrenFormOne()).ShowDialog(this);
            Show();
        }
        private void openChildrenFormTwoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            (new ChildrenFormTwo()).ShowDialog(this);
            Show();
        }
        private void ThirdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void вНачалоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            sub.DisableAll();
            sub.EnableAddition();
            sub.EnableAddFirst();
            (sub).ShowDialog(this);
            Show();
        }
        private void вКонецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            sub.DisableAll();
            sub.EnableAddition();
            sub.EnableAddLast();
            (sub).ShowDialog(this);
            Show();
        }
        private void вПроизвольнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            sub.DisableAll();
            sub.EnableAddition();
            sub.EnableAddInd();
            (sub).ShowDialog(this);
            Show();
        }
        private void изНачалаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            sub.DisableAll();
            sub.EnableDeletion();
            sub.EnableDelFirst();
            (sub).ShowDialog(this);
            Show();
        }
        private void изКонцаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            sub.DisableAll();
            sub.EnableDeletion();
            sub.EnableDelLast();
            (sub).ShowDialog(this);
            Show();
        }
        private void изПроизвольнойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            sub.DisableAll();
            sub.EnableDeletion();
            sub.EnableDelInd();
            (sub).ShowDialog(this);
            Show();
        }
        private void обработкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            sub.DisableAll();
            sub.EnableHandling();
            sub.EnableHandle();
            (sub).ShowDialog(this);
            Show();
        }
        private void разрушениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            sub.DisableAll();
            sub.EnableDeletion();
            sub.EnableDelList();
            (sub).ShowDialog(this);
            Show();
        }
    }
}
