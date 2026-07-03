using bst;
using bussinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{

    public partial class SearchForDrivingLicense : UserControl
    {
        private bool _enableSearchBar;
        public bool EnableSearchBar
        {
            set
            {
                _enableSearchBar=value;
                gbFilter.Enabled = value;
            }
        }
        public event Action<clsLicenses> GetLicence;
        protected virtual void _GetLicense(clsLicenses license)
        {
            Action<clsLicenses> handler = GetLicence;
            if(handler!=null){
                handler(license);
    }
}
        

        public SearchForDrivingLicense()
        {
            InitializeComponent();
        }

        private void tbSearchBar_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(tbSearchBar.Text, out int value) ){

                tbSearchBar.Text = "";

            }
        }
       
      
        private void btnFind_Click(object sender, EventArgs e)
        {
            clsLicenses _license = clsLicenses.GetLicenseByLicenseID(int.Parse(tbSearchBar.Text));
            if (_license!=null&&_license.IsActive)
            {
                
                    driverLicenseInfo1.FillControl(_license);
                    if (GetLicence != null) {
                        _GetLicense(_license);
                    }
                
               

            }
            else
            {
                MessageBox.Show("Error,The Oldlicense was not  found");
            }
        }
        
   
    
    }
}
