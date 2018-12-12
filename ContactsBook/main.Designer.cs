namespace ContactsBook
{
    partial class main
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
            this.ShowAll_btn = new System.Windows.Forms.Button();
            this.AddContact_btn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShowAll_btn
            // 
            this.ShowAll_btn.Location = new System.Drawing.Point(337, 66);
            this.ShowAll_btn.Name = "ShowAll_btn";
            this.ShowAll_btn.Size = new System.Drawing.Size(127, 48);
            this.ShowAll_btn.TabIndex = 7;
            this.ShowAll_btn.Text = "Show All Contacts";
            this.ShowAll_btn.UseVisualStyleBackColor = true;
            this.ShowAll_btn.Click += new System.EventHandler(this.ShowAll_btn_Click);
            // 
            // AddContact_btn
            // 
            this.AddContact_btn.Location = new System.Drawing.Point(166, 66);
            this.AddContact_btn.Name = "AddContact_btn";
            this.AddContact_btn.Size = new System.Drawing.Size(127, 48);
            this.AddContact_btn.TabIndex = 8;
            this.AddContact_btn.Text = "Add Contact";
            this.AddContact_btn.UseVisualStyleBackColor = true;
            this.AddContact_btn.Click += new System.EventHandler(this.AddContact_btn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(12, 66);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(127, 48);
            this.SearchBtn.TabIndex = 9;
            this.SearchBtn.Text = "Search Contact";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "This is your Contact Manager";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 127);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.AddContact_btn);
            this.Controls.Add(this.ShowAll_btn);
            this.Name = "main";
            this.Text = "Contact Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ShowAll_btn;
        private System.Windows.Forms.Button AddContact_btn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label1;
    }
}

