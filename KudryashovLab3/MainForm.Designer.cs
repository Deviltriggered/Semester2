namespace KudryashovLab3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainMenuStrip = new MenuStrip();
            FirstToolStripMenuItem = new ToolStripMenuItem();
            openChildrenFormOneToolStripMenuItem = new ToolStripMenuItem();
            разрушениеToolStripMenuItem = new ToolStripMenuItem();
            обработкаToolStripMenuItem = new ToolStripMenuItem();
            SecondTwoToolStripMenuItem = new ToolStripMenuItem();
            ThirdToolStripMenuItem = new ToolStripMenuItem();
            mainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { FirstToolStripMenuItem, SecondTwoToolStripMenuItem, ThirdToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Padding = new Padding(7, 2, 0, 2);
            mainMenuStrip.Size = new Size(573, 24);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // FirstToolStripMenuItem
            // 
            FirstToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openChildrenFormOneToolStripMenuItem, обработкаToolStripMenuItem, разрушениеToolStripMenuItem });
            FirstToolStripMenuItem.Name = "FirstToolStripMenuItem";
            FirstToolStripMenuItem.Size = new Size(64, 20);
            FirstToolStripMenuItem.Text = "Задание";
            // 
            // openChildrenFormOneToolStripMenuItem
            // 
            openChildrenFormOneToolStripMenuItem.Name = "openChildrenFormOneToolStripMenuItem";
            openChildrenFormOneToolStripMenuItem.Size = new Size(167, 22);
            openChildrenFormOneToolStripMenuItem.Text = "Создание списка";
            openChildrenFormOneToolStripMenuItem.Click += openChildrenFormOneToolStripMenuItem_Click;
            // 
            // разрушениеToolStripMenuItem
            // 
            разрушениеToolStripMenuItem.Name = "разрушениеToolStripMenuItem";
            разрушениеToolStripMenuItem.Size = new Size(167, 22);
            разрушениеToolStripMenuItem.Text = "Разрушение";
            разрушениеToolStripMenuItem.Click += разрушениеToolStripMenuItem_Click;
            // 
            // обработкаToolStripMenuItem
            // 
            обработкаToolStripMenuItem.Name = "обработкаToolStripMenuItem";
            обработкаToolStripMenuItem.Size = new Size(167, 22);
            обработкаToolStripMenuItem.Text = "Обработка";
            обработкаToolStripMenuItem.Click += обработкаToolStripMenuItem_Click;
            // 
            // SecondTwoToolStripMenuItem
            // 
            SecondTwoToolStripMenuItem.Name = "SecondTwoToolStripMenuItem";
            SecondTwoToolStripMenuItem.Size = new Size(94, 20);
            SecondTwoToolStripMenuItem.Text = "О программе";
            SecondTwoToolStripMenuItem.Click += openChildrenFormTwoToolStripMenuItem_Click;
            // 
            // ThirdToolStripMenuItem
            // 
            ThirdToolStripMenuItem.Name = "ThirdToolStripMenuItem";
            ThirdToolStripMenuItem.Size = new Size(54, 20);
            ThirdToolStripMenuItem.Text = "Выход";
            ThirdToolStripMenuItem.Click += ThirdToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 142);
            Controls.Add(mainMenuStrip);
            MainMenuStrip = mainMenuStrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Лабораторная работа №3";
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FirstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openChildrenFormOneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SecondTwoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThirdToolStripMenuItem;
        private ToolStripMenuItem обработкаToolStripMenuItem;
        private ToolStripMenuItem разрушениеToolStripMenuItem;
    }
}

