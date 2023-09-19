namespace KudryashovLab3
{
    partial class ChildrenFormOne
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
            Action = new Button();
            ActionTitle = new Label();
            inputBox = new TextBox();
            CreateTreeView = new TreeView();
            Destroy = new Button();
            SuspendLayout();
            // 
            // Action
            // 
            Action.Location = new Point(174, 59);
            Action.Name = "Action";
            Action.Size = new Size(153, 34);
            Action.TabIndex = 1;
            Action.Text = "Создать дерево";
            Action.UseVisualStyleBackColor = true;
            Action.Click += Action_Click;
            // 
            // ActionTitle
            // 
            ActionTitle.AutoSize = true;
            ActionTitle.Location = new Point(174, 12);
            ActionTitle.Name = "ActionTitle";
            ActionTitle.Size = new Size(153, 15);
            ActionTitle.TabIndex = 2;
            ActionTitle.Text = "Введите значения ключей:";
            // 
            // inputBox
            // 
            inputBox.Location = new Point(174, 30);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(153, 23);
            inputBox.TabIndex = 3;
            inputBox.KeyPress += inputBox_KeyPress;
            // 
            // CreateTreeView
            // 
            CreateTreeView.Location = new Point(12, 12);
            CreateTreeView.Name = "CreateTreeView";
            CreateTreeView.Size = new Size(156, 344);
            CreateTreeView.TabIndex = 4;
            // 
            // Destroy
            // 
            Destroy.Location = new Point(174, 12);
            Destroy.Name = "Destroy";
            Destroy.Size = new Size(153, 32);
            Destroy.TabIndex = 5;
            Destroy.Text = "Удалить дерево";
            Destroy.UseVisualStyleBackColor = true;
            Destroy.Click += Destroy_Click;
            // 
            // ChildrenFormOne
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 375);
            Controls.Add(Destroy);
            Controls.Add(CreateTreeView);
            Controls.Add(inputBox);
            Controls.Add(ActionTitle);
            Controls.Add(Action);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ChildrenFormOne";
            Text = "Создание дерева";
            Load += ChildrenFormOne_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Action;
        private Label ActionTitle;
        private TextBox inputBox;
        private TreeView CreateTreeView;
        private Button Destroy;
    }
}