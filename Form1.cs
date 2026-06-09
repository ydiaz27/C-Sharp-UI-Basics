using System.DirectoryServices.ActiveDirectory;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbState.SelectedIndex = 12; //Default state: IL
            lstEthnicity.SelectedIndex = 3; //Default ethnicity: Hispanic
            rdoSingle.Checked = true; //Default marital status: Single
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow letters and backspace only
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow letters and backspace only
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow letters and backspace only
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow numbers and the hyphen (-), but not letters, backspace must work
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 45)
            {
                e.Handled = true;
            }
        }

        //Check to see if all controls are validated
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == string.Empty)
            {
                MessageBox.Show("Please fill in the First Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtLastName.Text == string.Empty)
            {
                MessageBox.Show("Please fill in the Last Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtAddress.Text == string.Empty)
            {
                MessageBox.Show("Please fill in the Address.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtCity.Text == string.Empty)
            {
                MessageBox.Show("Please fill in the City.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbState.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a State.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtZipCode.Text == string.Empty)
            {
                MessageBox.Show("Please fill in the Zip Code.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lstEthnicity.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Ethnicity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Nothing for Veteran, as not everyone is a veteran

            if (dtpBirthDate.Value == DateTime.Now)
            {
                MessageBox.Show("Please put in your Birth Date.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rdoDivorced.Checked == false && rdoMarried.Checked == false && rdoSingle.Checked == false)
            {
                MessageBox.Show("Please select a Marital Status.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //Resets all the controls on the form + puts focus to the First Name
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            cmbState.SelectedIndex = -1;
            txtZipCode.Clear();
            lstEthnicity.SelectedIndex = -1;
            dtpBirthDate.Value = DateTime.Now;
            chkVeteran.Checked = false;
            rdoDivorced.Checked = false;
            rdoMarried.Checked = false;
            rdoSingle.Checked = false;
            txtFirstName.Focus();
        }
    }
}
