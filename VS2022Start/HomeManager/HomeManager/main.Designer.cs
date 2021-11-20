namespace HomeManager
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
            this.passwords = new System.Windows.Forms.Button();
            this.toDo = new System.Windows.Forms.CheckedListBox();
            this.newToDo = new System.Windows.Forms.TextBox();
            this.toDoSubmit = new System.Windows.Forms.Button();
            this.deleteSelectedToDo = new System.Windows.Forms.Button();
            this.deleteSelectedGrocery = new System.Windows.Forms.Button();
            this.grocerySubmit = new System.Windows.Forms.Button();
            this.newGrocery = new System.Windows.Forms.TextBox();
            this.groceryList = new System.Windows.Forms.CheckedListBox();
            this.toDoLabel = new System.Windows.Forms.TextBox();
            this.groceryListLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // passwords
            // 
            this.passwords.Location = new System.Drawing.Point(4, 359);
            this.passwords.Margin = new System.Windows.Forms.Padding(4);
            this.passwords.Name = "passwords";
            this.passwords.Size = new System.Drawing.Size(129, 74);
            this.passwords.TabIndex = 0;
            this.passwords.Text = "passwords";
            this.passwords.UseVisualStyleBackColor = true;
            this.passwords.Click += new System.EventHandler(this.launchPasswords);
            // 
            // toDo
            // 
            this.toDo.CheckOnClick = true;
            this.toDo.FormattingEnabled = true;
            this.toDo.Location = new System.Drawing.Point(141, 43);
            this.toDo.Margin = new System.Windows.Forms.Padding(4);
            this.toDo.Name = "toDo";
            this.toDo.Size = new System.Drawing.Size(414, 650);
            this.toDo.TabIndex = 1;
            this.toDo.ThreeDCheckBoxes = true;
            // 
            // newToDo
            // 
            this.newToDo.Location = new System.Drawing.Point(590, 26);
            this.newToDo.Margin = new System.Windows.Forms.Padding(4);
            this.newToDo.Name = "newToDo";
            this.newToDo.Size = new System.Drawing.Size(132, 22);
            this.newToDo.TabIndex = 2;
            // 
            // toDoSubmit
            // 
            this.toDoSubmit.Location = new System.Drawing.Point(590, 58);
            this.toDoSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.toDoSubmit.Name = "toDoSubmit";
            this.toDoSubmit.Size = new System.Drawing.Size(133, 43);
            this.toDoSubmit.TabIndex = 3;
            this.toDoSubmit.Text = "submit";
            this.toDoSubmit.UseVisualStyleBackColor = true;
            this.toDoSubmit.Click += new System.EventHandler(this.addToDo);
            // 
            // deleteSelectedToDo
            // 
            this.deleteSelectedToDo.Location = new System.Drawing.Point(589, 176);
            this.deleteSelectedToDo.Margin = new System.Windows.Forms.Padding(4);
            this.deleteSelectedToDo.Name = "deleteSelectedToDo";
            this.deleteSelectedToDo.Size = new System.Drawing.Size(133, 43);
            this.deleteSelectedToDo.TabIndex = 4;
            this.deleteSelectedToDo.Text = "delete selected";
            this.deleteSelectedToDo.UseVisualStyleBackColor = true;
            this.deleteSelectedToDo.Click += new System.EventHandler(this.deleteSelectedToDo_Click);
            // 
            // deleteSelectedGrocery
            // 
            this.deleteSelectedGrocery.Location = new System.Drawing.Point(1233, 176);
            this.deleteSelectedGrocery.Margin = new System.Windows.Forms.Padding(4);
            this.deleteSelectedGrocery.Name = "deleteSelectedGrocery";
            this.deleteSelectedGrocery.Size = new System.Drawing.Size(133, 43);
            this.deleteSelectedGrocery.TabIndex = 8;
            this.deleteSelectedGrocery.Text = "delete selected";
            this.deleteSelectedGrocery.UseVisualStyleBackColor = true;
            this.deleteSelectedGrocery.Click += new System.EventHandler(this.deleteSelectedGrocery_Click);
            // 
            // grocerySubmit
            // 
            this.grocerySubmit.Location = new System.Drawing.Point(1234, 58);
            this.grocerySubmit.Margin = new System.Windows.Forms.Padding(4);
            this.grocerySubmit.Name = "grocerySubmit";
            this.grocerySubmit.Size = new System.Drawing.Size(133, 43);
            this.grocerySubmit.TabIndex = 7;
            this.grocerySubmit.Text = "submit";
            this.grocerySubmit.UseVisualStyleBackColor = true;
            this.grocerySubmit.Click += new System.EventHandler(this.addGrocery);
            // 
            // newGrocery
            // 
            this.newGrocery.Location = new System.Drawing.Point(1234, 26);
            this.newGrocery.Margin = new System.Windows.Forms.Padding(4);
            this.newGrocery.Name = "newGrocery";
            this.newGrocery.Size = new System.Drawing.Size(132, 22);
            this.newGrocery.TabIndex = 6;
            // 
            // groceryList
            // 
            this.groceryList.CheckOnClick = true;
            this.groceryList.FormattingEnabled = true;
            this.groceryList.Location = new System.Drawing.Point(776, 43);
            this.groceryList.Margin = new System.Windows.Forms.Padding(4);
            this.groceryList.Name = "groceryList";
            this.groceryList.Size = new System.Drawing.Size(413, 650);
            this.groceryList.TabIndex = 5;
            this.groceryList.ThreeDCheckBoxes = true;
            // 
            // toDoLabel
            // 
            this.toDoLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toDoLabel.Location = new System.Drawing.Point(295, 13);
            this.toDoLabel.Margin = new System.Windows.Forms.Padding(4);
            this.toDoLabel.Name = "toDoLabel";
            this.toDoLabel.Size = new System.Drawing.Size(132, 15);
            this.toDoLabel.TabIndex = 9;
            this.toDoLabel.Text = "To-Do List";
            this.toDoLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groceryListLabel
            // 
            this.groceryListLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groceryListLabel.Location = new System.Drawing.Point(930, 13);
            this.groceryListLabel.Margin = new System.Windows.Forms.Padding(4);
            this.groceryListLabel.Name = "groceryListLabel";
            this.groceryListLabel.Size = new System.Drawing.Size(132, 15);
            this.groceryListLabel.TabIndex = 10;
            this.groceryListLabel.Text = "Grocery List";
            this.groceryListLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 719);
            this.Controls.Add(this.groceryListLabel);
            this.Controls.Add(this.toDoLabel);
            this.Controls.Add(this.deleteSelectedGrocery);
            this.Controls.Add(this.grocerySubmit);
            this.Controls.Add(this.newGrocery);
            this.Controls.Add(this.groceryList);
            this.Controls.Add(this.deleteSelectedToDo);
            this.Controls.Add(this.toDoSubmit);
            this.Controls.Add(this.newToDo);
            this.Controls.Add(this.toDo);
            this.Controls.Add(this.passwords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1442, 946);
            this.MinimumSize = new System.Drawing.Size(1442, 946);
            this.Name = "main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button passwords;
        private System.Windows.Forms.CheckedListBox toDo;
        private System.Windows.Forms.TextBox newToDo;
        private System.Windows.Forms.Button toDoSubmit;
        private System.Windows.Forms.Button deleteSelectedToDo;
        private System.Windows.Forms.Button deleteSelectedGrocery;
        private System.Windows.Forms.Button grocerySubmit;
        private System.Windows.Forms.TextBox newGrocery;
        private System.Windows.Forms.CheckedListBox groceryList;
        private System.Windows.Forms.TextBox toDoLabel;
        private System.Windows.Forms.TextBox groceryListLabel;
    }
}