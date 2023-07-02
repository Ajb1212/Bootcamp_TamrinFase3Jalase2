namespace TamrinFase3Jalase2
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
            this.ShowTextTextBox = new System.Windows.Forms.TextBox();
            this.OpenFileBTN = new System.Windows.Forms.Button();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowTextTextBox
            // 
            this.ShowTextTextBox.Location = new System.Drawing.Point(10, 50);
            this.ShowTextTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowTextTextBox.Multiline = true;
            this.ShowTextTextBox.Name = "ShowTextTextBox";
            this.ShowTextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ShowTextTextBox.Size = new System.Drawing.Size(680, 279);
            this.ShowTextTextBox.TabIndex = 0;
            this.ShowTextTextBox.WordWrap = false;
            // 
            // OpenFileBTN
            // 
            this.OpenFileBTN.Location = new System.Drawing.Point(606, 8);
            this.OpenFileBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpenFileBTN.Name = "OpenFileBTN";
            this.OpenFileBTN.Size = new System.Drawing.Size(82, 22);
            this.OpenFileBTN.TabIndex = 1;
            this.OpenFileBTN.Text = "Open File";
            this.OpenFileBTN.UseVisualStyleBackColor = true;
            this.OpenFileBTN.Click += new System.EventHandler(this.OpenFileBTN_Click);
            // 
            // SaveBTN
            // 
            this.SaveBTN.Location = new System.Drawing.Point(525, 8);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(75, 22);
            this.SaveBTN.TabIndex = 2;
            this.SaveBTN.Text = "Save";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.OpenFileBTN);
            this.Controls.Add(this.ShowTextTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ShowTextTextBox;
        private Button OpenFileBTN;
        private Button SaveBTN;
    }
}