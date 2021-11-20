using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HomeManager
{
    public partial class passwords : Form
    {
        public passwords()
        {
            InitializeComponent();
            
        }

        private void passwords_Load(object sender, EventArgs e)
        {
            initializePasswordList(); 
        }

        //back button
        private void backToLists_Click(object sender, EventArgs e)
        {
            var mainForm = new main();
            mainForm.Show();
            this.Hide();
        }//endbackbutton

        //initialize password list on launch
        private void initializePasswordList()
        {
            if (File.Exists("passwords.txt"))
            {

                var getPasswordFile = File.ReadAllLines("passwords.txt");
                foreach (var line in getPasswordFile)
                {
                    
                    accountList.Items.Add(line);
                }
            }
        }//endinitpass

        //write password list to file when called
        private void writePasswordFile()
        {
            int count = accountList.Items.Count;
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter("passwords.txt");
            for (int i = 0; i < count; i++)
            {
                SaveFile.WriteLine(accountList.Items[i].SubItems[0].Text);
                SaveFile.WriteLine(accountList.Items[i].SubItems[1].Text);
                SaveFile.WriteLine(accountList.Items[i].SubItems[2].Text);
            }
            SaveFile.Close();
        }//endwritepasswordfile

        private void submitAccount_Click(object sender, EventArgs e)
        {
            //variables for entering account
            string givenAccount = accountInput.Text;
            string givenUsername = usernameInput.Text;
            string givenPassword = passwordInput.Text;

            //new accountList item to add
            ListViewItem accountItem = new ListViewItem(givenAccount);
            accountItem.SubItems.Add(givenUsername);
            accountItem.SubItems.Add(givenPassword);
            //add item to list
            accountList.Items.Add(accountItem);
            writePasswordFile();
        }
    }
}
