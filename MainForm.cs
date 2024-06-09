using System;
using System.Windows.Forms;
using TV_advert_WF.Properties;

namespace TV_advert_WF
{
    public partial class MainForm : Form
    {
        //DatabaseScaner databaseScaner;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertDataSet.Programs". При необходимости она может быть перемещена или удалена.
            this.programsTableAdapter.Fill(this.advertDataSet.Programs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "advertDataSet.WorkerRoles". При необходимости она может быть перемещена или удалена.
            this.workerRolesTableAdapter.Fill(this.advertDataSet.WorkerRoles);
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
            //databaseScaner = new DatabaseScaner(Settings.Default.AdvertConnStr);
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            string selectedRatingText = viewRatingsComboBox.Text;
            if (filterAdsCheckBox.Checked == true)
                this.programsWithTitlesTableAdapter.FillBySorted(this.advertDataSet.ProgramsWithTitles, selectedRatingText);
            else this.programsWithTitlesTableAdapter.Fill(this.advertDataSet.ProgramsWithTitles);
            if (filterProgsCheckBox.Checked == true)
                this.advertsWithTitlesTableAdapter.FillBySorted(this.advertDataSet.AdvertsWithTitles, selectedRatingText);
            else this.advertsWithTitlesTableAdapter.Fill(this.advertDataSet.AdvertsWithTitles);
        }

        private void addBlockButton_Click(object sender, EventArgs e)
        {
            editAddBlockPanel.Visible = true;  
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
            if (editAddCustomerPanel.Visible == true) return;
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
            editAddAdvertPanel.Visible = false;
        }

        private void advertOKPanelButton_Click(object sender, EventArgs e)
        {

        }

        private void addCustomButton_Click(object sender, EventArgs e)
        {
            if (editAddAdvertPanel.Visible == true) return;
            editAddCustomerPanel.Visible = true;
        }

        private void deleteCustomButton_Click(object sender, EventArgs e)
        {

        }

        private void changeCustomButton_Click(object sender, EventArgs e)
        {

        }

        private void customerCancelPanelButton_Click(object sender, EventArgs e)
        {
            editAddCustomerPanel.Visible = false;
        }

        private void addWorkerButton_Click(object sender, EventArgs e)
        {
            editAddWorkerPanel.Visible = true;
        }

        private void deleteWorkerButton_Click(object sender, EventArgs e)
        {

        }

        private void changeWorkerButton_Click(object sender, EventArgs e)
        {

        }

        private void progChoiseComboBoxBlocks_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.progChoiseComboBoxBlocks.SelectedIndex == -1)
                return;
            adsQuantityComboBoxBlocks.Items.Clear();
            adsQuantityComboBoxBlocks.Text = string.Empty;
            int quantity = (int)this.programsTableAdapter.ScalarQueryQuantity(this.progChoiseComboBoxBlocks.SelectedIndex + 1);
            string[] quantities = new string[quantity];
            for (int i = 1; i <= quantity; i++)
            {
                quantities[i - 1] = i.ToString();
            }
            adsQuantityLabel.Visible = true;
            adsQuantityComboBoxBlocks.Visible = true;
            adsQuantityComboBoxBlocks.Items.AddRange(quantities);
        }
    }
}
