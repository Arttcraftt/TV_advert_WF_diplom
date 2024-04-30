
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
            this.blocksDataGridView = new System.Windows.Forms.DataGridView();
            this.advertDataSet = new TV_advert_WF.AdvertDataSet();
            this.blocksWithTitlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blocksWithTitlesTableAdapter = new TV_advert_WF.AdvertDataSetTableAdapters.BlocksWithTitlesTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advertDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programsDataGridView = new System.Windows.Forms.DataGridView();
            this.advertsDataGridView = new System.Windows.Forms.DataGridView();
            this.advertsWithTitlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advertsWithTitlesTableAdapter = new TV_advert_WF.AdvertDataSetTableAdapters.AdvertsWithTitlesTableAdapter();
            this.advertIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationsecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programsWithTitlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programsWithTitlesTableAdapter = new TV_advert_WF.AdvertDataSetTableAdapters.ProgramsWithTitlesTableAdapter();
            this.progIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minuteCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBlockButton = new System.Windows.Forms.Button();
            this.deleteBlockButton = new System.Windows.Forms.Button();
            this.changeBlockButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.blocksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocksWithTitlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertsWithTitlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsWithTitlesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // blocksDataGridView
            // 
            this.blocksDataGridView.AllowUserToAddRows = false;
            this.blocksDataGridView.AllowUserToDeleteRows = false;
            this.blocksDataGridView.AllowUserToResizeRows = false;
            this.blocksDataGridView.AutoGenerateColumns = false;
            this.blocksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.blocksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.blocksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.programDataGridViewTextBoxColumn,
            this.advertDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn});
            this.blocksDataGridView.DataSource = this.blocksWithTitlesBindingSource;
            this.blocksDataGridView.Location = new System.Drawing.Point(12, 12);
            this.blocksDataGridView.MultiSelect = false;
            this.blocksDataGridView.Name = "blocksDataGridView";
            this.blocksDataGridView.ReadOnly = true;
            this.blocksDataGridView.Size = new System.Drawing.Size(457, 164);
            this.blocksDataGridView.TabIndex = 0;
            // 
            // advertDataSet
            // 
            this.advertDataSet.DataSetName = "AdvertDataSet";
            this.advertDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // blocksWithTitlesBindingSource
            // 
            this.blocksWithTitlesBindingSource.DataMember = "BlocksWithTitles";
            this.blocksWithTitlesBindingSource.DataSource = this.advertDataSet;
            // 
            // blocksWithTitlesTableAdapter
            // 
            this.blocksWithTitlesTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 43;
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
            // programsDataGridView
            // 
            this.programsDataGridView.AllowUserToAddRows = false;
            this.programsDataGridView.AllowUserToDeleteRows = false;
            this.programsDataGridView.AllowUserToResizeRows = false;
            this.programsDataGridView.AutoGenerateColumns = false;
            this.programsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.programsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.programsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.progIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn2,
            this.minuteCostDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn1});
            this.programsDataGridView.DataSource = this.programsWithTitlesBindingSource;
            this.programsDataGridView.Location = new System.Drawing.Point(12, 223);
            this.programsDataGridView.Name = "programsDataGridView";
            this.programsDataGridView.ReadOnly = true;
            this.programsDataGridView.Size = new System.Drawing.Size(457, 162);
            this.programsDataGridView.TabIndex = 1;
            // 
            // advertsDataGridView
            // 
            this.advertsDataGridView.AllowUserToAddRows = false;
            this.advertsDataGridView.AllowUserToDeleteRows = false;
            this.advertsDataGridView.AllowUserToResizeRows = false;
            this.advertsDataGridView.AutoGenerateColumns = false;
            this.advertsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.advertsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advertsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.advertIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn1,
            this.durationsecDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn});
            this.advertsDataGridView.DataSource = this.advertsWithTitlesBindingSource;
            this.advertsDataGridView.Location = new System.Drawing.Point(12, 391);
            this.advertsDataGridView.Name = "advertsDataGridView";
            this.advertsDataGridView.ReadOnly = true;
            this.advertsDataGridView.Size = new System.Drawing.Size(555, 162);
            this.advertsDataGridView.TabIndex = 2;
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
            // programsWithTitlesBindingSource
            // 
            this.programsWithTitlesBindingSource.DataMember = "ProgramsWithTitles";
            this.programsWithTitlesBindingSource.DataSource = this.advertDataSet;
            // 
            // programsWithTitlesTableAdapter
            // 
            this.programsWithTitlesTableAdapter.ClearBeforeFill = true;
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
            // addBlockButton
            // 
            this.addBlockButton.Location = new System.Drawing.Point(475, 12);
            this.addBlockButton.Name = "addBlockButton";
            this.addBlockButton.Size = new System.Drawing.Size(139, 41);
            this.addBlockButton.TabIndex = 3;
            this.addBlockButton.Text = "Добавить блок";
            this.addBlockButton.UseVisualStyleBackColor = true;
            // 
            // deleteBlockButton
            // 
            this.deleteBlockButton.Location = new System.Drawing.Point(475, 59);
            this.deleteBlockButton.Name = "deleteBlockButton";
            this.deleteBlockButton.Size = new System.Drawing.Size(139, 41);
            this.deleteBlockButton.TabIndex = 4;
            this.deleteBlockButton.Text = "Удалить Блок";
            this.deleteBlockButton.UseVisualStyleBackColor = true;
            // 
            // changeBlockButton
            // 
            this.changeBlockButton.Location = new System.Drawing.Point(475, 106);
            this.changeBlockButton.Name = "changeBlockButton";
            this.changeBlockButton.Size = new System.Drawing.Size(139, 41);
            this.changeBlockButton.TabIndex = 5;
            this.changeBlockButton.Text = "Изменить выбранный блок";
            this.changeBlockButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.changeBlockButton);
            this.Controls.Add(this.deleteBlockButton);
            this.Controls.Add(this.addBlockButton);
            this.Controls.Add(this.advertsDataGridView);
            this.Controls.Add(this.programsDataGridView);
            this.Controls.Add(this.blocksDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Основная";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.blocksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocksWithTitlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertsWithTitlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsWithTitlesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView blocksDataGridView;
        private AdvertDataSet advertDataSet;
        private System.Windows.Forms.BindingSource blocksWithTitlesBindingSource;
        private AdvertDataSetTableAdapters.BlocksWithTitlesTableAdapter blocksWithTitlesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn advertDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn progIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn minuteCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button addBlockButton;
        private System.Windows.Forms.Button deleteBlockButton;
        private System.Windows.Forms.Button changeBlockButton;
    }
}

