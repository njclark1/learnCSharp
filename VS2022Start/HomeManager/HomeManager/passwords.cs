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
                    passwordList.Items.Add(line);
                }
            }
        }//endinitpass

        //write password list to file when called
        private void writePasswordFile()
        {
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter("passwords.txt");
            foreach (var item in passwordList.Items)
            {
                SaveFile.WriteLine(item.ToString());
            }
            SaveFile.Close();
        }//endwritepasswordfile

        private void account_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
