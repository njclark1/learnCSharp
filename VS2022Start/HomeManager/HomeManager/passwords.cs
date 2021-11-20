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
using System.Data.SqlClient;

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
            // TODO: This line of code loads data into the 'modelDataSet.accountTable' table. You can move, or remove it, as needed.
            this.accountTableTableAdapter.Fill(this.modelDataSet.accountTable);
            // TODO: This line of code loads data into the 'modelDataSet.accountTable' table. You can move, or remove it, as needed.
            this.accountTableTableAdapter.Fill(this.modelDataSet.accountTable);
        }

        //back button
        private void backToLists_Click(object sender, EventArgs e)
        {
            var mainForm = new main();
            mainForm.Show();
            this.Hide();
        }//endbackbutton

        private void accountTableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.accountTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

        }

        private void accountTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
