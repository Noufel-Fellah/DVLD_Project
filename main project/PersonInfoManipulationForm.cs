using bussinessLayer;
using System;

using System.Windows.Forms;

namespace DVLD
{
    public partial class PersonInfoManipulationForm : Form
    {
        //Declare a delegate(like declaring enum or struct)
        public delegate void handleBackData(clsPerson person);
        //Delcare an event from handleBackData type(using delegate)
        public event handleBackData BackData;
        //raise BackData event.
        public void FillThePersonMail(clsPerson person)
        {
            BackData?.Invoke(person);
        }

        public PersonInfoManipulationForm(int personID)
        {

            InitializeComponent();
            fillForm1.setMode(personID);
        }

        private void fillForm1_close_Form(object arg1, EventArgs arg2)
        {
            FillThePersonMail(fillForm1.Person());
            this.Close();
        }
    }
}
