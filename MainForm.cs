using System;
using System.Data;
using System.Windows.Forms;

namespace TV_advert_WF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(int Role) //конструктор формы с зависимостью от роли
        {
            InitializeComponent();
            switch (Role)
            {
                case 2:
                    mainTabControl.TabPages.RemoveAt(4);
                    break;
                case 3:
                    for (int i = 4; i >= 1; i--)
                        mainTabControl.TabPages.RemoveAt(i);
                    break;
                default: break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e) //загрузка данных в таблицы
        {
            this.programsTableAdapter.Fill(this.advertDataSet.Programs);
            this.workerRolesTableAdapter.Fill(this.advertDataSet.WorkerRoles);
            this.workersWithTitlesTableAdapter.Fill(this.advertDataSet.WorkersWithTitles);
            this.workersTableAdapter.Fill(this.advertDataSet.Workers);
            this.сustomersTableAdapter.Fill(this.advertDataSet.Сustomers);
            this.blocksWithCostAdvancedTableAdapter.Fill(this.advertDataSet.BlocksWithCostAdvanced);
            this.blocksWithCostTableAdapter.Fill(this.advertDataSet.BlocksWithCost);
            this.ratingsTableAdapter.Fill(this.advertDataSet.Ratings);
            this.programsWithTitlesTableAdapter.Fill(this.advertDataSet.ProgramsWithTitles);
            this.advertsWithTitlesTableAdapter.Fill(this.advertDataSet.AdvertsWithTitles);
            this.blocksWithTitlesTableAdapter.Fill(this.advertDataSet.BlocksWithTitles);
        }

        private void reloadButton_Click(object sender, EventArgs e) //загрузка данных в таблицы после фильтрации
        {
            string selectedRatingText = viewRatingsComboBox.Text;
            if (filterAdsCheckBox.Checked == true)
                this.programsWithTitlesTableAdapter.FillBySorted(this.advertDataSet.ProgramsWithTitles, selectedRatingText);
            else this.programsWithTitlesTableAdapter.Fill(this.advertDataSet.ProgramsWithTitles);
            if (filterProgsCheckBox.Checked == true)
                this.advertsWithTitlesTableAdapter.FillBySorted(this.advertDataSet.AdvertsWithTitles, selectedRatingText);
            else this.advertsWithTitlesTableAdapter.Fill(this.advertDataSet.AdvertsWithTitles);
        }

        //методы для работы с таблицей "блоки"
        private void addBlockButton_Click(object sender, EventArgs e) //открытие панели для добавления в таблицу "блоки"
        {
            blockIDLabelBlocks.Text = "Новый";
            BlocksPanelClear();
            editAddBlockPanel.Visible = true;
        }

        private void deleteBlockButton_Click(object sender, EventArgs e) //удаление из таблицы "блоки" по выбранному индексу
        {
            int ID = int.Parse(blocksEditDataGridView[0, blocksEditDataGridView.CurrentRow.Index].Value.ToString());
            if (MessageBox.Show($"Вы уверены удалить блок {ID}?", "Удаление блока", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                blocksTableAdapter1.DeleteQuery(ID);
                this.blocksWithCostAdvancedTableAdapter.Fill(this.advertDataSet.BlocksWithCostAdvanced);
            }
        }

        private void changeBlockButton_Click(object sender, EventArgs e) //изменение данных из таблицы "блоки" по выбранному индексу
        {
            int ID = int.Parse(blocksEditDataGridView[0, blocksEditDataGridView.CurrentRow.Index].Value.ToString());
            DataTable bufferTab = new DataTable();
            bufferTab = blocksTableAdapter1.GetDataByID(ID);
            blockIDLabelBlocks.Text = bufferTab.Rows[0][0].ToString();
            progChoiseComboBoxBlocks.SelectedIndex = int.Parse(bufferTab.Rows[0][1].ToString()) - 1;
            advertChoiseComboBoxBlocks.SelectedIndex = int.Parse((bufferTab.Rows[0][2].ToString())) - 1;
            titleProgTextBoxBlocks.Text = bufferTab.Rows[0][3].ToString();
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
            adsQuantityComboBoxBlocks.Text = bufferTab.Rows[0][4].ToString();
            bufferTab.Reset();
            editAddBlockPanel.Visible = true;
        }

        private void blocksCancelPanelButton_Click(object sender, EventArgs e) //отмена манипуляций над данными в таблице "блоки"
        {
            if (MessageBox.Show($"Отменить создание/изменение блока?\n(поля будут очищены)", "Отмена создания/изменения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            blockIDLabelBlocks.Text = "Новый";
            BlocksPanelClear();
            editAddBlockPanel.Visible = false;
        }

        private void blocksOKPanelButton_Click(object sender, EventArgs e) //сохранение данных в таблицу "блоки"
        {
            if (blockIDLabelBlocks.Text == "Новый")
            {
                blocksTableAdapter1.InsertQuery(progChoiseComboBoxBlocks.SelectedIndex + 1, advertChoiseComboBoxBlocks.SelectedIndex + 1, titleProgTextBoxBlocks.Text, int.Parse(adsQuantityComboBoxBlocks.Text));
            }
            else
            {
                blocksTableAdapter1.UpdateQuery(progChoiseComboBoxBlocks.SelectedIndex + 1, advertChoiseComboBoxBlocks.SelectedIndex + 1, titleProgTextBoxBlocks.Text, int.Parse(adsQuantityComboBoxBlocks.Text), int.Parse(blockIDLabelBlocks.Text));
                blockIDLabelBlocks.Text = "Новый";
            }
            BlocksPanelClear();
            editAddBlockPanel.Visible = false;
            this.blocksWithCostAdvancedTableAdapter.Fill(this.advertDataSet.BlocksWithCostAdvanced);
        }

        //методы для работы с таблицей "программы"
        private void addProgButton_Click(object sender, EventArgs e) //открытие панели для добавления в таблицу "программы"
        {
            progIDLabelProgs.Text = "Новый";
            ProgsPanelClear();
            editAddProgramPanel.Visible = true;
        }

        private void deleteProgButton_Click(object sender, EventArgs e) //удаление из таблицы "программы" по выбранному индексу
        {
            int ID = int.Parse(programsEditDataGridView[0, programsEditDataGridView.CurrentRow.Index].Value.ToString());
            if (MessageBox.Show($"Вы уверены удалить программу {ID}?", "Удаление программы", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                programsTableAdapter.DeleteQuery(ID);
                this.programsWithTitlesTableAdapter.Fill(this.advertDataSet.ProgramsWithTitles);
            }
        }

        private void changeProgButton_Click(object sender, EventArgs e) //изменение данных из таблицы "программы" по выбранному индексу
        {
            int ID = int.Parse(programsEditDataGridView[0, programsEditDataGridView.CurrentRow.Index].Value.ToString());
            DataTable bufferTab = new DataTable();
            bufferTab = programsTableAdapter.GetDataByID(ID);
            progIDLabelProgs.Text = bufferTab.Rows[0][0].ToString();
            minuteCostTextBoxProgs.Text = bufferTab.Rows[0][1].ToString();
            ratingProgComboBoxProgs.SelectedIndex = int.Parse(bufferTab.Rows[0][2].ToString()) - 1;
            adsQuantityTextBoxProgs.Text = bufferTab.Rows[0][3].ToString();
            bufferTab.Reset();
            editAddProgramPanel.Visible = true;
        }

        private void progsCancelPanelButton_Click(object sender, EventArgs e) //отмена манипуляций над данными в таблице "программы"
        {
            if (MessageBox.Show($"Отменить создание/изменение программы?\n(поля будут очищены)", "Отмена создания/изменения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            progIDLabelProgs.Text = "Новый";
            ProgsPanelClear();
            editAddProgramPanel.Visible = false;
        }

        private void progsOKPanelButton_Click(object sender, EventArgs e) //сохранение данных в таблицу "программы"
        {
            if (progIDLabelProgs.Text == "Новый")
            {
                programsTableAdapter.InsertQuery(titleProgTextBoxProgs.Text, decimal.Parse(minuteCostTextBoxProgs.Text),
                    ratingProgComboBoxProgs.SelectedIndex + 1, int.Parse(adsQuantityTextBoxProgs.Text));
            }
            else
            {
                programsTableAdapter.UpdateQuery(titleProgTextBoxProgs.Text, decimal.Parse(minuteCostTextBoxProgs.Text), ratingProgComboBoxProgs.SelectedIndex + 1, int.Parse(adsQuantityTextBoxProgs.Text), int.Parse(progIDLabelProgs.Text));
                progIDLabelProgs.Text = "Новый";
            }
            ProgsPanelClear();
            editAddBlockPanel.Visible = false;
            this.programsWithTitlesTableAdapter.Fill(this.advertDataSet.ProgramsWithTitles);
        }

        //методы для работы с таблицей "реклама"
        private void addAdvertButton_Click(object sender, EventArgs e) //открытие панели для добавления в таблицу "реклама" с проверкой открытости панели для добаления в тблицу "заказчики"
        {
            if (editAddCustomerPanel.Visible == true) 
            {
                if (MessageBox.Show($"Закрыть панель редактирования заказчиков? \n(поля будут очищены)",
                    "У вас открыта другая панель редактирования",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    editAddCustomerPanel.Visible = false;
                else return;
            }
            else
            {
                adIDLabelAds.Text = "Новый";
                AdvertPanelClear();
                editAddAdvertPanel.Visible = true;
            }
        }

        private void deleteAdvertButton_Click(object sender, EventArgs e) //удаление из таблицы "реклама" по выбранному индексу
        {
            int ID = int.Parse(advertsEditDataGridView[0, advertsEditDataGridView.CurrentRow.Index].Value.ToString());
            if (MessageBox.Show($"Вы уверены удалить рекламу {ID}?", "Удаление рекламы", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                сustomersTableAdapter.DeleteQuery(ID);
                this.сustomersTableAdapter.Fill(this.advertDataSet.Сustomers);
            }
        }

        private void changeAdvertButton_Click(object sender, EventArgs e) //изменение данных из таблицы "реклама" по выбранному индексу
        {
            int ID = int.Parse(advertsEditDataGridView[0, advertsEditDataGridView.CurrentRow.Index].Value.ToString());
            DataTable bufferTab = new DataTable();
            bufferTab = advertsTableAdapter1.GetDataByID(ID);
            adIDLabelAds.Text = bufferTab.Rows[0][0].ToString();
            titleAdTextBoxAds.Text = bufferTab.Rows[0][1].ToString();
            durationAdTextBoxAds.Text = bufferTab.Rows[0][2].ToString();
            custChoiseComboBoxAds.SelectedIndex = int.Parse(bufferTab.Rows[0][3].ToString()) - 1;
            ratingChoiseComboBoxAds.SelectedIndex = int.Parse(bufferTab.Rows[0][4].ToString()) - 1;
            bufferTab.Reset();
            editAddAdvertPanel.Visible = true;
        }

        private void advertCancelPanelButton_Click(object sender, EventArgs e) //отмена манипуляций над данными в таблице "реклама"
        {
            if (MessageBox.Show($"Отменить создание/изменение рекламы?\n(поля будут очищены)", "Отмена создания/изменения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            adIDLabelAds.Text = "Новый";
            AdvertPanelClear();
            editAddAdvertPanel.Visible = false;
        }

        private void advertOKPanelButton_Click(object sender, EventArgs e) //сохранение данных в таблицу "реклама"
        {
            if (adIDLabelAds.Text == "Новый")
            {
                advertsTableAdapter1.InsertQuery(titleAdTextBoxAds.Text, int.Parse(durationAdTextBoxAds.Text),
                    ratingProgComboBoxProgs.SelectedIndex + 1, ratingChoiseComboBoxAds.SelectedIndex + 1);
            }
            else
            {
                advertsTableAdapter1.UpdateQuery(titleAdTextBoxAds.Text, int.Parse(durationAdTextBoxAds.Text),
                    ratingProgComboBoxProgs.SelectedIndex + 1, ratingChoiseComboBoxAds.SelectedIndex + 1, int.Parse(adIDLabelAds.Text));
                adIDLabelAds.Text = "Новый";
            }
            AdvertPanelClear();
            editAddAdvertPanel.Visible = false;
            this.advertsWithTitlesTableAdapter.Fill(this.advertDataSet.AdvertsWithTitles);
        }

        //методы для работы с таблицей "заказчики"
        private void addCustomButton_Click(object sender, EventArgs e) //открытие панели для добавления в таблицу "заказчики" с проверкой открытости панели для добаления в тблицу "реклама"
        {
            if (editAddAdvertPanel.Visible == true)
            {
                if (MessageBox.Show($"Закрыть панель редактирования рекламы? \n(поля будут очищены)", "У вас открыта другая панель редактирования", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    editAddAdvertPanel.Visible = false;

                else return;
            }
            else
            {
                custIDLabelAds.Text = "Новый";
                CustPanelClear();
                editAddCustomerPanel.Visible = true;
            }
        }

        private void deleteCustomButton_Click(object sender, EventArgs e) //удаление из таблицы "заказчики" по выбранному индексу
        {
            int ID = int.Parse(customersEditDataGridView[0, customersEditDataGridView.CurrentRow.Index].Value.ToString());
            if (MessageBox.Show($"Вы уверены удалить заказчика {ID}?", "Удаление заказчика", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                advertsTableAdapter1.DeleteQuery(ID);
                this.advertsWithTitlesTableAdapter.Fill(this.advertDataSet.AdvertsWithTitles);
            }
        }

        private void changeCustomButton_Click(object sender, EventArgs e) //изменение данных из таблицы "заказчики" по выбранному индексу
        {
            int ID = int.Parse(customersEditDataGridView[0, customersEditDataGridView.CurrentRow.Index].Value.ToString());
            DataTable bufferTab = new DataTable();
            bufferTab = сustomersTableAdapter.GetDataByID(ID);
            custIDLabelAds.Text = bufferTab.Rows[0][0].ToString();
            titleCustTextBoxAds.Text = bufferTab.Rows[0][1].ToString();
            bankReqTextBoxAds.Text = bufferTab.Rows[0][2].ToString();
            telephoneCustTextBoxAds.Text = bufferTab.Rows[0][3].ToString();
            bufferTab.Reset();
            editAddCustomerPanel.Visible = true;
        }

        private void customerCancelPanelButton_Click(object sender, EventArgs e) //отмена манипуляций над данными в таблице "заказчики"
        {

            if (MessageBox.Show($"Отменить создание/изменение заказчика?\n(поля будут очищены)", "Отмена создания/заказчика", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            custIDLabelAds.Text = "Новый";
            CustPanelClear();
            editAddCustomerPanel.Visible = false;
        }

        private void customerOKPanelButton_Click(object sender, EventArgs e) //сохранение данных в таблицу "заказчики"
        {
            if (custIDLabelAds.Text == "Новый")
            {
                сustomersTableAdapter.InsertQuery(titleCustTextBoxAds.Text, bankReqTextBoxAds.Text, telephoneCustTextBoxAds.Text);
            }
            else
            {
                сustomersTableAdapter.UpdateQuery(titleCustTextBoxAds.Text, bankReqTextBoxAds.Text, telephoneCustTextBoxAds.Text, int.Parse(custIDLabelAds.Text));
                custIDLabelAds.Text = "Новый";
            }
            CustPanelClear();
            editAddAdvertPanel.Visible = false;
            this.advertsWithTitlesTableAdapter.Fill(this.advertDataSet.AdvertsWithTitles);
        }

        //методы для работы с таблицей "работники"
        private void addWorkerButton_Click(object sender, EventArgs e) //открытие панели для добавления в таблицу "работники"
        {
            workerIDLabelWorkers.Text = "Новый";
            WorkerPanelClear();
            editAddWorkerPanel.Visible = true;
        }

        private void deleteWorkerButton_Click(object sender, EventArgs e) //удаление из таблицы "работники" по выбранному индексу
        {
            int ID = int.Parse(workersEditDataGridView[0, workersEditDataGridView.CurrentRow.Index].Value.ToString());
            if (MessageBox.Show($"Вы уверены удалить работника {ID}?", "Удаление работника", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                workersTableAdapter.DeleteQuery(ID);
                this.workersWithTitlesTableAdapter.Fill(this.advertDataSet.WorkersWithTitles);
            }
        }

        private void changeWorkerButton_Click(object sender, EventArgs e) //изменение данных из таблицы "работники" по выбранному индексу
        {
            int ID = int.Parse(workersEditDataGridView[0, workersEditDataGridView.CurrentRow.Index].Value.ToString());
            DataTable bufferTab = new DataTable();
            bufferTab = workersTableAdapter.GetDataByID(ID);
            workerIDLabelWorkers.Text = bufferTab.Rows[0][0].ToString();
            loginWorkerTextBoxWorkers.Text = bufferTab.Rows[0][1].ToString();
            passwordWorkerTextBoxWorkers.Text = bufferTab.Rows[0][2].ToString();
            roleWorkerChoiseComboBoxWorkers.SelectedIndex = int.Parse(bufferTab.Rows[0][3].ToString()) - 1;
            bufferTab.Reset();
            editAddWorkerPanel.Visible = true;
        }

        private void workerCancelPanelButton_Click(object sender, EventArgs e) //отмена манипуляций над данными в таблице "работники"
        {
            if (MessageBox.Show($"Отменить создание/изменение работника?\n(поля будут очищены)", "Отмена создания/работника", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            workerIDLabelWorkers.Text = "Новый";
            WorkerPanelClear();
            editAddWorkerPanel.Visible = false;
        }

        private void workerOKPanelButton_Click(object sender, EventArgs e) //сохранение данных в таблицу "работники"
        {
            if (workerIDLabelWorkers.Text == "Новый")
            {
                workersTableAdapter.InsertQuery(workerIDLabelWorkers.Text, loginWorkerTextBoxWorkers.Text, passwordWorkerTextBoxWorkers.Text, roleWorkerChoiseComboBoxWorkers.SelectedIndex);
            }
            else
            {
                workersTableAdapter.UpdateQuery(workerIDLabelWorkers.Text, loginWorkerTextBoxWorkers.Text, passwordWorkerTextBoxWorkers.Text, roleWorkerChoiseComboBoxWorkers.SelectedIndex + 1, int.Parse(workerIDLabelWorkers.Text));
                workerIDLabelWorkers.Text = "Новый";
            }
            WorkerPanelClear();
            editAddWorkerPanel.Visible = false;
            this.workersWithTitlesTableAdapter.Fill(this.advertDataSet.WorkersWithTitles);
        }

        private void progChoiseComboBoxBlocks_SelectedValueChanged(object sender, EventArgs e) //заполниние ComboBox-a выбора количества рекламы в блоке значениями от 1 до максимального количества рекламы в программе
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

        //методы очистки элементов панелей
        void BlocksPanelClear() //очистка панели блоков
        {
            editAddBlockPanel.Visible = false;
            progChoiseComboBoxBlocks.Text = string.Empty;
            advertChoiseComboBoxBlocks.Text = string.Empty;
            titleProgTextBoxBlocks.Text = string.Empty;
            adsQuantityComboBoxBlocks.Items.Clear();
            adsQuantityComboBoxBlocks.Text = string.Empty;
            adsQuantityLabel.Visible = false;
            adsQuantityComboBoxBlocks.Visible = false;
        }

        void ProgsPanelClear() //очистка панели программ
        {
            titleProgTextBoxProgs.Text = string.Empty;
            minuteCostTextBoxProgs.Text = string.Empty;
            ratingProgComboBoxProgs.Text = string.Empty;
            adsQuantityTextBoxProgs.Text = string.Empty;
        }

        void AdvertPanelClear() //очистка панели рекламы
        {
            titleAdTextBoxAds.Text = string.Empty;
            durationAdTextBoxAds.Text = string.Empty;
            custChoiseComboBoxAds.Text = string.Empty;
            ratingChoiseComboBoxAds.Text = string.Empty;
        }

        void CustPanelClear() //очистка панели заказчиков
        {
            titleCustTextBoxAds.Text = string.Empty;
            bankReqTextBoxAds.Text = string.Empty;
            telephoneCustTextBoxAds.Text = string.Empty;
        }

        void WorkerPanelClear() //очистка панели работников
        {
            titleWorkerTextBoxWorkers.Text = string.Empty;
            loginWorkerTextBoxWorkers.Text = string.Empty;
            passwordWorkerTextBoxWorkers.Text = string.Empty;
            roleWorkerChoiseComboBoxWorkers.Text = string.Empty;
        }
    }
}