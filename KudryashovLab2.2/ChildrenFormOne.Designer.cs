namespace TestProject1
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
            this.LinkedListBox = new System.Windows.Forms.ListBox();
            this.Action = new System.Windows.Forms.Button();
            this.ActionTitle = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LinkedListBox
            // 
            this.LinkedListBox.FormattingEnabled = true;
            this.LinkedListBox.ItemHeight = 15;
            this.LinkedListBox.Location = new System.Drawing.Point(12, 12);
            this.LinkedListBox.Name = "LinkedListBox";
            this.LinkedListBox.Size = new System.Drawing.Size(175, 349);
            this.LinkedListBox.TabIndex = 0;
            // 
            // Action
            // 
            this.Action.Location = new System.Drawing.Point(193, 59);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(136, 41);
            this.Action.TabIndex = 1;
            this.Action.Text = "Создать";
            this.Action.UseVisualStyleBackColor = true;
            this.Action.Click += new System.EventHandler(this.Action_Click);
            // 
            // ActionTitle
            // 
            this.ActionTitle.AutoSize = true;
            this.ActionTitle.Location = new System.Drawing.Point(193, 12);
            this.ActionTitle.Name = "ActionTitle";
            this.ActionTitle.Size = new System.Drawing.Size(100, 15);
            this.ActionTitle.TabIndex = 2;
            this.ActionTitle.Text = "Создание списка";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(193, 30);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(135, 23);
            this.inputBox.TabIndex = 3;
            this.inputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputBox_KeyPress);
            // 
            // ChildrenFormOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 368);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.ActionTitle);
            this.Controls.Add(this.Action);
            this.Controls.Add(this.LinkedListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ChildrenFormOne";
            this.Text = "Работа со списками";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox LinkedListBox;
        private Button Action;
        private Label ActionTitle;
        private TextBox inputBox;
    }
}