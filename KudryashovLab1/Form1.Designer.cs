namespace KudryashovLab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonReset = new System.Windows.Forms.Button();
            this.AnswerPrompt = new System.Windows.Forms.Label();
            this.buttonTarget = new System.Windows.Forms.Button();
            this.textboxTarget = new System.Windows.Forms.TextBox();
            this.RunPrompt = new System.Windows.Forms.Label();
            this.dataArray = new System.Windows.Forms.DataGridView();
            this.ArrayPrompt = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textboxLength = new System.Windows.Forms.TextBox();
            this.LengthPrompt = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.ExitPrompt = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataArray)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-8, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(419, 240);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(411, 212);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "     О программе     ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(396, 63);
            this.label5.TabIndex = 4;
            this.label5.Text = "Реализуйте рекурсивный алгоритм двоичного поиска\r\nэлемента с заданным значением в" +
    " упорядоченном\r\nцелочисленном массиве.\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Вариант 28:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кудряшов Алексей Викторович, 6101-090301D\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лабораторную работу выполнил:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonReset);
            this.tabPage2.Controls.Add(this.AnswerPrompt);
            this.tabPage2.Controls.Add(this.buttonTarget);
            this.tabPage2.Controls.Add(this.textboxTarget);
            this.tabPage2.Controls.Add(this.RunPrompt);
            this.tabPage2.Controls.Add(this.dataArray);
            this.tabPage2.Controls.Add(this.ArrayPrompt);
            this.tabPage2.Controls.Add(this.buttonGenerate);
            this.tabPage2.Controls.Add(this.textboxLength);
            this.tabPage2.Controls.Add(this.LengthPrompt);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(411, 212);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "     Задание     ";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonReset.Location = new System.Drawing.Point(286, 123);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(84, 76);
            this.buttonReset.TabIndex = 9;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // AnswerPrompt
            // 
            this.AnswerPrompt.AutoSize = true;
            this.AnswerPrompt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnswerPrompt.Location = new System.Drawing.Point(6, 178);
            this.AnswerPrompt.Name = "AnswerPrompt";
            this.AnswerPrompt.Size = new System.Drawing.Size(208, 21);
            this.AnswerPrompt.TabIndex = 8;
            this.AnswerPrompt.Text = "Индекс искомого элемента:";
            // 
            // buttonTarget
            // 
            this.buttonTarget.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonTarget.Location = new System.Drawing.Point(228, 56);
            this.buttonTarget.Name = "buttonTarget";
            this.buttonTarget.Size = new System.Drawing.Size(142, 23);
            this.buttonTarget.TabIndex = 7;
            this.buttonTarget.Text = "Найти";
            this.buttonTarget.UseVisualStyleBackColor = true;
            this.buttonTarget.Click += new System.EventHandler(this.buttonTarget_Click);
            // 
            // textboxTarget
            // 
            this.textboxTarget.Location = new System.Drawing.Point(228, 27);
            this.textboxTarget.Name = "textboxTarget";
            this.textboxTarget.Size = new System.Drawing.Size(142, 23);
            this.textboxTarget.TabIndex = 6;
            this.textboxTarget.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxTarget_KeyPress);
            // 
            // RunPrompt
            // 
            this.RunPrompt.AutoSize = true;
            this.RunPrompt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RunPrompt.Location = new System.Drawing.Point(228, 3);
            this.RunPrompt.Name = "RunPrompt";
            this.RunPrompt.Size = new System.Drawing.Size(142, 21);
            this.RunPrompt.TabIndex = 5;
            this.RunPrompt.Text = "Искомый элемент:";
            // 
            // dataArray
            // 
            this.dataArray.AllowUserToAddRows = false;
            this.dataArray.AllowUserToDeleteRows = false;
            this.dataArray.AllowUserToResizeColumns = false;
            this.dataArray.AllowUserToResizeRows = false;
            this.dataArray.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataArray.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataArray.ColumnHeadersVisible = false;
            this.dataArray.Location = new System.Drawing.Point(6, 123);
            this.dataArray.Name = "dataArray";
            this.dataArray.RowHeadersVisible = false;
            this.dataArray.RowTemplate.Height = 25;
            this.dataArray.Size = new System.Drawing.Size(274, 52);
            this.dataArray.TabIndex = 4;
            // 
            // ArrayPrompt
            // 
            this.ArrayPrompt.AutoSize = true;
            this.ArrayPrompt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ArrayPrompt.Location = new System.Drawing.Point(6, 99);
            this.ArrayPrompt.Name = "ArrayPrompt";
            this.ArrayPrompt.Size = new System.Drawing.Size(66, 21);
            this.ArrayPrompt.TabIndex = 3;
            this.ArrayPrompt.Text = "Массив:";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonGenerate.Location = new System.Drawing.Point(6, 56);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(203, 23);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "Создать";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // textboxLength
            // 
            this.textboxLength.Location = new System.Drawing.Point(6, 27);
            this.textboxLength.Name = "textboxLength";
            this.textboxLength.Size = new System.Drawing.Size(203, 23);
            this.textboxLength.TabIndex = 1;
            this.textboxLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxLength_KeyPress);
            // 
            // LengthPrompt
            // 
            this.LengthPrompt.AutoSize = true;
            this.LengthPrompt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LengthPrompt.Location = new System.Drawing.Point(6, 3);
            this.LengthPrompt.Name = "LengthPrompt";
            this.LengthPrompt.Size = new System.Drawing.Size(203, 21);
            this.LengthPrompt.TabIndex = 0;
            this.LengthPrompt.Text = "Кол-во элементов массива:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonNo);
            this.tabPage3.Controls.Add(this.buttonYes);
            this.tabPage3.Controls.Add(this.ExitPrompt);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(411, 212);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "     Выход     ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonNo
            // 
            this.buttonNo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNo.Location = new System.Drawing.Point(220, 94);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(101, 45);
            this.buttonNo.TabIndex = 2;
            this.buttonNo.Text = "Нет";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // buttonYes
            // 
            this.buttonYes.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonYes.Location = new System.Drawing.Point(90, 94);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(101, 45);
            this.buttonYes.TabIndex = 1;
            this.buttonYes.Text = "Да";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // ExitPrompt
            // 
            this.ExitPrompt.AutoSize = true;
            this.ExitPrompt.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitPrompt.Location = new System.Drawing.Point(90, 54);
            this.ExitPrompt.Name = "ExitPrompt";
            this.ExitPrompt.Size = new System.Drawing.Size(231, 25);
            this.ExitPrompt.TabIndex = 0;
            this.ExitPrompt.Text = "Выйти из программы?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 233);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataArray)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label4;
        private Label label5;
        private Button buttonNo;
        private Button buttonYes;
        private Label ExitPrompt;
        private Label ArrayPrompt;
        private Button buttonGenerate;
        private TextBox textboxLength;
        private Label LengthPrompt;
        private DataGridView dataArray;
        private Button buttonTarget;
        private TextBox textboxTarget;
        private Label RunPrompt;
        private Label AnswerPrompt;
        private Button buttonReset;
    }
}