using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TV_advert_WF
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            workersTableAdapter1.InsertQuery(textBoxTitle.Text, textBoxLogin.Text, textBoxPassword.Text, 3);
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Вы уверены отменить регистрацию?", "Отмена", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
                this.Close();
        }
    }
}
