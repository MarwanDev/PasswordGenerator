using System;
using System.Drawing;
using System.Windows.Forms;
using PasswordGenerator.Properties;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        private readonly MultiplePasswordsForm _multiplePasswordsForm;
        private bool _isAutomaticCopy;
        public Form1()
        {
            InitializeComponent();
            _multiplePasswordsForm = new MultiplePasswordsForm();
            _isAutomaticCopy = false;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClsPassword.IsIntegerNeeded = Settings.Default.IsIntegerNeeded;
            ClsPassword.IsLowerCaseNeeded = Settings.Default.IsLowerCaseNeeded;
            ClsPassword.IsUpperCaseNeeded = Settings.Default.IsUpperCaseNeeded;
            ClsPassword.IsSpecialCharNeeded = Settings.Default.IsSpecialCharNeeded;
            nubLength.Value = Settings.Default.Length;
            ClsPassword.Length = (short)nubLength.Value;
            ClsPassword.IsMemorable = false;
            tbKeyWord.Text = Settings.Default.KeyWord;
            tbSinglePassword.ReadOnly = true;
            lblBits.BackColor = Color.Transparent;
            MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            automaticallyToolStripMenuItem.Checked = Settings.Default.AutomaticCopy;
            cbInt.Checked = Settings.Default.IsIntegerNeeded;
            cbLowerCase.Checked = Settings.Default.IsLowerCaseNeeded;
            cbUpperCase.Checked = Settings.Default.IsUpperCaseNeeded;
            cbSpecialChars.Checked = Settings.Default.IsSpecialCharNeeded;
        }

        private void CbInt_CheckedChanged(object sender, EventArgs e)
        {
            ClsPassword.IsIntegerNeeded = cbInt.Checked;
            Settings.Default.IsIntegerNeeded = ClsPassword.IsIntegerNeeded;
            Settings.Default.Save();
        }

        private void CbLowerCase_CheckedChanged(object sender, EventArgs e)
        {
            ClsPassword.IsLowerCaseNeeded = cbLowerCase.Checked;
            Settings.Default.IsLowerCaseNeeded = ClsPassword.IsLowerCaseNeeded;
            Settings.Default.Save();
        }

        private void CbUpperCase_CheckedChanged(object sender, EventArgs e)
        {
            ClsPassword.IsUpperCaseNeeded = cbUpperCase.Checked;
            Settings.Default.IsUpperCaseNeeded = ClsPassword.IsUpperCaseNeeded;
            Settings.Default.Save();
        }

        private void CbSpecialChars_CheckedChanged(object sender, EventArgs e)
        {
            ClsPassword.IsSpecialCharNeeded = cbSpecialChars.Checked;
            Settings.Default.IsSpecialCharNeeded = ClsPassword.IsSpecialCharNeeded;
            Settings.Default.Save();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            string password = ClsPassword.GeneratePassword();
            tbSinglePassword.Text = password;
            if (password.Length > 0)
            {
                ClsPassword.CalculatePasswordEntropy(tbSinglePassword.Text);
                lblBits.Text = $"{Math.Round(ClsPassword.NumberOfBits, 2)} bits";
                pbProgress.Value = Math.Abs(((int)Math.Floor(ClsPassword.NumberOfBits)));
                pbProgress.Refresh();
            }
            if (_isAutomaticCopy)
                System.Windows.Forms.Clipboard.SetText(tbSinglePassword.Text);
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
            ClsPassword.Length = (short)nubLength.Value;
            Settings.Default.Length = ClsPassword.Length;
            Settings.Default.Save();
        }

        private void TbKeyWord_TextChanged(object sender, EventArgs e)
        {
            ClsPassword.KeyWord = tbKeyWord.Text;
            Settings.Default.KeyWord = ClsPassword.KeyWord;
            Settings.Default.Save();
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(tbSinglePassword.Text);
        }

        private void GenerateMultiplePasswordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _multiplePasswordsForm.ShowDialog();
        }

        private void AutomaticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _isAutomaticCopy = automaticallyToolStripMenuItem.Checked;
            Settings.Default.AutomaticCopy = automaticallyToolStripMenuItem.Checked;
            Settings.Default.Save();
        }

        private void ResetToDefaultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show("Please note that the application will restart to reset settings to default",
                "Reset to Default",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information) == DialogResult.OK
                )
            {
                Settings.Default.Reset();
                Application.Restart();
            }
        }
    }
}
