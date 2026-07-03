using bussinessLayer;
using System;

using System.Windows.Forms;

namespace DVLD
{
    public partial class UpdateApplicationType : Form
    {
       private clsAppType _app;
       private void _LoadData(int id)
        {
             _app = clsAppType.FindApp(id) ;
            tbFees.Text = _app.appTypeFees.ToString();
            tbTilte.Text=_app.appTypeTitle.ToString();
            lbAppTypeID.Text=_app.ToString();


        }
       public UpdateApplicationType(int id)
        {
            InitializeComponent();
            _LoadData(id);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if((tbTilte.Text.Trim()==_app.appTypeTitle && (tbFees.Text.Trim() == _app.appTypeFees.ToString() || string.IsNullOrWhiteSpace(tbFees.Text))) || (string.IsNullOrWhiteSpace(tbTilte.Text) && ( tbFees.Text.Trim() == _app.appTypeFees.ToString() || string.IsNullOrWhiteSpace(tbFees.Text))))
               { this.Close();
            }
           
            else
            {
                if(MessageBox.Show("Are sure you want to cancel the updating operation", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((tbTilte.Text.Trim() == _app.appTypeTitle && (tbFees.Text.Trim() == _app.appTypeFees.ToString() || string.IsNullOrWhiteSpace(tbFees.Text))) || (string.IsNullOrWhiteSpace(tbTilte.Text) && (tbFees.Text.Trim() == _app.appTypeFees.ToString() || string.IsNullOrWhiteSpace(tbFees.Text))))

            {
                this.Close();
            }

            else
            {
                if (MessageBox.Show("Are sure you want to save the updating operation", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    _app.appTypeTitle= tbTilte.Text;
                    _app.appTypeFees=float.Parse( tbFees.Text);
                    if (_app.Save())
                    {
                        MessageBox.Show("The application type was updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("The application type was not updated successfully");

                    }

                }
            }

        }
    
        
    
    
    }
}
