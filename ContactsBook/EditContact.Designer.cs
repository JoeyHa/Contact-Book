namespace ContactsBook
{
    partial class EditContact
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
            this.Update_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstUpdate = new System.Windows.Forms.TextBox();
            this.LastUpdate = new System.Windows.Forms.TextBox();
            this.phoneUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Update_btn
            // 
            this.Update_btn.Location = new System.Drawing.Point(124, 226);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(162, 54);
            this.Update_btn.TabIndex = 0;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // firstUpdate
            // 
            this.firstUpdate.Location = new System.Drawing.Point(148, 107);
            this.firstUpdate.Name = "firstUpdate";
            this.firstUpdate.Size = new System.Drawing.Size(169, 20);
            this.firstUpdate.TabIndex = 4;
            
            // 
            // LastUpdate
            // 
            this.LastUpdate.Location = new System.Drawing.Point(148, 137);
            this.LastUpdate.Name = "LastUpdate";
            this.LastUpdate.Size = new System.Drawing.Size(169, 20);
            this.LastUpdate.TabIndex = 5;
            // 
            // phoneUpdate
            // 
            this.phoneUpdate.Location = new System.Drawing.Point(148, 164);
            this.phoneUpdate.Name = "phoneUpdate";
            this.phoneUpdate.Size = new System.Drawing.Size(169, 20);
            this.phoneUpdate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Edit Contact Details:";
            // 
            // EditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 320);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneUpdate);
            this.Controls.Add(this.LastUpdate);
            this.Controls.Add(this.firstUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Update_btn);
            this.Name = "EditContact";
            this.Text = "EditContact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstUpdate;
        private System.Windows.Forms.TextBox LastUpdate;
        private System.Windows.Forms.TextBox phoneUpdate;
        private System.Windows.Forms.Label label4;
    }
}