using System;
using System.Windows.Forms;
using TV_advert_WF.Properties;

namespace TV_advert_WF
{
    public partial class MainForm : Form
    {
        DatabaseScaner databaseScaner;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertDataSet.WorkersWithTitles". При необходимости она может быть перемещена или удалена.
            this.workersWithTitlesTableAdapter.Fill(this.advertDataSet.WorkersWithTitles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.advertDataSet.Workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertDataSet.Сustomers". При необходимости она может быть перемещена или удалена.
            this.сustomersTableAdapter.Fill(this.advertDataSet.Сustomers);
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
            databaseScaner = new DatabaseScaner(Settings.Default.AdvertConnStr);
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {

        }

        private void addBlockButton_Click(object sender, EventArgs e)
        {
            editAddBlockPanel.Visible = true;
        }

        private void progChoiseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            adsQuantityLabel.Visible = true;
            adsQuantityComboBoxBlocks.Visible = true;
            adsQuantityComboBoxBlocks.Text = Convert.ToString(databaseScaner.ScalarAdsQuantity());
        }

        private void deleteBlockButton_Click(object sender, EventArgs e)
        {

        }

        private void changeBlockButton_Click(object sender, EventArgs e)
        {

        }

        private void blocksCancelPanelButton_Click(object sender, EventArgs e)
        {

        }

        private void blocksOKPanelButton_Click(object sender, EventArgs e)
        {

        }

        private void addProgButton_Click(object sender, EventArgs e)
        {
            editAddProgramPanel.Visible = true;
        }

        private void deleteProgButton_Click(object sender, EventArgs e)
        {

        }

        private void changeProgButton_Click(object sender, EventArgs e)
        {

        }

        private void progsCancelPanelButton_Click(object sender, EventArgs e)
        {

        }

        private void progsOKPanelButton_Click(object sender, EventArgs e)
        {

        }

        private void addAdvertButton_Click(object sender, EventArgs e)
        {
            editAddAdvertPanel.Visible = true;
        }

        private void deleteAdvertButton_Click(object sender, EventArgs e)
        {

        }

        private void changeAdvertButton_Click(object sender, EventArgs e)
        {

        }

        private void advertCancelPanelButton_Click(object sender, EventArgs e)
        {

        }

        private void advertOKPanelButton_Click(object sender, EventArgs e)
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
