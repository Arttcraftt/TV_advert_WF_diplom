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
    public partial class ProgramEditForm : Form
    {
        public ProgramEditForm()
        {
            InitializeComponent();
        }

        private void ProgramEditForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertDataSet.ProgramsWithTitles". При необходимости она может быть перемещена или удалена.
            this.programsWithTitlesTableAdapter.Fill(this.advertDataSet.ProgramsWithTitles);

        }

        private void addProgButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteProgButton_Click(object sender, EventArgs e)
        {

        }

        private void changeProgButton_Click(object sender, EventArgs e)
        {

        }
    }
}
