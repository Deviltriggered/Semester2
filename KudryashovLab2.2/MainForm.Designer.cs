namespace TestProject1
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FirstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openChildreFormOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеСпискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеЭлементаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вНачалоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вКонецToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вПроизвольнуюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеЭлементаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изНачалаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изКонцаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изПроизвольнойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разрушениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обработкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SecondTwoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThirdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FirstToolStripMenuItem,
            this.SecondTwoToolStripMenuItem,
            this.ThirdToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mainMenuStrip.Size = new System.Drawing.Size(573, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // FirstToolStripMenuItem
            // 
            this.FirstToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openChildreFormOneToolStripMenuItem,
            this.редактированиеСпискаToolStripMenuItem,
            this.разрушениеToolStripMenuItem,
            this.обработкаToolStripMenuItem});
            this.FirstToolStripMenuItem.Name = "FirstToolStripMenuItem";
            this.FirstToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.FirstToolStripMenuItem.Text = "Задание";
            // 
            // openChildreFormOneToolStripMenuItem
            // 
            this.openChildreFormOneToolStripMenuItem.Name = "openChildreFormOneToolStripMenuItem";
            this.openChildreFormOneToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.openChildreFormOneToolStripMenuItem.Text = "Создание списка";
            this.openChildreFormOneToolStripMenuItem.Click += new System.EventHandler(this.openChildreFormOneToolStripMenuItem_Click);
            // 
            // редактированиеСпискаToolStripMenuItem
            // 
            this.редактированиеСпискаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавлениеЭлементаToolStripMenuItem,
            this.удалениеЭлементаToolStripMenuItem});
            this.редактированиеСпискаToolStripMenuItem.Name = "редактированиеСпискаToolStripMenuItem";
            this.редактированиеСпискаToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.редактированиеСпискаToolStripMenuItem.Text = "Редактирование списка";
            // 
            // добавлениеЭлементаToolStripMenuItem
            // 
            this.добавлениеЭлементаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вНачалоToolStripMenuItem,
            this.вКонецToolStripMenuItem,
            this.вПроизвольнуюToolStripMenuItem});
            this.добавлениеЭлементаToolStripMenuItem.Name = "добавлениеЭлементаToolStripMenuItem";
            this.добавлениеЭлементаToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.добавлениеЭлементаToolStripMenuItem.Text = "Добавление элемента";
            // 
            // вНачалоToolStripMenuItem
            // 
            this.вНачалоToolStripMenuItem.Name = "вНачалоToolStripMenuItem";
            this.вНачалоToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.вНачалоToolStripMenuItem.Text = "В начало";
            this.вНачалоToolStripMenuItem.Click += new System.EventHandler(this.вНачалоToolStripMenuItem_Click);
            // 
            // вКонецToolStripMenuItem
            // 
            this.вКонецToolStripMenuItem.Name = "вКонецToolStripMenuItem";
            this.вКонецToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.вКонецToolStripMenuItem.Text = "В конец";
            this.вКонецToolStripMenuItem.Click += new System.EventHandler(this.вКонецToolStripMenuItem_Click);
            // 
            // вПроизвольнуюToolStripMenuItem
            // 
            this.вПроизвольнуюToolStripMenuItem.Name = "вПроизвольнуюToolStripMenuItem";
            this.вПроизвольнуюToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.вПроизвольнуюToolStripMenuItem.Text = "В произвольную";
            this.вПроизвольнуюToolStripMenuItem.Click += new System.EventHandler(this.вПроизвольнуюToolStripMenuItem_Click);
            // 
            // удалениеЭлементаToolStripMenuItem
            // 
            this.удалениеЭлементаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изНачалаToolStripMenuItem,
            this.изКонцаToolStripMenuItem,
            this.изПроизвольнойToolStripMenuItem});
            this.удалениеЭлементаToolStripMenuItem.Name = "удалениеЭлементаToolStripMenuItem";
            this.удалениеЭлементаToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.удалениеЭлементаToolStripMenuItem.Text = "Удаление элемента";
            // 
            // изНачалаToolStripMenuItem
            // 
            this.изНачалаToolStripMenuItem.Name = "изНачалаToolStripMenuItem";
            this.изНачалаToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.изНачалаToolStripMenuItem.Text = "Из начала";
            this.изНачалаToolStripMenuItem.Click += new System.EventHandler(this.изНачалаToolStripMenuItem_Click);
            // 
            // изКонцаToolStripMenuItem
            // 
            this.изКонцаToolStripMenuItem.Name = "изКонцаToolStripMenuItem";
            this.изКонцаToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.изКонцаToolStripMenuItem.Text = "Из конца";
            this.изКонцаToolStripMenuItem.Click += new System.EventHandler(this.изКонцаToolStripMenuItem_Click);
            // 
            // изПроизвольнойToolStripMenuItem
            // 
            this.изПроизвольнойToolStripMenuItem.Name = "изПроизвольнойToolStripMenuItem";
            this.изПроизвольнойToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.изПроизвольнойToolStripMenuItem.Text = "Из произвольной";
            this.изПроизвольнойToolStripMenuItem.Click += new System.EventHandler(this.изПроизвольнойToolStripMenuItem_Click);
            // 
            // разрушениеToolStripMenuItem
            // 
            this.разрушениеToolStripMenuItem.Name = "разрушениеToolStripMenuItem";
            this.разрушениеToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.разрушениеToolStripMenuItem.Text = "Разрушение";
            this.разрушениеToolStripMenuItem.Click += new System.EventHandler(this.разрушениеToolStripMenuItem_Click);
            // 
            // обработкаToolStripMenuItem
            // 
            this.обработкаToolStripMenuItem.Name = "обработкаToolStripMenuItem";
            this.обработкаToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.обработкаToolStripMenuItem.Text = "Обработка";
            this.обработкаToolStripMenuItem.Click += new System.EventHandler(this.обработкаToolStripMenuItem_Click);
            // 
            // SecondTwoToolStripMenuItem
            // 
            this.SecondTwoToolStripMenuItem.Name = "SecondTwoToolStripMenuItem";
            this.SecondTwoToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.SecondTwoToolStripMenuItem.Text = "О программе";
            this.SecondTwoToolStripMenuItem.Click += new System.EventHandler(this.openChildrenFormTwoToolStripMenuItem_Click);
            // 
            // ThirdToolStripMenuItem
            // 
            this.ThirdToolStripMenuItem.Name = "ThirdToolStripMenuItem";
            this.ThirdToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ThirdToolStripMenuItem.Text = "Выход";
            this.ThirdToolStripMenuItem.Click += new System.EventHandler(this.ThirdToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 142);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №2.2";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FirstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openChildreFormOneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SecondTwoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThirdToolStripMenuItem;
        private ToolStripMenuItem редактированиеСпискаToolStripMenuItem;
        private ToolStripMenuItem добавлениеЭлементаToolStripMenuItem;
        private ToolStripMenuItem вНачалоToolStripMenuItem;
        private ToolStripMenuItem вКонецToolStripMenuItem;
        private ToolStripMenuItem вПроизвольнуюToolStripMenuItem;
        private ToolStripMenuItem удалениеЭлементаToolStripMenuItem;
        private ToolStripMenuItem изНачалаToolStripMenuItem;
        private ToolStripMenuItem изКонцаToolStripMenuItem;
        private ToolStripMenuItem изПроизвольнойToolStripMenuItem;
        private ToolStripMenuItem обработкаToolStripMenuItem;
        private ToolStripMenuItem разрушениеToolStripMenuItem;
    }
}

