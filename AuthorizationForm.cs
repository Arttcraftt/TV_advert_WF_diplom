using System;
using System.Windows.Forms;

namespace TV_advert_WF
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            DialogResult = DialogResult.None;
            
        }
        public int Role;
        private void buttonEnter_Click(object sender, EventArgs e) //открытие основной формы
        {
            if(workersTableAdapter1.ScalarQueryRoles(textBoxLogin.Text, textBoxPassword.Text) == null)
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }
            Role = (int)workersTableAdapter1.ScalarQueryRoles(textBoxLogin.Text, textBoxPassword.Text);
            this.Close();
        }

        private void buttonRegistration_Click(object sender, EventArgs e) //открытие формы регистрации
        {
            RegistrationForm form = new RegistrationForm();
            form.ShowDialog();
        }
    }
}
