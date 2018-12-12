namespace ContactsBook
{
    partial class SearchContact
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
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNameSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PhoneSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(219, 116);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(149, 52);
            this.SearchBtn.TabIndex = 0;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Contact:";
            // 
            // FirstNameSearch
            // 
            this.FirstNameSearch.Location = new System.Drawing.Point(26, 82);
            this.FirstNameSearch.Name = "FirstNameSearch";
            this.FirstNameSearch.Size = new System.Drawing.Size(242, 20);
            this.FirstNameSearch.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search first Name:";
            // 
            // LastNameSearch
            // 
            this.LastNameSearch.Location = new System.Drawing.Point(290, 82);
            this.LastNameSearch.Name = "LastNameSearch";
            this.LastNameSearch.Size = new System.Drawing.Size(242, 20);
            this.LastNameSearch.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search Last Name:";
            // 
            // PhoneSearch
            // 
            this.PhoneSearch.Location = new System.Drawing.Point(546, 82);
            this.PhoneSearch.Name = "PhoneSearch";
            this.PhoneSearch.Size = new System.Drawing.Size(242, 20);
            this.PhoneSearch.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Search Phone:";
            // 
            // Reset_btn
            // 
            this.Reset_btn.Location = new System.Drawing.Point(455, 116);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(149, 52);
            this.Reset_btn.TabIndex = 8;
            this.Reset_btn.Text = "Reset";
            this.Reset_btn.UseVisualStyleBackColor = true;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // SearchContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 180);
            this.Controls.Add(this.Reset_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PhoneSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastNameSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstNameSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBtn);
            this.Name = "SearchContact";
            this.Text = "SearchContact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNameSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastNameSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PhoneSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Reset_btn;
    }
}