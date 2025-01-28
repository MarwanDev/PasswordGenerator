using System;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class MultiplePasswordsForm : Form
    {
        public MultiplePasswordsForm()
        {
            InitializeComponent();
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            rtbMultiplePasswords.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void RtbMultiplePasswords_TextChanged(object sender, EventArgs e)
        {

        }

        private void MultiplePasswordsForm_Load(object sender, EventArgs e)
        {

        }

        private void MultiplePasswords_SizeChanged(object sender, EventArgs e)
        {
            rtbMultiplePasswords.Invalidate();
        }
    }
}
