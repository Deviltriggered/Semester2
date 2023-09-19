namespace KudryashovLab3
{
    partial class ChildrenFormThree
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
            treeView1 = new TreeView();
            treeView2 = new TreeView();
            HandleBox = new TextBox();
            HandleButton = new Button();
            HandleLabel = new Label();
            DeleteButton = new Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 12);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(126, 324);
            treeView1.TabIndex = 0;
            // 
            // treeView2
            // 
            treeView2.Location = new Point(303, 12);
            treeView2.Name = "treeView2";
            treeView2.Size = new Size(126, 324);
            treeView2.TabIndex = 1;
            // 
            // HandleBox
            // 
            HandleBox.Location = new Point(144, 30);
            HandleBox.Name = "HandleBox";
            HandleBox.Size = new Size(153, 23);
            HandleBox.TabIndex = 2;
            HandleBox.KeyPress += HandleBox_KeyPress;
            // 
            // HandleButton
            // 
            HandleButton.Location = new Point(144, 59);
            HandleButton.Name = "HandleButton";
            HandleButton.Size = new Size(153, 23);
            HandleButton.TabIndex = 3;
            HandleButton.Text = "Скопировать";
            HandleButton.UseVisualStyleBackColor = true;
            HandleButton.Click += HandleButton_Click;
            // 
            // HandleLabel
            // 
            HandleLabel.AutoSize = true;
            HandleLabel.Location = new Point(144, 12);
            HandleLabel.Name = "HandleLabel";
            HandleLabel.Size = new Size(153, 15);
            HandleLabel.TabIndex = 4;
            HandleLabel.Text = "Введите значения ключей:";
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(144, 88);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(153, 23);
            DeleteButton.TabIndex = 5;
            DeleteButton.Text = "Очистить новое дерево";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ChildrenFormThree
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 348);
            Controls.Add(DeleteButton);
            Controls.Add(HandleLabel);
            Controls.Add(HandleButton);
            Controls.Add(HandleBox);
            Controls.Add(treeView2);
            Controls.Add(treeView1);
            Name = "ChildrenFormThree";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Обработка деревьев";
            Load += ChildrenFormThree_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private TreeView treeView2;
        private TextBox HandleBox;
        private Button HandleButton;
        private Label HandleLabel;
        private Button DeleteButton;
    }
}