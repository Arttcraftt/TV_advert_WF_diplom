
namespace TV_advert_WF
{
    partial class ProgramEditForm
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
            this.progsDataGridView = new System.Windows.Forms.DataGridView();
            this.progIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minuteCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programsWithTitlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advertDataSet = new TV_advert_WF.AdvertDataSet();
            this.programsWithTitlesTableAdapter = new TV_advert_WF.AdvertDataSetTableAdapters.ProgramsWithTitlesTableAdapter();
            this.progEditPanel = new System.Windows.Forms.Panel();
            this.addProgButton = new System.Windows.Forms.Button();
            this.changeProgButton = new System.Windows.Forms.Button();
            this.deleteProgButton = new System.Windows.Forms.Button();
            this.progNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.progsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsWithTitlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertDataSet)).BeginInit();
            this.progEditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // progsDataGridView
            // 
            this.progsDataGridView.AllowUserToAddRows = false;
            this.progsDataGridView.AllowUserToDeleteRows = false;
            this.progsDataGridView.AllowUserToResizeRows = false;
            this.progsDataGridView.AutoGenerateColumns = false;
            this.progsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.progsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.progsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.progsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.progIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.minuteCostDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn});
            this.progsDataGridView.DataSource = this.programsWithTitlesBindingSource;
            this.progsDataGridView.Location = new System.Drawing.Point(12, 37);
            this.progsDataGridView.MultiSelect = false;
            this.progsDataGridView.Name = "progsDataGridView";
            this.progsDataGridView.ReadOnly = true;
            this.progsDataGridView.Size = new System.Drawing.Size(591, 164);
            this.progsDataGridView.TabIndex = 3;
            // 
            // progIDDataGridViewTextBoxColumn
            // 
            this.progIDDataGridViewTextBoxColumn.DataPropertyName = "Prog_ID";
            this.progIDDataGridViewTextBoxColumn.HeaderText = "Prog_ID";
            this.progIDDataGridViewTextBoxColumn.Name = "progIDDataGridViewTextBoxColumn";
            this.progIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.progIDDataGridViewTextBoxColumn.Width = 71;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 52;
            // 
            // minuteCostDataGridViewTextBoxColumn
            // 
            this.minuteCostDataGridViewTextBoxColumn.DataPropertyName = "MinuteCost";
            this.minuteCostDataGridViewTextBoxColumn.HeaderText = "MinuteCost";
            this.minuteCostDataGridViewTextBoxColumn.Name = "minuteCostDataGridViewTextBoxColumn";
            this.minuteCostDataGridViewTextBoxColumn.ReadOnly = true;
            this.minuteCostDataGridViewTextBoxColumn.Width = 85;
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
            // advertDataSet
            // 
            this.advertDataSet.DataSetName = "AdvertDataSet";
            this.advertDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programsWithTitlesTableAdapter
            // 
            this.programsWithTitlesTableAdapter.ClearBeforeFill = true;
            // 
            // progEditPanel
            // 
            this.progEditPanel.Controls.Add(this.addProgButton);
            this.progEditPanel.Controls.Add(this.changeProgButton);
            this.progEditPanel.Controls.Add(this.deleteProgButton);
            this.progEditPanel.Location = new System.Drawing.Point(612, 37);
            this.progEditPanel.Name = "progEditPanel";
            this.progEditPanel.Size = new System.Drawing.Size(176, 164);
            this.progEditPanel.TabIndex = 10;
            // 
            // addProgButton
            // 
            this.addProgButton.BackColor = System.Drawing.Color.Navy;
            this.addProgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProgButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.addProgButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.addProgButton.Location = new System.Drawing.Point(3, 3);
            this.addProgButton.Name = "addProgButton";
            this.addProgButton.Size = new System.Drawing.Size(170, 41);
            this.addProgButton.TabIndex = 3;
            this.addProgButton.Text = "Добавить программу";
            this.addProgButton.UseVisualStyleBackColor = false;
            this.addProgButton.Click += new System.EventHandler(this.addProgButton_Click);
            // 
            // changeProgButton
            // 
            this.changeProgButton.BackColor = System.Drawing.Color.Olive;
            this.changeProgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeProgButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeProgButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.changeProgButton.Location = new System.Drawing.Point(3, 120);
            this.changeProgButton.Name = "changeProgButton";
            this.changeProgButton.Size = new System.Drawing.Size(170, 41);
            this.changeProgButton.TabIndex = 5;
            this.changeProgButton.Text = "Изменить выбранную программу";
            this.changeProgButton.UseVisualStyleBackColor = false;
            this.changeProgButton.Click += new System.EventHandler(this.changeProgButton_Click);
            // 
            // deleteProgButton
            // 
            this.deleteProgButton.BackColor = System.Drawing.Color.Maroon;
            this.deleteProgButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteProgButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.deleteProgButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.deleteProgButton.Location = new System.Drawing.Point(3, 61);
            this.deleteProgButton.Name = "deleteProgButton";
            this.deleteProgButton.Size = new System.Drawing.Size(170, 41);
            this.deleteProgButton.TabIndex = 4;
            this.deleteProgButton.Text = "Удалить выбранную программу";
            this.deleteProgButton.UseVisualStyleBackColor = false;
            this.deleteProgButton.Click += new System.EventHandler(this.deleteProgButton_Click);
            // 
            // progNameLabel
            // 
            this.progNameLabel.AutoSize = true;
            this.progNameLabel.BackColor = System.Drawing.SystemColors.Window;
            this.progNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.progNameLabel.Location = new System.Drawing.Point(12, 9);
            this.progNameLabel.Name = "progNameLabel";
            this.progNameLabel.Size = new System.Drawing.Size(128, 25);
            this.progNameLabel.TabIndex = 13;
            this.progNameLabel.Text = "Программы";
            // 
            // ProgramEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 217);
            this.Controls.Add(this.progNameLabel);
            this.Controls.Add(this.progEditPanel);
            this.Controls.Add(this.progsDataGridView);
            this.Name = "ProgramEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программы";
            this.Load += new System.EventHandler(this.ProgramEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsWithTitlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertDataSet)).EndInit();
            this.progEditPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView progsDataGridView;
        private AdvertDataSet advertDataSet;
        private System.Windows.Forms.BindingSource programsWithTitlesBindingSource;
        private AdvertDataSetTableAdapters.ProgramsWithTitlesTableAdapter programsWithTitlesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn progIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minuteCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel progEditPanel;
        private System.Windows.Forms.Button addProgButton;
        private System.Windows.Forms.Button changeProgButton;
        private System.Windows.Forms.Button deleteProgButton;
        private System.Windows.Forms.Label progNameLabel;
    }
}