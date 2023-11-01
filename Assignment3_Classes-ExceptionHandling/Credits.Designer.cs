namespace Assignment3_Classes_ExceptionHandling
{
    partial class Credits
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(253, 15);
            label1.TabIndex = 0;
            label1.Text = "Assignment 3: Classes and Exception Handling";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 59);
            label2.Name = "label2";
            label2.Size = new Size(207, 15);
            label2.TabIndex = 1;
            label2.Text = "Computer Programming and Analysis";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 74);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 2;
            label3.Text = "COSC 2100 - 05";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 74);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 3;
            label4.Text = "Stephen Senter";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 24);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 4;
            label5.Text = "Ramiyan Gangatharan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(81, 89);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 5;
            label6.Text = "November 10 2023";
            // 
            // Credits
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 114);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Credits";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Credits";
            Load += Credits_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}