using bussinessLayer;
using System;

using System.Windows.Forms;

namespace DVLD
{
    public partial class SearchForPerson : UserControl
    {
        private clsPerson _person;
        private bool _personPartDone = false;
        //private bool _userPartDone = false;
        public SearchForPerson()
        {
            InitializeComponent();
            cbSearchBarChoices.SelectedIndex = 0;

        }

        private void  _VoidMode()
        {
            gbSearchGroup.Enabled = true;
            _person =  null;
            showDetails1.FillInformation();//There 's no person.
        }
        private void _FullMode(int ID)
        {
            gbSearchGroup.Enabled = false;//in the update mode ,you can't change the person completely
            _person=clsPerson.FindPerson(ID);
            showDetails1.FillInformation(_person);//Fill the person's information part.
            _personPartDone = true;
        }
        public void SetPerson(int personID =-1)
        {
            //personID=-1:set the void mode.
            //personID>0!set the full mode.
            if (personID == -1)
            {
                _VoidMode();
            }
            else if (personID > 0)
            {
                _FullMode(personID);
            }
        }
        private void btnSearchAboutPerson_Click(object sender, EventArgs e)
        {
            //Fill the person's information in show details if the person exists in data base.
            if (cbSearchBarChoices.SelectedIndex == 0 && int.TryParse(tbSearchBar.Text, out int ID))
            {//search about person by person ID. 
                if ((_person = clsPerson.FindPerson(ID)) != null)
                {
                    if (showDetails1.FillInformation(_person)) _personPartDone = true;

                }
                else
                {
                    MessageBox.Show($"The person is not found with this ID: {tbSearchBar.Text}", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showDetails1.Clear();
                }
            }
            else//search about person by national number.
            {
                if ((_person = clsPerson.FindPerson(tbSearchBar.Text)) != null)
                {
                    if (showDetails1.FillInformation(_person)) _personPartDone = true;

                }
                else
                {
                    MessageBox.Show($"The person is not found with this National num: ID: {tbSearchBar.Text}", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showDetails1.Clear();
                }

            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            PersonInfoManipulationForm form = new PersonInfoManipulationForm(-1);
            form.BackData += setNewPerson;//subscribe in the PersonInfoManipulationForm's event. 
            form.ShowDialog();
        }


        private void setNewPerson(clsPerson person)
        {
            if (showDetails1.FillInformation(person))
            {
               _person = person;
                _personPartDone = true;

            }
        }

        private void btnRemovePerson_Click(object sender, EventArgs e)
        {
            if (_person != null)
            {

                EmptyPerson();
                _personPartDone = false;
               

            }
            else
            {

                MessageBox.Show("there is no person's information");



            }
        }

        public void EmptyPerson()
        {
            _person = null;
            showDetails1.Clear();
            tbSearchBar.Clear();
        }

        private void tbSearchBar_TextChanged(object sender, EventArgs e)
        {
            //cbSearchChoices combo box controlle's items
            // PersonID
            // NationalNo
            if (cbSearchBarChoices.SelectedIndex == 0)
            {
                if (!int.TryParse(tbSearchBar.Text, out int result))
                {
                    tbSearchBar.Text = "";
                }

            }
        }

        //Create an event .
        public event Action<clsPerson> NextOption;
        protected virtual void nextOptionRaiser(clsPerson person)
        {
            Action<clsPerson> handler = NextOption;
            if (handler!=null)
            {
                handler(person);  
            }

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
          if(NextOption!=null)
            {
                nextOptionRaiser(_person);
            }


        }
    
    
    
    }
}
