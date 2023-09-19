namespace KudryashovLab2
{
    partial class ChildrenFormOneSub
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
            this.LinkedListBox = new System.Windows.Forms.ListBox();
            this.addFirstButton = new System.Windows.Forms.Button();
            this.elemBox = new System.Windows.Forms.TextBox();
            this.addLastButton = new System.Windows.Forms.Button();
            this.addIndButton = new System.Windows.Forms.Button();
            this.indBox1 = new System.Windows.Forms.TextBox();
            this.EnterLabel = new System.Windows.Forms.Label();
            this.indLabel1 = new System.Windows.Forms.Label();
            this.AddLabel = new System.Windows.Forms.Label();
            this.RemoveLabel = new System.Windows.Forms.Label();
            this.indLabel2 = new System.Windows.Forms.Label();
            this.indBox2 = new System.Windows.Forms.TextBox();
            this.delIndButton = new System.Windows.Forms.Button();
            this.delLastButton = new System.Windows.Forms.Button();
            this.delFirstButton = new System.Windows.Forms.Button();
            this.delListButton = new System.Windows.Forms.Button();
            this.HandleLabel = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.TextBox();
            this.ComboLabel = new System.Windows.Forms.Label();
            this.comboButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LinkedListBox
            // 
            this.LinkedListBox.FormattingEnabled = true;
            this.LinkedListBox.ItemHeight = 15;
            this.LinkedListBox.Location = new System.Drawing.Point(12, 12);
            this.LinkedListBox.Name = "LinkedListBox";
            this.LinkedListBox.Size = new System.Drawing.Size(82, 229);
            this.LinkedListBox.TabIndex = 0;
            // 
            // addFirstButton
            // 
            this.addFirstButton.Location = new System.Drawing.Point(100, 76);
            this.addFirstButton.Name = "addFirstButton";
            this.addFirstButton.Size = new System.Drawing.Size(76, 36);
            this.addFirstButton.TabIndex = 1;
            this.addFirstButton.Text = "В начало";
            this.addFirstButton.UseVisualStyleBackColor = true;
            this.addFirstButton.Click += new System.EventHandler(this.addFirstButton_Click);
            // 
            // elemBox
            // 
            this.elemBox.Location = new System.Drawing.Point(100, 47);
            this.elemBox.Name = "elemBox";
            this.elemBox.Size = new System.Drawing.Size(158, 23);
            this.elemBox.TabIndex = 3;
            this.elemBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.elemBox_KeyPress);
            // 
            // addLastButton
            // 
            this.addLastButton.Location = new System.Drawing.Point(182, 76);
            this.addLastButton.Name = "addLastButton";
            this.addLastButton.Size = new System.Drawing.Size(76, 36);
            this.addLastButton.TabIndex = 6;
            this.addLastButton.Text = "В конец";
            this.addLastButton.UseVisualStyleBackColor = true;
            this.addLastButton.Click += new System.EventHandler(this.addLastButton_Click);
            // 
            // addIndButton
            // 
            this.addIndButton.Location = new System.Drawing.Point(264, 76);
            this.addIndButton.Name = "addIndButton";
            this.addIndButton.Size = new System.Drawing.Size(92, 36);
            this.addIndButton.TabIndex = 7;
            this.addIndButton.Text = "В произв.";
            this.addIndButton.UseVisualStyleBackColor = true;
            this.addIndButton.Click += new System.EventHandler(this.addIndButton_Click);
            // 
            // indBox1
            // 
            this.indBox1.Location = new System.Drawing.Point(264, 47);
            this.indBox1.Name = "indBox1";
            this.indBox1.Size = new System.Drawing.Size(92, 23);
            this.indBox1.TabIndex = 8;
            this.indBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.indBox_KeyPress);
            // 
            // EnterLabel
            // 
            this.EnterLabel.AutoSize = true;
            this.EnterLabel.Location = new System.Drawing.Point(100, 29);
            this.EnterLabel.Name = "EnterLabel";
            this.EnterLabel.Size = new System.Drawing.Size(102, 15);
            this.EnterLabel.TabIndex = 9;
            this.EnterLabel.Text = "Введите элемент:";
            // 
            // indLabel1
            // 
            this.indLabel1.AutoSize = true;
            this.indLabel1.Location = new System.Drawing.Point(264, 29);
            this.indLabel1.Name = "indLabel1";
            this.indLabel1.Size = new System.Drawing.Size(92, 15);
            this.indLabel1.TabIndex = 10;
            this.indLabel1.Text = "Введите номер:";
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddLabel.Location = new System.Drawing.Point(100, 12);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(74, 17);
            this.AddLabel.TabIndex = 11;
            this.AddLabel.Text = "Добавить:";
            // 
            // RemoveLabel
            // 
            this.RemoveLabel.AutoSize = true;
            this.RemoveLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveLabel.Location = new System.Drawing.Point(100, 115);
            this.RemoveLabel.Name = "RemoveLabel";
            this.RemoveLabel.Size = new System.Drawing.Size(63, 17);
            this.RemoveLabel.TabIndex = 12;
            this.RemoveLabel.Text = "Удалить:";
            // 
            // indLabel2
            // 
            this.indLabel2.AutoSize = true;
            this.indLabel2.Location = new System.Drawing.Point(182, 135);
            this.indLabel2.Name = "indLabel2";
            this.indLabel2.Size = new System.Drawing.Size(92, 15);
            this.indLabel2.TabIndex = 17;
            this.indLabel2.Text = "Введите номер:";
            // 
            // indBox2
            // 
            this.indBox2.Location = new System.Drawing.Point(182, 153);
            this.indBox2.Name = "indBox2";
            this.indBox2.Size = new System.Drawing.Size(92, 23);
            this.indBox2.TabIndex = 16;
            this.indBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.indBox_KeyPress);
            // 
            // delIndButton
            // 
            this.delIndButton.Location = new System.Drawing.Point(182, 177);
            this.delIndButton.Name = "delIndButton";
            this.delIndButton.Size = new System.Drawing.Size(92, 36);
            this.delIndButton.TabIndex = 15;
            this.delIndButton.Text = "Из произв.";
            this.delIndButton.UseVisualStyleBackColor = true;
            this.delIndButton.Click += new System.EventHandler(this.delIndButton_Click);
            // 
            // delLastButton
            // 
            this.delLastButton.Location = new System.Drawing.Point(100, 177);
            this.delLastButton.Name = "delLastButton";
            this.delLastButton.Size = new System.Drawing.Size(76, 36);
            this.delLastButton.TabIndex = 14;
            this.delLastButton.Text = "Из конца";
            this.delLastButton.UseVisualStyleBackColor = true;
            this.delLastButton.Click += new System.EventHandler(this.delLastButton_Click);
            // 
            // delFirstButton
            // 
            this.delFirstButton.Location = new System.Drawing.Point(100, 135);
            this.delFirstButton.Name = "delFirstButton";
            this.delFirstButton.Size = new System.Drawing.Size(76, 36);
            this.delFirstButton.TabIndex = 13;
            this.delFirstButton.Text = "Из начала";
            this.delFirstButton.UseVisualStyleBackColor = true;
            this.delFirstButton.Click += new System.EventHandler(this.delFirstButton_Click);
            // 
            // delListButton
            // 
            this.delListButton.Location = new System.Drawing.Point(276, 135);
            this.delListButton.Name = "delListButton";
            this.delListButton.Size = new System.Drawing.Size(80, 78);
            this.delListButton.TabIndex = 18;
            this.delListButton.Text = "Весь список";
            this.delListButton.UseVisualStyleBackColor = true;
            this.delListButton.Click += new System.EventHandler(this.delListButton_Click);
            // 
            // HandleLabel
            // 
            this.HandleLabel.AutoSize = true;
            this.HandleLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HandleLabel.Location = new System.Drawing.Point(100, 216);
            this.HandleLabel.Name = "HandleLabel";
            this.HandleLabel.Size = new System.Drawing.Size(81, 17);
            this.HandleLabel.TabIndex = 19;
            this.HandleLabel.Text = "Обработка:";
            // 
            // comboBox
            // 
            this.comboBox.Location = new System.Drawing.Point(100, 251);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(129, 23);
            this.comboBox.TabIndex = 20;
            this.comboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.elemBox_KeyPress);
            // 
            // ComboLabel
            // 
            this.ComboLabel.AutoSize = true;
            this.ComboLabel.Location = new System.Drawing.Point(100, 233);
            this.ComboLabel.Name = "ComboLabel";
            this.ComboLabel.Size = new System.Drawing.Size(129, 15);
            this.ComboLabel.TabIndex = 21;
            this.ComboLabel.Text = "Введите комбинацию:";
            // 
            // comboButton
            // 
            this.comboButton.Location = new System.Drawing.Point(235, 216);
            this.comboButton.Name = "comboButton";
            this.comboButton.Size = new System.Drawing.Size(121, 58);
            this.comboButton.TabIndex = 22;
            this.comboButton.Text = "Удалить слова с комбинацией";
            this.comboButton.UseVisualStyleBackColor = true;
            this.comboButton.Click += new System.EventHandler(this.comboButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(12, 247);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(82, 27);
            this.refreshButton.TabIndex = 23;
            this.refreshButton.Text = "Показать";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // ChildrenFormOneSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 277);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.comboButton);
            this.Controls.Add(this.ComboLabel);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.HandleLabel);
            this.Controls.Add(this.delListButton);
            this.Controls.Add(this.indLabel2);
            this.Controls.Add(this.indBox2);
            this.Controls.Add(this.delIndButton);
            this.Controls.Add(this.delLastButton);
            this.Controls.Add(this.delFirstButton);
            this.Controls.Add(this.RemoveLabel);
            this.Controls.Add(this.AddLabel);
            this.Controls.Add(this.indLabel1);
            this.Controls.Add(this.EnterLabel);
            this.Controls.Add(this.indBox1);
            this.Controls.Add(this.addIndButton);
            this.Controls.Add(this.addLastButton);
            this.Controls.Add(this.elemBox);
            this.Controls.Add(this.addFirstButton);
            this.Controls.Add(this.LinkedListBox);
            this.Name = "ChildrenFormOneSub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа со списками";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox LinkedListBox;
        private Button addFirstButton;
        private TextBox elemBox;
        private Button addLastButton;
        private Button addIndButton;
        private TextBox indBox1;
        private Label EnterLabel;
        private Label indLabel1;
        private Label AddLabel;
        private Label RemoveLabel;
        private Label indLabel2;
        private TextBox indBox2;
        private Button delIndButton;
        private Button delLastButton;
        private Button delFirstButton;
        private Button delListButton;
        private Label HandleLabel;
        private TextBox comboBox;
        private Label ComboLabel;
        private Button comboButton;
        private Button refreshButton;
    }
}