using System;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        private MultiplePasswordsForm _mForm;
        public Form1()
        {
            InitializeComponent();
            _mForm = new MultiplePasswordsForm();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClsPassword.IsIntegerNeeded = true;
            ClsPassword.IsLowerCaseNeeded = true;
            ClsPassword.IsUpperCaseNeeded = true;
            ClsPassword.IsSpecialCharNeeded = true;
            ClsPassword.Length = Convert.ToInt16(nbLength.Text);
            ClsPassword.IsMemorable = false;
            tbKeyWord.Text = "KOKOSoft";
            tbSinglePassword.ReadOnly = true;
            lblBits.BackColor = Color.Transparent;
            MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void CbInt_CheckedChanged(object sender, EventArgs e)
        {
            ClsPassword.IsIntegerNeeded = cbInt.Checked;
        }

        private void CbLowerCase_CheckedChanged(object sender, EventArgs e)
        {
            ClsPassword.IsLowerCaseNeeded = cbLowerCase.Checked;
        }

        private void CbUpperCase_CheckedChanged(object sender, EventArgs e)
        {
            ClsPassword.IsUpperCaseNeeded = cbUpperCase.Checked;
        }

        private void CbSpecialChars_CheckedChanged(object sender, EventArgs e)
        {
            ClsPassword.IsSpecialCharNeeded = cbSpecialChars.Checked;
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            string password = ClsPassword.GeneratePassword();
            tbSinglePassword.Text = password;
            ClsPassword.CalculatePasswordEntropy(tbSinglePassword.Text);
            if (password.Length > 0)
            {
                lblBits.Text = $"{Math.Round(ClsPassword.NumberOfBits, 2)} bits";
            }
        }

        private void TbPasswordType_Selected(object sender, TabControlEventArgs e)
        {
            if (tbPasswordType.SelectedTab.Text == "Random")
            {
                ClsPassword.IsMemorable = false;
                ClsPassword.KeyWord = "";
            }
            else
            {
                ClsPassword.IsMemorable = true;
                ClsPassword.KeyWord = tbKeyWord.Text;
            }
        }

        private void NbLength_ValueChanged(object sender, EventArgs e)
        {
            ClsPassword.Length = Convert.ToInt16(nbLength.Value);
        }

        private void TbKeyWord_TextChanged(object sender, EventArgs e)
        {
            ClsPassword.KeyWord = tbKeyWord.Text;
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(tbSinglePassword.Text);
        }

        private void CcontextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void GenerateMultiplePasswordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mForm.ShowDialog();
        }
    }
}
