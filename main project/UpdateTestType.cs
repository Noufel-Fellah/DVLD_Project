using bst;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class UpdateTestType : Form
    {
        clsTestTypes _test;
        private bool _testTitleHasChanged;
        private bool _testDescriptionHasChanged;
        private bool _testFessHasChanged;

        private void _LoadData(int id)
        {
            if (id <= 0 || id > 3) { Close(); }
            else
            {
                _test = clsTestTypes.FindTest(id);
                tbTilte.Text = _test.TestTypeTitle;
                tbDescription.Text = _test.TestTypeDescription;
                tbFees.Text = _test.TestTypeFees.ToString();
            }
        }
        public UpdateTestType(int id)
                {
                    InitializeComponent();
                    _LoadData(id);
                }

      

        private void tbTilte_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbTilte.Text)||tbTilte.Text==_test.TestTypeTitle) {
                _testTitleHasChanged = false;
            }
            else { _testTitleHasChanged = true; }
            
        }

        private void tbDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTilte.Text) || tbTilte.Text == _test.TestTypeTitle)
            {
                _testDescriptionHasChanged = false;
            }
            else { _testDescriptionHasChanged = true; }
        }

        private void tbFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTilte.Text) || tbTilte.Text == _test.TestTypeTitle)
            {
                _testFessHasChanged = false;
            }
            else { _testFessHasChanged = true; }
        }

        private void tbFees_TextChanged(object sender, EventArgs e)
        {
            if(!float.TryParse(tbFees.Text,out float  result))
            {
                tbFees.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(!_testDescriptionHasChanged && !_testFessHasChanged && !_testTitleHasChanged)
            {
                this.Close();
            }

            else
            {
                if (MessageBox.Show("Are sure you want to cancel the updating operation", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_testDescriptionHasChanged && !_testFessHasChanged && !_testTitleHasChanged)

            {
                this.Close();
            }

            else
            {
                if (MessageBox.Show("Are sure you want to save the updating operation", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    _test.TestTypeTitle = tbTilte.Text;
                    _test.TestTypeDescription = tbDescription.Text ;
                    _test.TestTypeFees = float.Parse(tbFees.Text);
                    _testDescriptionHasChanged = false;
                    _testTitleHasChanged = false;
                    _testFessHasChanged = false;
                    if (_test.Save())
                    {
                        MessageBox.Show("The test type was updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("The test type was not updated successfully");

                    }

                }
            }
        }
    }
}
