using System;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class MultiplePasswordsForm : Form
    {
        private short _numberOfPasswords;
        public MultiplePasswordsForm()
        {
            InitializeComponent();
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            rtbMultiplePasswords.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void MultiplePasswordsForm_Load(object sender, EventArgs e)
        {
            _numberOfPasswords = (short)nudNumberOfPasswords.Value;
            btnSave.Enabled = rtbMultiplePasswords.Text.Length > 0;
            rtbMultiplePasswords.Clear();
        }

        private void MultiplePasswords_SizeChanged(object sender, EventArgs e)
        {
            rtbMultiplePasswords.Invalidate();
        }

        private void NudNumberOfPasswords_ValueChanged(object sender, EventArgs e)
        {
            _numberOfPasswords = (short)nudNumberOfPasswords.Value;
        }

        private void BtnGenerateMultiplePasswords_Click(object sender, EventArgs e)
        {
            rtbMultiplePasswords.Clear();
            for (short i = 0; i < _numberOfPasswords; i++)
            {
                rtbMultiplePasswords.Text += ClsPassword.GeneratePassword();
                rtbMultiplePasswords.Text += "\n";
            }
        }

        private void RtbMultiplePasswords_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = rtbMultiplePasswords.Text.Length > 0;
        }
    }
}
