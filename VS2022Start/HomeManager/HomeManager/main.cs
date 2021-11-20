using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace HomeManager
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }//endmain

        //main load
        private void main_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'modelDataSet.accountTable' table. You can move, or remove it, as needed.
            initializeToDoList();//loadtodolist
            initializeGroceryList();//loadgroclist
        }//endmainload

        //launch password form
        private void launchPasswords(object sender, System.EventArgs e)
        {
            var mainForm = new passwords();
            mainForm.Show();
            this.Hide();
        }//endlaunchpass
        
        //-------------------------------------- TO DO LIST -------------------------------------------//

        //initialize to do list on launch
        private void initializeToDoList()
        {
            if (File.Exists("toDo.txt"))
            {
                var getToDoFile = File.ReadAllLines("toDo.txt");
                foreach (var line in getToDoFile)
                {
                    toDo.Items.Add(line);
                }
            }
        }//endinittodolist

        //write to do list to file when called
        private void writeToDoToFile()
        {
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter("toDo.txt");
            foreach (var item in toDo.Items)
            {
                SaveFile.WriteLine(item.ToString());
            }
            SaveFile.Close();
        }//endwritetodofile

        //add item to to do list
        private void addToDo(object sender, System.EventArgs e)
        {
            string newToDoText = newToDo.Text;
            toDo.Items.Add(newToDoText);
            writeToDoToFile();//write to do list to file
        }//endaddtodo

        //delete item from to do list
        private void deleteSelectedToDo_Click(object sender, System.EventArgs e)
        {
           for (int i = 0; i < toDo.Items.Count; i++)
            {
                if (toDo.GetItemCheckState(i) == CheckState.Checked)
                {
                    toDo.Items.RemoveAt(i);
                }
            }
            writeToDoToFile();//write to do list to file
        }//enddeleteselectedtodo

        //-------------------------------------- GROCERY LIST -------------------------------------------//

        //initialize grocery list on launch
        private void initializeGroceryList()
        {
            if (File.Exists("groceries.txt"))
            {
                var getGroceryFile = File.ReadAllLines("groceries.txt");
                foreach (var line in getGroceryFile)
                {
                    groceryList.Items.Add(line);
                }
            }
        }//endinitgroc

        //write to do list to file when called
        private void writeGroceryFile()
        {
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter("groceries.txt");
            foreach (var item in groceryList.Items)
            {
                SaveFile.WriteLine(item.ToString());
            }
            SaveFile.Close();
        }//endwritetodofile

        //add item to to do list
        private void addGrocery(object sender, System.EventArgs e)
        {
            string newGroceryText = newGrocery.Text;
            groceryList.Items.Add(newGroceryText);
            writeGroceryFile();//write to do list to file
        }//endaddtodo

        //delete item from grochery list
        private void deleteSelectedGrocery_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < groceryList.Items.Count; i++)
            {
                if (groceryList.GetItemCheckState(i) == CheckState.Checked)
                {
                    groceryList.Items.RemoveAt(i);
                }
            }
            writeGroceryFile();//write to do list to file
        }//enddeletegroc

    }
}
