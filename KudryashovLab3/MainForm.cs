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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        ChildrenFormOne sub = new ChildrenFormOne();
        private void openChildrenFormOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            sub.DisableAll();
            sub.EnableCreate();
            sub.ShowDialog(this);
            Show();
        }
        private void openChildrenFormTwoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new ChildrenFormTwo().ShowDialog(this);
            Show();
        }
        private void ThirdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void обработкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new ChildrenFormThree().ShowDialog(this);
            Show();
        }
        private void разрушениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            sub.DisableAll();
            sub.EnableDestroy();
            sub.ShowDialog(this);
            Show();
        }
    }
}
