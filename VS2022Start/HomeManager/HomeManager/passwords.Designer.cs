namespace HomeManager
{
    partial class passwords
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
            this.backToLists = new System.Windows.Forms.Button();
            this.passwordList = new System.Windows.Forms.ListView();
            this.accountHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usernameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.passwordHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backToLists
            // 
            this.backToLists.Location = new System.Drawing.Point(12, 12);
            this.backToLists.Name = "backToLists";
            this.backToLists.Size = new System.Drawing.Size(169, 74);
            this.backToLists.TabIndex = 0;
            this.backToLists.Text = "Back To Lists";
            this.backToLists.UseVisualStyleBackColor = true;
            this.backToLists.Click += new System.EventHandler(this.backToLists_Click);
            // 
            // passwordList
            // 
            this.passwordList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.accountHeader,
            this.usernameHeader,
            this.passwordHeader});
            this.passwordList.HideSelection = false;
            this.passwordList.Location = new System.Drawing.Point(221, 12);
            this.passwordList.Name = "passwordList";
            this.passwordList.Size = new System.Drawing.Size(656, 1203);
            this.passwordList.TabIndex = 1;
            this.passwordList.UseCompatibleStateImageBehavior = false;
            this.passwordList.View = System.Windows.Forms.View.Details;
            // 
            // accountHeader
            // 
            this.accountHeader.Text = "Account";
            this.accountHeader.Width = 179;
            // 
            // usernameHeader
            // 
            this.usernameHeader.Text = "Username";
            this.usernameHeader.Width = 215;
            // 
            // passwordHeader
            // 
            this.passwordHeader.Text = "Password";
            this.passwordHeader.Width = 259;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1049, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1049, 479);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1049, 396);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1049, 323);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1049, 226);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1049, 118);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 7;
            // 
            // passwords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2380, 1238);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.passwordList);
            this.Controls.Add(this.backToLists);
            this.MaximumSize = new System.Drawing.Size(1918, 1028);
            this.MinimumSize = new System.Drawing.Size(1918, 1028);
            this.Name = "passwords";
            this.Text = "passwords";
            this.Load += new System.EventHandler(this.passwords_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToLists;
        private System.Windows.Forms.ListView passwordList;
        private System.Windows.Forms.ColumnHeader accountHeader;
        private System.Windows.Forms.ColumnHeader usernameHeader;
        private System.Windows.Forms.ColumnHeader passwordHeader;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}