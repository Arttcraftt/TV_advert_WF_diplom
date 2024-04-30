
namespace TV_advert_WF
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.blocksWithTitlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advertDataSet = new TV_advert_WF.AdvertDataSet();
            this.blocksWithTitlesTableAdapter = new TV_advert_WF.AdvertDataSetTableAdapters.BlocksWithTitlesTableAdapter();
            this.programsDataGridView = new System.Windows.Forms.DataGridView();
            this.programsWithTitlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advertsDataGridView = new System.Windows.Forms.DataGridView();
            this.advertIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationsecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advertsWithTitlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advertsWithTitlesTableAdapter = new TV_advert_WF.AdvertDataSetTableAdapters.AdvertsWithTitlesTableAdapter();
            this.programsWithTitlesTableAdapter = new TV_advert_WF.AdvertDataSetTableAdapters.ProgramsWithTitlesTableAdapter();
            this.programEditButton = new System.Windows.Forms.Button();
            this.advertEditButton = new System.Windows.Forms.Button();
            this.MainFormEditPanel = new System.Windows.Forms.Panel();
            this.blockEditButton = new System.Windows.Forms.Button();
            this.blocksNameLabel = new System.Windows.Forms.Label();
            this.advertNameLabel = new System.Windows.Forms.Label();
            this.progNameLabel = new System.Windows.Forms.Label();
            this.findingLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ratingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ratingsTableAdapter = new TV_advert_WF.AdvertDataSetTableAdapters.RatingsTableAdapter();
            this.reloadButton = new System.Windows.Forms.Button();
            this.filterProgsCheckBox = new System.Windows.Forms.CheckBox();
            this.blocksWithCostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blocksWithCostTableAdapter = new TV_advert_WF.AdvertDataSetTableAdapters.BlocksWithCostTableAdapter();
            this.blocksWithCostAdvancedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blocksWithCostAdvancedTableAdapter = new TV_advert_WF.AdvertDataSetTableAdapters.BlocksWithCostAdvancedTableAdapter();
            this.blocksDataGridView = new System.Windows.Forms.DataGridView();
            this.filterAdsCheckBox = new System.Windows.Forms.CheckBox();
            this.filterBlocksCheckBox = new System.Windows.Forms.CheckBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.blockIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advertDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdsQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockCostDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minuteCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.blocksWithTitlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsWithTitlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertsWithTitlesBindingSource)).BeginInit();
            this.MainFormEditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocksWithCostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocksWithCostAdvancedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocksDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // blocksWithTitlesBindingSource
            // 
            this.blocksWithTitlesBindingSource.DataMember = "BlocksWithTitles";
            this.blocksWithTitlesBindingSource.DataSource = this.advertDataSet;
            // 
            // advertDataSet
            // 
            this.advertDataSet.DataSetName = "AdvertDataSet";
            this.advertDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // blocksWithTitlesTableAdapter
            // 
            this.blocksWithTitlesTableAdapter.ClearBeforeFill = true;
            // 
            // programsDataGridView
            // 
            this.programsDataGridView.AllowUserToAddRows = false;
            this.programsDataGridView.AllowUserToDeleteRows = false;
            this.programsDataGridView.AllowUserToResizeRows = false;
            this.programsDataGridView.AutoGenerateColumns = false;
            this.programsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.programsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.programsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.programsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.progIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn2,
            this.minuteCostDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            this.programsDataGridView.DataSource = this.programsWithTitlesBindingSource;
            this.programsDataGridView.Location = new System.Drawing.Point(12, 232);
            this.programsDataGridView.Name = "programsDataGridView";
            this.programsDataGridView.ReadOnly = true;
            this.programsDataGridView.Size = new System.Drawing.Size(512, 164);
            this.programsDataGridView.TabIndex = 1;
            // 
            // programsWithTitlesBindingSource
            // 
            this.programsWithTitlesBindingSource.DataMember = "ProgramsWithTitles";
            this.programsWithTitlesBindingSource.DataSource = this.advertDataSet;
            // 
            // advertsDataGridView
            // 
            this.advertsDataGridView.AllowUserToAddRows = false;
            this.advertsDataGridView.AllowUserToDeleteRows = false;
            this.advertsDataGridView.AllowUserToResizeRows = false;
            this.advertsDataGridView.AutoGenerateColumns = false;
            this.advertsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.advertsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.advertsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advertsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.advertIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn1,
            this.durationsecDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn});
            this.advertsDataGridView.DataSource = this.advertsWithTitlesBindingSource;
            this.advertsDataGridView.Location = new System.Drawing.Point(12, 426);
            this.advertsDataGridView.Name = "advertsDataGridView";
            this.advertsDataGridView.ReadOnly = true;
            this.advertsDataGridView.Size = new System.Drawing.Size(512, 164);
            this.advertsDataGridView.TabIndex = 2;
            // 
            // advertIDDataGridViewTextBoxColumn
            // 
            this.advertIDDataGridViewTextBoxColumn.DataPropertyName = "Advert_ID";
            this.advertIDDataGridViewTextBoxColumn.HeaderText = "Advert_ID";
            this.advertIDDataGridViewTextBoxColumn.Name = "advertIDDataGridViewTextBoxColumn";
            this.advertIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.advertIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            this.titleDataGridViewTextBoxColumn1.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn1.Width = 52;
            // 
            // durationsecDataGridViewTextBoxColumn
            // 
            this.durationsecDataGridViewTextBoxColumn.DataPropertyName = "Duration(sec)";
            this.durationsecDataGridViewTextBoxColumn.HeaderText = "Duration(sec)";
            this.durationsecDataGridViewTextBoxColumn.Name = "durationsecDataGridViewTextBoxColumn";
            this.durationsecDataGridViewTextBoxColumn.ReadOnly = true;
            this.durationsecDataGridViewTextBoxColumn.Width = 95;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerDataGridViewTextBoxColumn.Width = 76;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.ReadOnly = true;
            this.ratingDataGridViewTextBoxColumn.Width = 63;
            // 
            // advertsWithTitlesBindingSource
            // 
            this.advertsWithTitlesBindingSource.DataMember = "AdvertsWithTitles";
            this.advertsWithTitlesBindingSource.DataSource = this.advertDataSet;
            // 
            // advertsWithTitlesTableAdapter
            // 
            this.advertsWithTitlesTableAdapter.ClearBeforeFill = true;
            // 
            // programsWithTitlesTableAdapter
            // 
            this.programsWithTitlesTableAdapter.ClearBeforeFill = true;
            // 
            // programEditButton
            // 
            this.programEditButton.BackColor = System.Drawing.Color.Olive;
            this.programEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.programEditButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.programEditButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.programEditButton.Location = new System.Drawing.Point(3, 48);
            this.programEditButton.Name = "programEditButton";
            this.programEditButton.Size = new System.Drawing.Size(170, 39);
            this.programEditButton.TabIndex = 6;
            this.programEditButton.Text = "Редактировать программы";
            this.programEditButton.UseVisualStyleBackColor = false;
            this.programEditButton.Click += new System.EventHandler(this.programEditButton_Click);
            // 
            // advertEditButton
            // 
            this.advertEditButton.BackColor = System.Drawing.Color.Olive;
            this.advertEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.advertEditButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.advertEditButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.advertEditButton.Location = new System.Drawing.Point(3, 93);
            this.advertEditButton.Name = "advertEditButton";
            this.advertEditButton.Size = new System.Drawing.Size(170, 39);
            this.advertEditButton.TabIndex = 7;
            this.advertEditButton.Text = "Редактировать рекламу";
            this.advertEditButton.UseVisualStyleBackColor = false;
            this.advertEditButton.Click += new System.EventHandler(this.advertEditButton_Click);
            // 
            // MainFormEditPanel
            // 
            this.MainFormEditPanel.Controls.Add(this.blockEditButton);
            this.MainFormEditPanel.Controls.Add(this.advertEditButton);
            this.MainFormEditPanel.Controls.Add(this.programEditButton);
            this.MainFormEditPanel.Location = new System.Drawing.Point(580, 453);
            this.MainFormEditPanel.Name = "MainFormEditPanel";
            this.MainFormEditPanel.Size = new System.Drawing.Size(176, 137);
            this.MainFormEditPanel.TabIndex = 9;
            // 
            // blockEditButton
            // 
            this.blockEditButton.BackColor = System.Drawing.Color.Olive;
            this.blockEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.blockEditButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.blockEditButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.blockEditButton.Location = new System.Drawing.Point(3, 3);
            this.blockEditButton.Name = "blockEditButton";
            this.blockEditButton.Size = new System.Drawing.Size(170, 39);
            this.blockEditButton.TabIndex = 8;
            this.blockEditButton.Text = "Редактировать блоки";
            this.blockEditButton.UseVisualStyleBackColor = false;
            this.blockEditButton.Click += new System.EventHandler(this.blockEditButton_Click);
            // 
            // blocksNameLabel
            // 
            this.blocksNameLabel.AutoSize = true;
            this.blocksNameLabel.BackColor = System.Drawing.SystemColors.Window;
            this.blocksNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blocksNameLabel.Location = new System.Drawing.Point(12, 9);
            this.blocksNameLabel.Name = "blocksNameLabel";
            this.blocksNameLabel.Size = new System.Drawing.Size(73, 25);
            this.blocksNameLabel.TabIndex = 10;
            this.blocksNameLabel.Text = "Блоки";
            // 
            // advertNameLabel
            // 
            this.advertNameLabel.AutoSize = true;
            this.advertNameLabel.BackColor = System.Drawing.SystemColors.Window;
            this.advertNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.advertNameLabel.Location = new System.Drawing.Point(12, 398);
            this.advertNameLabel.Name = "advertNameLabel";
            this.advertNameLabel.Size = new System.Drawing.Size(100, 25);
            this.advertNameLabel.TabIndex = 11;
            this.advertNameLabel.Text = "Реклама";
            // 
            // progNameLabel
            // 
            this.progNameLabel.AutoSize = true;
            this.progNameLabel.BackColor = System.Drawing.SystemColors.Window;
            this.progNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.progNameLabel.Location = new System.Drawing.Point(12, 204);
            this.progNameLabel.Name = "progNameLabel";
            this.progNameLabel.Size = new System.Drawing.Size(128, 25);
            this.progNameLabel.TabIndex = 12;
            this.progNameLabel.Text = "Программы";
            // 
            // findingLabel
            // 
            this.findingLabel.AutoSize = true;
            this.findingLabel.BackColor = System.Drawing.SystemColors.Window;
            this.findingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findingLabel.Location = new System.Drawing.Point(3, 0);
            this.findingLabel.Name = "findingLabel";
            this.findingLabel.Size = new System.Drawing.Size(212, 25);
            this.findingLabel.TabIndex = 13;
            this.findingLabel.Text = "Фильтр по рейтингу";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.ratingsBindingSource;
            this.comboBox1.DisplayMember = "Title";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // ratingsBindingSource
            // 
            this.ratingsBindingSource.DataMember = "Ratings";
            this.ratingsBindingSource.DataSource = this.advertDataSet;
            // 
            // ratingsTableAdapter
            // 
            this.ratingsTableAdapter.ClearBeforeFill = true;
            // 
            // reloadButton
            // 
            this.reloadButton.BackColor = System.Drawing.Color.Teal;
            this.reloadButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.reloadButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.reloadButton.Location = new System.Drawing.Point(8, 122);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(207, 42);
            this.reloadButton.TabIndex = 16;
            this.reloadButton.Text = "Обновить форму";
            this.reloadButton.UseVisualStyleBackColor = false;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // filterProgsCheckBox
            // 
            this.filterProgsCheckBox.AutoSize = true;
            this.filterProgsCheckBox.Location = new System.Drawing.Point(84, 76);
            this.filterProgsCheckBox.Name = "filterProgsCheckBox";
            this.filterProgsCheckBox.Size = new System.Drawing.Size(87, 17);
            this.filterProgsCheckBox.TabIndex = 17;
            this.filterProgsCheckBox.Text = "Программы";
            this.filterProgsCheckBox.UseVisualStyleBackColor = true;
            // 
            // blocksWithCostBindingSource
            // 
            this.blocksWithCostBindingSource.DataMember = "BlocksWithCost";
            this.blocksWithCostBindingSource.DataSource = this.advertDataSet;
            // 
            // blocksWithCostTableAdapter
            // 
            this.blocksWithCostTableAdapter.ClearBeforeFill = true;
            // 
            // blocksWithCostAdvancedBindingSource
            // 
            this.blocksWithCostAdvancedBindingSource.DataMember = "BlocksWithCostAdvanced";
            this.blocksWithCostAdvancedBindingSource.DataSource = this.advertDataSet;
            // 
            // blocksWithCostAdvancedTableAdapter
            // 
            this.blocksWithCostAdvancedTableAdapter.ClearBeforeFill = true;
            // 
            // blocksDataGridView
            // 
            this.blocksDataGridView.AllowUserToAddRows = false;
            this.blocksDataGridView.AllowUserToDeleteRows = false;
            this.blocksDataGridView.AllowUserToResizeRows = false;
            this.blocksDataGridView.AutoGenerateColumns = false;
            this.blocksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.blocksDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.blocksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.blocksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.blockIDDataGridViewTextBoxColumn1,
            this.programDataGridViewTextBoxColumn,
            this.advertDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.AdsQuantity,
            this.blockCostDataGridViewTextBoxColumn1});
            this.blocksDataGridView.DataSource = this.blocksWithCostAdvancedBindingSource;
            this.blocksDataGridView.Location = new System.Drawing.Point(12, 37);
            this.blocksDataGridView.MultiSelect = false;
            this.blocksDataGridView.Name = "blocksDataGridView";
            this.blocksDataGridView.ReadOnly = true;
            this.blocksDataGridView.Size = new System.Drawing.Size(776, 164);
            this.blocksDataGridView.TabIndex = 0;
            // 
            // filterAdsCheckBox
            // 
            this.filterAdsCheckBox.AutoSize = true;
            this.filterAdsCheckBox.Location = new System.Drawing.Point(8, 76);
            this.filterAdsCheckBox.Name = "filterAdsCheckBox";
            this.filterAdsCheckBox.Size = new System.Drawing.Size(70, 17);
            this.filterAdsCheckBox.TabIndex = 20;
            this.filterAdsCheckBox.Text = "Рекламу";
            this.filterAdsCheckBox.UseVisualStyleBackColor = true;
            // 
            // filterBlocksCheckBox
            // 
            this.filterBlocksCheckBox.AutoSize = true;
            this.filterBlocksCheckBox.Location = new System.Drawing.Point(8, 99);
            this.filterBlocksCheckBox.Name = "filterBlocksCheckBox";
            this.filterBlocksCheckBox.Size = new System.Drawing.Size(138, 17);
            this.filterBlocksCheckBox.TabIndex = 21;
            this.filterBlocksCheckBox.Text = "Блоки (по программе)";
            this.filterBlocksCheckBox.UseVisualStyleBackColor = true;
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.BackColor = System.Drawing.SystemColors.Window;
            this.filterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterLabel.Location = new System.Drawing.Point(5, 49);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(98, 16);
            this.filterLabel.TabIndex = 22;
            this.filterLabel.Text = "Фильтровать:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.findingLabel);
            this.panel1.Controls.Add(this.filterBlocksCheckBox);
            this.panel1.Controls.Add(this.filterLabel);
            this.panel1.Controls.Add(this.filterAdsCheckBox);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.filterProgsCheckBox);
            this.panel1.Controls.Add(this.reloadButton);
            this.panel1.Location = new System.Drawing.Point(568, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 164);
            this.panel1.TabIndex = 23;
            // 
            // blockIDDataGridViewTextBoxColumn1
            // 
            this.blockIDDataGridViewTextBoxColumn1.DataPropertyName = "Block_ID";
            this.blockIDDataGridViewTextBoxColumn1.HeaderText = "Block_ID";
            this.blockIDDataGridViewTextBoxColumn1.Name = "blockIDDataGridViewTextBoxColumn1";
            this.blockIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.blockIDDataGridViewTextBoxColumn1.Width = 76;
            // 
            // programDataGridViewTextBoxColumn
            // 
            this.programDataGridViewTextBoxColumn.DataPropertyName = "Program";
            this.programDataGridViewTextBoxColumn.HeaderText = "Program";
            this.programDataGridViewTextBoxColumn.Name = "programDataGridViewTextBoxColumn";
            this.programDataGridViewTextBoxColumn.ReadOnly = true;
            this.programDataGridViewTextBoxColumn.Width = 71;
            // 
            // advertDataGridViewTextBoxColumn
            // 
            this.advertDataGridViewTextBoxColumn.DataPropertyName = "Advert";
            this.advertDataGridViewTextBoxColumn.HeaderText = "Advert";
            this.advertDataGridViewTextBoxColumn.Name = "advertDataGridViewTextBoxColumn";
            this.advertDataGridViewTextBoxColumn.ReadOnly = true;
            this.advertDataGridViewTextBoxColumn.Width = 63;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 52;
            // 
            // AdsQuantity
            // 
            this.AdsQuantity.DataPropertyName = "AdsQuantity";
            this.AdsQuantity.HeaderText = "AdsQuantity";
            this.AdsQuantity.Name = "AdsQuantity";
            this.AdsQuantity.ReadOnly = true;
            this.AdsQuantity.Width = 89;
            // 
            // blockCostDataGridViewTextBoxColumn1
            // 
            this.blockCostDataGridViewTextBoxColumn1.DataPropertyName = "BlockCost";
            this.blockCostDataGridViewTextBoxColumn1.HeaderText = "BlockCost";
            this.blockCostDataGridViewTextBoxColumn1.Name = "blockCostDataGridViewTextBoxColumn1";
            this.blockCostDataGridViewTextBoxColumn1.ReadOnly = true;
            this.blockCostDataGridViewTextBoxColumn1.Width = 80;
            // 
            // progIDDataGridViewTextBoxColumn
            // 
            this.progIDDataGridViewTextBoxColumn.DataPropertyName = "Prog_ID";
            this.progIDDataGridViewTextBoxColumn.HeaderText = "Prog_ID";
            this.progIDDataGridViewTextBoxColumn.Name = "progIDDataGridViewTextBoxColumn";
            this.progIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.progIDDataGridViewTextBoxColumn.Width = 71;
            // 
            // titleDataGridViewTextBoxColumn2
            // 
            this.titleDataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn2.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn2.Name = "titleDataGridViewTextBoxColumn2";
            this.titleDataGridViewTextBoxColumn2.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn2.Width = 52;
            // 
            // minuteCostDataGridViewTextBoxColumn
            // 
            this.minuteCostDataGridViewTextBoxColumn.DataPropertyName = "MinuteCost";
            this.minuteCostDataGridViewTextBoxColumn.HeaderText = "MinuteCost";
            this.minuteCostDataGridViewTextBoxColumn.Name = "minuteCostDataGridViewTextBoxColumn";
            this.minuteCostDataGridViewTextBoxColumn.ReadOnly = true;
            this.minuteCostDataGridViewTextBoxColumn.Width = 85;
            // 
            // ratingDataGridViewTextBoxColumn1
            // 
            this.ratingDataGridViewTextBoxColumn1.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn1.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn1.Name = "ratingDataGridViewTextBoxColumn1";
            this.ratingDataGridViewTextBoxColumn1.ReadOnly = true;
            this.ratingDataGridViewTextBoxColumn1.Width = 63;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AdsQuantity";
            this.dataGridViewTextBoxColumn1.HeaderText = "AdsQuantity";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 89;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progNameLabel);
            this.Controls.Add(this.advertNameLabel);
            this.Controls.Add(this.blocksNameLabel);
            this.Controls.Add(this.MainFormEditPanel);
            this.Controls.Add(this.advertsDataGridView);
            this.Controls.Add(this.programsDataGridView);
            this.Controls.Add(this.blocksDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Основная";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.blocksWithTitlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsWithTitlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertsWithTitlesBindingSource)).EndInit();
            this.MainFormEditPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ratingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocksWithCostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocksWithCostAdvancedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocksDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AdvertDataSet advertDataSet;
        private System.Windows.Forms.BindingSource blocksWithTitlesBindingSource;
        private AdvertDataSetTableAdapters.BlocksWithTitlesTableAdapter blocksWithTitlesTableAdapter;
        private System.Windows.Forms.DataGridView programsDataGridView;
        private System.Windows.Forms.DataGridView advertsDataGridView;
        private System.Windows.Forms.BindingSource advertsWithTitlesBindingSource;
        private AdvertDataSetTableAdapters.AdvertsWithTitlesTableAdapter advertsWithTitlesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn advertIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationsecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource programsWithTitlesBindingSource;
        private AdvertDataSetTableAdapters.ProgramsWithTitlesTableAdapter programsWithTitlesTableAdapter;
        private System.Windows.Forms.Button programEditButton;
        private System.Windows.Forms.Button advertEditButton;
        private System.Windows.Forms.Panel MainFormEditPanel;
        private System.Windows.Forms.Label blocksNameLabel;
        private System.Windows.Forms.Label advertNameLabel;
        private System.Windows.Forms.Label progNameLabel;
        private System.Windows.Forms.Button blockEditButton;
        private System.Windows.Forms.Label findingLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource ratingsBindingSource;
        private AdvertDataSetTableAdapters.RatingsTableAdapter ratingsTableAdapter;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.CheckBox filterProgsCheckBox;
        private System.Windows.Forms.BindingSource blocksWithCostBindingSource;
        private AdvertDataSetTableAdapters.BlocksWithCostTableAdapter blocksWithCostTableAdapter;
        private System.Windows.Forms.BindingSource blocksWithCostAdvancedBindingSource;
        private AdvertDataSetTableAdapters.BlocksWithCostAdvancedTableAdapter blocksWithCostAdvancedTableAdapter;
        private System.Windows.Forms.DataGridView blocksDataGridView;
        private System.Windows.Forms.CheckBox filterAdsCheckBox;
        private System.Windows.Forms.CheckBox filterBlocksCheckBox;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn programDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn advertDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdsQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockCostDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn progIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn minuteCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

