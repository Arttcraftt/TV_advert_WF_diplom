using System;
using System.Windows.Forms;

namespace TV_advert_WF
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e) //регистрация нового работника с ролью гость
        {
            workersTableAdapter1.InsertQuery(textBoxTitle.Text, textBoxLogin.Text, textBoxPassword.Text, 3);
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) //отмена регистрации
        {
            if(MessageBox.Show("Вы уверены отменить регистрацию?", "Отмена", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
                this.Close();
        }
    }
}
