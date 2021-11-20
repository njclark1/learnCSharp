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
            this.account = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.accountInput = new System.Windows.Forms.TextBox();
            this.submitAccount = new System.Windows.Forms.Button();
            this.deleteAccount = new System.Windows.Forms.Button();
            this.accountList = new System.Windows.Forms.ListView();
            this.accountsView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usernamesView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PasswordsView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // account
            // 
            this.account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.account.Location = new System.Drawing.Point(971, 12);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(100, 15);
            this.account.TabIndex = 2;
            this.account.Text = "Account";
            this.account.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(914, 198);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(216, 22);
            this.passwordInput.TabIndex = 9;
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Location = new System.Drawing.Point(971, 177);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 15);
            this.password.TabIndex = 4;
            this.password.Text = "Password";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(914, 115);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(216, 22);
            this.usernameInput.TabIndex = 8;
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Location = new System.Drawing.Point(971, 94);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 15);
            this.username.TabIndex = 6;
            this.username.Text = "Username";
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // accountInput
            // 
            this.accountInput.Location = new System.Drawing.Point(914, 40);
            this.accountInput.Name = "accountInput";
            this.accountInput.Size = new System.Drawing.Size(216, 22);
            this.accountInput.TabIndex = 7;
            // 
            // submitAccount
            // 
            this.submitAccount.Location = new System.Drawing.Point(971, 269);
            this.submitAccount.Name = "submitAccount";
            this.submitAccount.Size = new System.Drawing.Size(100, 72);
            this.submitAccount.TabIndex = 8;
            this.submitAccount.Text = "submit";
            this.submitAccount.UseVisualStyleBackColor = true;
            this.submitAccount.Click += new System.EventHandler(this.submitAccount_Click);
            // 
            // deleteAccount
            // 
            this.deleteAccount.Location = new System.Drawing.Point(971, 674);
            this.deleteAccount.Name = "deleteAccount";
            this.deleteAccount.Size = new System.Drawing.Size(100, 81);
            this.deleteAccount.TabIndex = 9;
            this.deleteAccount.Text = "delete";
            this.deleteAccount.UseVisualStyleBackColor = true;
            // 
            // accountList
            // 
            this.accountList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.accountsView,
            this.usernamesView,
            this.PasswordsView});
            this.accountList.HideSelection = false;
            this.accountList.Location = new System.Drawing.Point(230, 12);
            this.accountList.Name = "accountList";
            this.accountList.Size = new System.Drawing.Size(633, 882);
            this.accountList.TabIndex = 10;
            this.accountList.UseCompatibleStateImageBehavior = false;
            this.accountList.View = System.Windows.Forms.View.Details;
            // 
            // accountsView
            // 
            this.accountsView.Text = "Account";
            this.accountsView.Width = 200;
            // 
            // usernamesView
            // 
            this.usernamesView.Text = "Username";
            this.usernamesView.Width = 200;
            // 
            // PasswordsView
            // 
            this.PasswordsView.Text = "Password";
            this.PasswordsView.Width = 200;
            // 
            // passwords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 784);
            this.Controls.Add(this.accountList);
            this.Controls.Add(this.deleteAccount);
            this.Controls.Add(this.submitAccount);
            this.Controls.Add(this.accountInput);
            this.Controls.Add(this.username);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.password);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.account);
            this.Controls.Add(this.backToLists);
            this.MaximumSize = new System.Drawing.Size(1186, 1147);
            this.MinimumSize = new System.Drawing.Size(1186, 1028);
            this.Name = "passwords";
            this.Text = "passwords";
            this.Load += new System.EventHandler(this.passwords_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToLists;
        private System.Windows.Forms.TextBox account;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox accountInput;
        private System.Windows.Forms.Button submitAccount;
        private System.Windows.Forms.Button deleteAccount;
        private System.Windows.Forms.ListView accountList;
        private System.Windows.Forms.ColumnHeader accountsView;
        private System.Windows.Forms.ColumnHeader usernamesView;
        private System.Windows.Forms.ColumnHeader PasswordsView;
    }
}