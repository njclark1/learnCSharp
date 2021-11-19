using System;
using System.Windows.Forms;

namespace HomeManager
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void launchMain(object sender, EventArgs e)
        {
            bool credentials = CheckCredentials();
            if (credentials == true)
            {
                var mainForm = new main();
                mainForm.Show();
                this.Hide();
            }
        }

        public bool CheckCredentials()
        {
            string correctUsername = "eandn";
            string correctPassword = "pass";
            string givenUsername = usernameBox.Text;
            string givenPassword = passwordBox.Text;   
            if (givenUsername != correctUsername && givenPassword != correctPassword)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
            
        }

    }
}


