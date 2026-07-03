using bussinessLayer;
using System;

using System.Data;

using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD
{
    public partial class UserManagement : Form
    {
        private DataView _userTable;
        private bool dataFilled = false;
        private void _LoadData()
        {
            cbChoicesOfFilters.SelectedItem = "none";
            _userTable = clsUser.UserTable();
            dgbUsersTable.DataSource = _userTable;
            dataFilled=true;
            lbNumOfRecords.Text=_userTable.Count.ToString();

        }
        public UserManagement()
        {
            InitializeComponent();
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbChoicesOfFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            //items in chChoicesOfFilters combo box controlle

            //0-none
            //1-UserID
            //2-PersonID
            //3-FullName
            //4-UserName
            //5-IsActive
            if (dataFilled)
            {
                if (cbChoicesOfFilters.SelectedIndex == 5)
                {
                    cmIsActioveChoices.Visible = true;
                    tbSearchValue.Visible = false;
                }
                else if (cbChoicesOfFilters.SelectedIndex == 0)
                {
                    tbSearchValue.Visible = false;
                    cmIsActioveChoices.Visible = false;
                    _userTable.RowFilter = "";
                    lbNumOfRecords.Text = _userTable.Count.ToString();
                }
                else
                {
                    tbSearchValue.Visible = true;
                    cmIsActioveChoices.Visible = false;

                }
            }
            }

        private void tbSearchValue_TextChanged(object sender, EventArgs e)
        {
            //items in chChoicesOfFilters combo box controlle
            //0-none
            //1-UserID
            //2-PersonID
            //3-FullName
            //4-UserName
            //5-IsActive
            if (tbSearchValue.Text != "")
            {
                if (cbChoicesOfFilters.SelectedIndex == 1 || cbChoicesOfFilters.SelectedIndex == 2)
                {
                    if (int.TryParse(tbSearchValue.Text, out int result))
                    {
                        _userTable.RowFilter = $"{cbChoicesOfFilters.SelectedItem} ={result}";
                        lbNumOfRecords.Text = _userTable.Count.ToString();

                    }
                    else
                    {
                        tbSearchValue.Text = "";
                    }


                }
                else
                {
                    _userTable.RowFilter = $"{cbChoicesOfFilters.SelectedItem} like '{tbSearchValue.Text}%'";

                }
            }
            else
            {
                _userTable.RowFilter = "";
                lbNumOfRecords.Text = _userTable.Count.ToString();

            }


        }

        private void cmIsActioveChoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            //The items in cmIsActiveChoices combo box controlle
            //0-All
            //1- Yes
            //2- No
            if (cmIsActioveChoices.SelectedIndex == 1)
            {
                _userTable.RowFilter = $"IsActive =True";
                lbNumOfRecords.Text= _userTable.Count.ToString();
            }else if(cmIsActioveChoices.SelectedIndex == 2)
            {
                _userTable.RowFilter = $"IsActive =False";
                lbNumOfRecords.Text = _userTable.Count.ToString();
            }
            else
            {
                _userTable.RowFilter = "";
                lbNumOfRecords.Text = _userTable.Count.ToString();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddOrEditUser form=new AddOrEditUser(-1);//-1 to initiale the adding user settings
            form.ShowDialog() ; 
            _LoadData() ; 
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //set the add mode.
            AddOrEditUser form = new AddOrEditUser(-1);
            form.ShowDialog() ;
        }

        private void dgbUsersTable_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgbUsersTable.ClearSelection();
                dgbUsersTable.Rows[e.RowIndex].Selected = true;
                dgbUsersTable.CurrentCell = dgbUsersTable.Rows[e.RowIndex].Cells[0];
            }
        }

        private void dgbUsersTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgbUsersTable.ClearSelection();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgbUsersTable .CurrentRow != null)
            {
                int id = int.Parse(dgbUsersTable.CurrentRow.Cells["UserID"].Value.ToString());
               AddOrEditUser  form = new AddOrEditUser(id);
                form.ShowDialog();
                _LoadData();
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgbUsersTable.CurrentRow != null)
            {
                int id = int.Parse(dgbUsersTable.CurrentRow.Cells["UserID"].Value.ToString());
                ShowDetailsInUserManagement form = new ShowDetailsInUserManagement(id);
                form.ShowDialog();
                _LoadData();
            }
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be soon");
        }

        private void callPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be soon");

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgbUsersTable.CurrentRow != null)
            {
                int id = int.Parse(dgbUsersTable.CurrentRow.Cells["UserID"].Value.ToString());
                ChangePasswordScreen form = new ChangePasswordScreen(id);
                form.ShowDialog();
                _LoadData();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgbUsersTable.CurrentRow != null)
            {
                int id = int.Parse(dgbUsersTable.CurrentRow.Cells["UserID"].Value.ToString());
                
                if (clsUser.DeleteUserWithID(id))
                {
                    MessageBox.Show($"The user with ID {id} has been deleted","Information");
                }
                else
                {
                    MessageBox.Show($"This user has past actions in this program,we can't delete this user right now ");

                }

                _LoadData();
            }
            
        }
    }
}
