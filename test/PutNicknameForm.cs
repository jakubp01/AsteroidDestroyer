using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace test
{
    public partial class PutNicknameForm : Form
    {

        public string _playerNickname;
        public bool isOpen = true;
        public PutNicknameForm()
        {
            InitializeComponent();
        }

        private void PutNicknameForm_Load(object sender, EventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e, ErrorProvider errorProvider)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(nicknameTB.Text, "message");
            }

        }

        private void emptyNickValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(nicknameTB.Text))
            {
                e.Cancel = true;
                nicknameTB.Focus();
                errorProvider1.SetError(nicknameTB, "Set your nickname!");
            }
            else
            {
                _playerNickname = nicknameTB.Text;
                isOpen = false;
                Visible = false;
                this.Close();

            }
        }
    }
}
