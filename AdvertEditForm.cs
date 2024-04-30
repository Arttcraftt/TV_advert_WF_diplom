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
    public partial class AdvertEditForm : Form
    {
        public AdvertEditForm()
        {
            InitializeComponent();
        }

        private void AdvertForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertDataSet.Сustomers". При необходимости она может быть перемещена или удалена.
            this.сustomersTableAdapter.Fill(this.advertDataSet.Сustomers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertDataSet.AdvertsWithTitles". При необходимости она может быть перемещена или удалена.
            this.advertsWithTitlesTableAdapter.Fill(this.advertDataSet.AdvertsWithTitles);

        }

        private void addAdvertButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteAdvertButton_Click(object sender, EventArgs e)
        {

        }

        private void changeAdvertButton_Click(object sender, EventArgs e)
        {

        }

        private void addCustomButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteCustomButton_Click(object sender, EventArgs e)
        {

        }

        private void changeCustomButton_Click(object sender, EventArgs e)
        {

        }
    }
}
