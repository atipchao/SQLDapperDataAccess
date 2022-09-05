namespace SQLDapperDataAccess
{
    partial class DashBoard
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
            this.CustListBox = new System.Windows.Forms.ListBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.LastNamelabel = new System.Windows.Forms.Label();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustListBox
            // 
            this.CustListBox.FormattingEnabled = true;
            this.CustListBox.Location = new System.Drawing.Point(72, 84);
            this.CustListBox.Name = "CustListBox";
            this.CustListBox.Size = new System.Drawing.Size(409, 264);
            this.CustListBox.TabIndex = 0;
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(296, 29);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(185, 20);
            this.LastNameText.TabIndex = 1;
            // 
            // LastNamelabel
            // 
            this.LastNamelabel.AutoSize = true;
            this.LastNamelabel.Location = new System.Drawing.Point(238, 29);
            this.LastNamelabel.Name = "LastNamelabel";
            this.LastNamelabel.Size = new System.Drawing.Size(58, 13);
            this.LastNamelabel.TabIndex = 2;
            this.LastNamelabel.Text = "Last Name";
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(241, 55);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(75, 23);
            this.Searchbutton.TabIndex = 3;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.LastNamelabel);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.CustListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CustListBox;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.Label LastNamelabel;
        private System.Windows.Forms.Button Searchbutton;
    }
}

