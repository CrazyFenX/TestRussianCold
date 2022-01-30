
namespace TestRussianCold
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
            this.DateFromTextBox = new System.Windows.Forms.TextBox();
            this.TimeFromTextBox = new System.Windows.Forms.TextBox();
            this.DateToTextBox = new System.Windows.Forms.TextBox();
            this.TimeToTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTestTextBox = new System.Windows.Forms.TextBox();
            this.TimeTestTextBox = new System.Windows.Forms.TextBox();
            this.testButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateFromTextBox
            // 
            this.DateFromTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateFromTextBox.Location = new System.Drawing.Point(71, 40);
            this.DateFromTextBox.Name = "DateFromTextBox";
            this.DateFromTextBox.Size = new System.Drawing.Size(125, 34);
            this.DateFromTextBox.TabIndex = 0;
            this.DateFromTextBox.Text = "28.07.2021";
            // 
            // TimeFromTextBox
            // 
            this.TimeFromTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeFromTextBox.Location = new System.Drawing.Point(214, 40);
            this.TimeFromTextBox.Name = "TimeFromTextBox";
            this.TimeFromTextBox.Size = new System.Drawing.Size(125, 34);
            this.TimeFromTextBox.TabIndex = 1;
            this.TimeFromTextBox.Text = "20:30";
            // 
            // DateToTextBox
            // 
            this.DateToTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateToTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateToTextBox.Location = new System.Drawing.Point(425, 40);
            this.DateToTextBox.Name = "DateToTextBox";
            this.DateToTextBox.Size = new System.Drawing.Size(125, 34);
            this.DateToTextBox.TabIndex = 2;
            this.DateToTextBox.Text = "28.07.2021";
            // 
            // TimeToTextBox
            // 
            this.TimeToTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeToTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeToTextBox.Location = new System.Drawing.Point(571, 40);
            this.TimeToTextBox.Name = "TimeToTextBox";
            this.TimeToTextBox.Size = new System.Drawing.Size(125, 34);
            this.TimeToTextBox.TabIndex = 3;
            this.TimeToTextBox.Text = "20:31";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DateFromTextBox);
            this.groupBox1.Controls.Add(this.TimeToTextBox);
            this.groupBox1.Controls.Add(this.TimeFromTextBox);
            this.groupBox1.Controls.Add(this.DateToTextBox);
            this.groupBox1.Location = new System.Drawing.Point(33, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 101);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Период отчета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "С";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(381, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "По";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(121, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Проверить дату:";
            // 
            // DateTestTextBox
            // 
            this.DateTestTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTestTextBox.Location = new System.Drawing.Point(288, 206);
            this.DateTestTextBox.Name = "DateTestTextBox";
            this.DateTestTextBox.Size = new System.Drawing.Size(125, 34);
            this.DateTestTextBox.TabIndex = 6;
            this.DateTestTextBox.Text = "28.07.2021";
            // 
            // TimeTestTextBox
            // 
            this.TimeTestTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeTestTextBox.Location = new System.Drawing.Point(431, 206);
            this.TimeTestTextBox.Name = "TimeTestTextBox";
            this.TimeTestTextBox.Size = new System.Drawing.Size(125, 34);
            this.TimeTestTextBox.TabIndex = 7;
            this.TimeTestTextBox.Text = "20:30";
            // 
            // testButton
            // 
            this.testButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.testButton.Location = new System.Drawing.Point(583, 204);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(125, 39);
            this.testButton.TabIndex = 9;
            this.testButton.Text = "Проверить";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 447);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateTestTextBox);
            this.Controls.Add(this.TimeTestTextBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DateFromTextBox;
        private System.Windows.Forms.TextBox TimeFromTextBox;
        private System.Windows.Forms.TextBox DateToTextBox;
        private System.Windows.Forms.TextBox TimeToTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DateTestTextBox;
        private System.Windows.Forms.TextBox TimeTestTextBox;
        private System.Windows.Forms.Button testButton;
    }
}

