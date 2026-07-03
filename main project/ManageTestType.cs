using bst;
using System;

using System.Windows.Forms;

namespace DVLD
{
   
    public partial class ManageTestType : Form
    {
        private void _LoadData()
        {
            dataGridView1.DataSource=clsTestTypes.GetAllTestTypes();

    }




        public ManageTestType()
        {
            InitializeComponent();
            _LoadData();

        }





       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells["_testTypeID"].Value.ToString());
                UpdateTestType form = new UpdateTestType(id);
                form.ShowDialog();
                _LoadData();



            }
        }
    
    
        
        
    }
}
