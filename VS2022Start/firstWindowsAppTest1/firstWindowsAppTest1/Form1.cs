using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace firstWindowsAppTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            welcomeDisplay();

        }

        private void welcomeDisplay()
        {
            string a = "What is going on here?";
            welcome.Text = a;
            welcome.BorderStyle = BorderStyle.None;
            welcome.TextAlign = HorizontalAlignment.Center;
        }

        private void changeWelcomeDisplay(object sender, EventArgs e)
        {
            string b = "Text is changed";
            welcome.Text = b;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
