
namespace TV_advert_WF
{
    partial class AdvertEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.advertDataSet = new TV_advert_WF.AdvertDataSet();
            this.advertsWithTitlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advertsWithTitlesTableAdapter = new TV_advert_WF.AdvertDataSetTableAdapters.AdvertsWithTitlesTableAdapter();
            this.сustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сustomersTableAdapter = new TV_advert_WF.AdvertDataSetTableAdapters.СustomersTableAdapter();
            this.adsDataGridView = new System.Windows.Forms.DataGridView();
            this.advertIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationsecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customsDataGridView = new System.Windows.Forms.DataGridView();
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankrequisitesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advertNameLabel = new System.Windows.Forms.Label();
            this.customersLabel = new System.Windows.Forms.Label();
            this.adsEditPanel = new System.Windows.Forms.Panel();
            this.addAdvertButton = new System.Windows.Forms.Button();
            this.changeAdvertButton = new System.Windows.Forms.Button();
            this.deleteAdvertButton = new System.Windows.Forms.Button();
            this.customsEditPanel = new System.Windows.Forms.Panel();
            this.addCustomButton = new System.Windows.Forms.Button();
            this.changeCustomButton = new System.Windows.Forms.Button();
            this.deleteCustomButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.advertDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertsWithTitlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customsDataGridView)).BeginInit();
            this.adsEditPanel.SuspendLayout();
            this.customsEditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // advertDataSet
            // 
            this.advertDataSet.DataSetName = "AdvertDataSet";
            this.advertDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // сustomersBindingSource
            // 
            this.сustomersBindingSource.DataMember = "Сustomers";
            this.сustomersBindingSource.DataSource = this.advertDataSet;
            // 
            // сustomersTableAdapter
            // 
            this.сustomersTableAdapter.ClearBeforeFill = true;
            // 
            // adsDataGridView
            // 
            this.adsDataGridView.AllowUserToAddRows = false;
            this.adsDataGridView.AllowUserToDeleteRows = false;
            this.adsDataGridView.AllowUserToResizeRows = false;
            this.adsDataGridView.AutoGenerateColumns = false;
            this.adsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.adsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.advertIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.durationsecDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn});
            this.adsDataGridView.DataSource = this.advertsWithTitlesBindingSource;
            this.adsDataGridView.Location = new System.Drawing.Point(12, 37);
            this.adsDataGridView.MultiSelect = false;
            this.adsDataGridView.Name = "adsDataGridView";
            this.adsDataGridView.ReadOnly = true;
            this.adsDataGridView.Size = new System.Drawing.Size(591, 164);
            this.adsDataGridView.TabIndex = 2;
            // 
            // advertIDDataGridViewTextBoxColumn
            // 
            this.advertIDDataGridViewTextBoxColumn.DataPropertyName = "Advert_ID";
            this.advertIDDataGridViewTextBoxColumn.HeaderText = "Advert_ID";
            this.advertIDDataGridViewTextBoxColumn.Name = "advertIDDataGridViewTextBoxColumn";
            this.advertIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.advertIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 52;
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
            // customsDataGridView
            // 
            this.customsDataGridView.AllowUserToAddRows = false;
            this.customsDataGridView.AllowUserToDeleteRows = false;
            this.customsDataGridView.AllowUserToResizeRows = false;
            this.customsDataGridView.AutoGenerateColumns = false;
            this.customsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.customsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.customsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn1,
            this.bankrequisitesDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn});
            this.customsDataGridView.DataSource = this.сustomersBindingSource;
            this.customsDataGridView.Location = new System.Drawing.Point(12, 232);
            this.customsDataGridView.MultiSelect = false;
            this.customsDataGridView.Name = "customsDataGridView";
            this.customsDataGridView.ReadOnly = true;
            this.customsDataGridView.Size = new System.Drawing.Size(591, 164);
            this.customsDataGridView.TabIndex = 3;
            // 
            // custIDDataGridViewTextBoxColumn
            // 
            this.custIDDataGridViewTextBoxColumn.DataPropertyName = "Cust_ID";
            this.custIDDataGridViewTextBoxColumn.HeaderText = "Cust_ID";
            this.custIDDataGridViewTextBoxColumn.Name = "custIDDataGridViewTextBoxColumn";
            this.custIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.custIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            this.titleDataGridViewTextBoxColumn1.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn1.Width = 52;
            // 
            // bankrequisitesDataGridViewTextBoxColumn
            // 
            this.bankrequisitesDataGridViewTextBoxColumn.DataPropertyName = "Bank_requisites";
            this.bankrequisitesDataGridViewTextBoxColumn.HeaderText = "Bank_requisites";
            this.bankrequisitesDataGridViewTextBoxColumn.Name = "bankrequisitesDataGridViewTextBoxColumn";
            this.bankrequisitesDataGridViewTextBoxColumn.ReadOnly = true;
            this.bankrequisitesDataGridViewTextBoxColumn.Width = 107;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telephoneDataGridViewTextBoxColumn.Width = 83;
            // 
            // advertNameLabel
            // 
            this.advertNameLabel.AutoSize = true;
            this.advertNameLabel.BackColor = System.Drawing.SystemColors.Window;
            this.advertNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.advertNameLabel.Location = new System.Drawing.Point(12, 9);
            this.advertNameLabel.Name = "advertNameLabel";
            this.advertNameLabel.Size = new System.Drawing.Size(100, 25);
            this.advertNameLabel.TabIndex = 12;
            this.advertNameLabel.Text = "Реклама";
            // 
            // customersLabel
            // 
            this.customersLabel.AutoSize = true;
            this.customersLabel.BackColor = System.Drawing.SystemColors.Window;
            this.customersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.customersLabel.Location = new System.Drawing.Point(12, 204);
            this.customersLabel.Name = "customersLabel";
            this.customersLabel.Size = new System.Drawing.Size(117, 25);
            this.customersLabel.TabIndex = 13;
            this.customersLabel.Text = "Заказчики";
            // 
            // adsEditPanel
            // 
            this.adsEditPanel.Controls.Add(this.addAdvertButton);
            this.adsEditPanel.Controls.Add(this.changeAdvertButton);
            this.adsEditPanel.Controls.Add(this.deleteAdvertButton);
            this.adsEditPanel.Location = new System.Drawing.Point(612, 37);
            this.adsEditPanel.Name = "adsEditPanel";
            this.adsEditPanel.Size = new System.Drawing.Size(176, 164);
            this.adsEditPanel.TabIndex = 14;
            // 
            // addAdvertButton
            // 
            this.addAdvertButton.BackColor = System.Drawing.Color.Navy;
            this.addAdvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAdvertButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.addAdvertButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.addAdvertButton.Location = new System.Drawing.Point(3, 3);
            this.addAdvertButton.Name = "addAdvertButton";
            this.addAdvertButton.Size = new System.Drawing.Size(170, 41);
            this.addAdvertButton.TabIndex = 3;
            this.addAdvertButton.Text = "Добавить рекламу";
            this.addAdvertButton.UseVisualStyleBackColor = false;
            this.addAdvertButton.Click += new System.EventHandler(this.addAdvertButton_Click);
            // 
            // changeAdvertButton
            // 
            this.changeAdvertButton.BackColor = System.Drawing.Color.Olive;
            this.changeAdvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeAdvertButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeAdvertButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.changeAdvertButton.Location = new System.Drawing.Point(3, 120);
            this.changeAdvertButton.Name = "changeAdvertButton";
            this.changeAdvertButton.Size = new System.Drawing.Size(170, 41);
            this.changeAdvertButton.TabIndex = 5;
            this.changeAdvertButton.Text = "Изменить выбранную рекламу";
            this.changeAdvertButton.UseVisualStyleBackColor = false;
            this.changeAdvertButton.Click += new System.EventHandler(this.changeAdvertButton_Click);
            // 
            // deleteAdvertButton
            // 
            this.deleteAdvertButton.BackColor = System.Drawing.Color.Maroon;
            this.deleteAdvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteAdvertButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.deleteAdvertButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.deleteAdvertButton.Location = new System.Drawing.Point(3, 61);
            this.deleteAdvertButton.Name = "deleteAdvertButton";
            this.deleteAdvertButton.Size = new System.Drawing.Size(170, 41);
            this.deleteAdvertButton.TabIndex = 4;
            this.deleteAdvertButton.Text = "Удалить выбранную рекламу";
            this.deleteAdvertButton.UseVisualStyleBackColor = false;
            this.deleteAdvertButton.Click += new System.EventHandler(this.deleteAdvertButton_Click);
            // 
            // customsEditPanel
            // 
            this.customsEditPanel.Controls.Add(this.addCustomButton);
            this.customsEditPanel.Controls.Add(this.changeCustomButton);
            this.customsEditPanel.Controls.Add(this.deleteCustomButton);
            this.customsEditPanel.Location = new System.Drawing.Point(612, 232);
            this.customsEditPanel.Name = "customsEditPanel";
            this.customsEditPanel.Size = new System.Drawing.Size(176, 164);
            this.customsEditPanel.TabIndex = 11;
            // 
            // addCustomButton
            // 
            this.addCustomButton.BackColor = System.Drawing.Color.Navy;
            this.addCustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.addCustomButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.addCustomButton.Location = new System.Drawing.Point(3, 3);
            this.addCustomButton.Name = "addCustomButton";
            this.addCustomButton.Size = new System.Drawing.Size(170, 41);
            this.addCustomButton.TabIndex = 3;
            this.addCustomButton.Text = "Добавить заказчика";
            this.addCustomButton.UseVisualStyleBackColor = false;
            this.addCustomButton.Click += new System.EventHandler(this.addCustomButton_Click);
            // 
            // changeCustomButton
            // 
            this.changeCustomButton.BackColor = System.Drawing.Color.Olive;
            this.changeCustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeCustomButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeCustomButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.changeCustomButton.Location = new System.Drawing.Point(3, 120);
            this.changeCustomButton.Name = "changeCustomButton";
            this.changeCustomButton.Size = new System.Drawing.Size(170, 41);
            this.changeCustomButton.TabIndex = 5;
            this.changeCustomButton.Text = "Изменить выбранного заказчика";
            this.changeCustomButton.UseVisualStyleBackColor = false;
            this.changeCustomButton.Click += new System.EventHandler(this.changeCustomButton_Click);
            // 
            // deleteCustomButton
            // 
            this.deleteCustomButton.BackColor = System.Drawing.Color.Maroon;
            this.deleteCustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteCustomButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.deleteCustomButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.deleteCustomButton.Location = new System.Drawing.Point(3, 61);
            this.deleteCustomButton.Name = "deleteCustomButton";
            this.deleteCustomButton.Size = new System.Drawing.Size(170, 41);
            this.deleteCustomButton.TabIndex = 4;
            this.deleteCustomButton.Text = "Удалить выбранного заказчика";
            this.deleteCustomButton.UseVisualStyleBackColor = false;
            this.deleteCustomButton.Click += new System.EventHandler(this.deleteCustomButton_Click);
            // 
            // AdvertEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.customsEditPanel);
            this.Controls.Add(this.adsEditPanel);
            this.Controls.Add(this.customersLabel);
            this.Controls.Add(this.advertNameLabel);
            this.Controls.Add(this.customsDataGridView);
            this.Controls.Add(this.adsDataGridView);
            this.Name = "AdvertEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реклама";
            this.Load += new System.EventHandler(this.AdvertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advertDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertsWithTitlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customsDataGridView)).EndInit();
            this.adsEditPanel.ResumeLayout(false);
            this.customsEditPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AdvertDataSet advertDataSet;
        private System.Windows.Forms.BindingSource advertsWithTitlesBindingSource;
        private AdvertDataSetTableAdapters.AdvertsWithTitlesTableAdapter advertsWithTitlesTableAdapter;
        private System.Windows.Forms.BindingSource сustomersBindingSource;
        private AdvertDataSetTableAdapters.СustomersTableAdapter сustomersTableAdapter;
        private System.Windows.Forms.DataGridView adsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn advertIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationsecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView customsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankrequisitesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label advertNameLabel;
        private System.Windows.Forms.Label customersLabel;
        private System.Windows.Forms.Panel adsEditPanel;
        private System.Windows.Forms.Button addAdvertButton;
        private System.Windows.Forms.Button changeAdvertButton;
        private System.Windows.Forms.Button deleteAdvertButton;
        private System.Windows.Forms.Panel customsEditPanel;
        private System.Windows.Forms.Button addCustomButton;
        private System.Windows.Forms.Button changeCustomButton;
        private System.Windows.Forms.Button deleteCustomButton;
    }
}