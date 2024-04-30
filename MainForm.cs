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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertDataSet.BlocksWithCostAdvanced". При необходимости она может быть перемещена или удалена.
            this.blocksWithCostAdvancedTableAdapter.Fill(this.advertDataSet.BlocksWithCostAdvanced);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertDataSet.BlocksWithCost". При необходимости она может быть перемещена или удалена.
            this.blocksWithCostTableAdapter.Fill(this.advertDataSet.BlocksWithCost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertDataSet.Ratings". При необходимости она может быть перемещена или удалена.
            this.ratingsTableAdapter.Fill(this.advertDataSet.Ratings);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertDataSet.ProgramsWithTitles". При необходимости она может быть перемещена или удалена.
            this.programsWithTitlesTableAdapter.Fill(this.advertDataSet.ProgramsWithTitles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertDataSet.AdvertsWithTitles". При необходимости она может быть перемещена или удалена.
            this.advertsWithTitlesTableAdapter.Fill(this.advertDataSet.AdvertsWithTitles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertDataSet.BlocksWithTitles". При необходимости она может быть перемещена или удалена.
            this.blocksWithTitlesTableAdapter.Fill(this.advertDataSet.BlocksWithTitles);

        }

        private void blockEditButton_Click(object sender, EventArgs e)
        {

        }

        private void advertEditButton_Click(object sender, EventArgs e)
        {

        }


        private void programEditButton_Click(object sender, EventArgs e)
        {

        }

        private void reloadButton_Click(object sender, EventArgs e)
        {

        }
    }
}
