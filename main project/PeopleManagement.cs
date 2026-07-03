using bussinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD
{
    //to activate Add mode sent -1 to the form witch contains fillForm user-controlle
    //to activate Edit mode sent personID to the form.
    public partial class PeopleManagement : Form
    {
        private DataView _peopleTable;

        private void _LoadData()
        {
            _peopleTable = clsPerson.AllPersons();
            dataGridView1.DataSource = _peopleTable;
            //-iniallese none as an inialle value in the combo box 
            cbFilterByCollection.SelectedItem = "none";
            //-count the rows of data grid view.
            lbNumOfRecords.Text = _peopleTable.Count.ToString();




        }
        public PeopleManagement()
        {

            InitializeComponent();
            _LoadData();
        }



       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilterByCollection_SelectedIndexChanged(object sender, EventArgs e)
        {
            //enable and disable the text box which we write in the value that we're gonna to filter
            if (cbFilterByCollection.SelectedIndex != 0) tbFilteredValue.Visible = true;
            else tbFilteredValue.Visible = false;
            tbFilteredValue.Clear();
        }

        private void tbFilteredValue_TextChanged(object sender, EventArgs e)
        {
            if (cbFilterByCollection.SelectedItem.ToString() != "PersonID")
            {
                _peopleTable.RowFilter = $"{cbFilterByCollection.SelectedItem} like '{tbFilteredValue.Text}%'";

            }
            else if (string.IsNullOrEmpty(tbFilteredValue.Text))
            {
                _peopleTable.RowFilter = "";//refrech the people table.


            }
            //else if(cbFilterByCollection.SelectedItem.ToString() == "Nationality")
            //{

            //}
            else
            {//The case if we filter the people table by personID
                if (int.TryParse(tbFilteredValue.Text, out int ID))
                {

                    _peopleTable.RowFilter = $"PersonID={ID}";

                }
                else
                {
                    tbFilteredValue.Text = "";
                }
            }
            lbNumOfRecords.Text = dataGridView1.RowCount.ToString();


        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            
            PersonInfoManipulationForm frm = new PersonInfoManipulationForm(-1);
            frm.ShowDialog();
            _LoadData();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonInfoManipulationForm form=new PersonInfoManipulationForm(-1);
            form.ShowDialog();
            _LoadData();
        }

        private void showDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells["PersonID"].Value.ToString());
            ShowDetailsScreen form = new ShowDetailsScreen(id);
            form.ShowDialog();
            _LoadData();


        }

        private void peToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells["PersonID"].Value.ToString());
                PersonInfoManipulationForm form = new PersonInfoManipulationForm(id);
            form.ShowDialog();
            _LoadData();
        }
        }

       

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[0];
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();

            //dataGridView1.CurrentCell = null;
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be added soon");
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be added soon");

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null) {
               int ID= int.Parse(dataGridView1.CurrentRow.Cells["PersonID"].Value.ToString());
               if (MessageBox.Show($"Are you sure you want to delete this person who has the personID equals {ID}", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    if (!clsPerson.DeletePersonWith(ID)) { MessageBox.Show("Person was not deleted because it has data linked to it ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); }
                    else { MessageBox.Show("Person has been deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                _LoadData();





                        }
                        }

    
    }
}
