
namespace TV_advert_WF
{
    partial class BlockEditForm
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
            this.blockEditPanel = new System.Windows.Forms.Panel();
            this.addBlockButton = new System.Windows.Forms.Button();
            this.changeBlockButton = new System.Windows.Forms.Button();
            this.deleteBlockButton = new System.Windows.Forms.Button();
            this.blocksDataGridView = new System.Windows.Forms.DataGridView();
            this.blocksNameLabel = new System.Windows.Forms.Label();
            this.advertDataSet = new TV_advert_WF.AdvertDataSet();
            this.blocksWithTitlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blocksWithTitlesTableAdapter = new TV_advert_WF.AdvertDataSetTableAdapters.BlocksWithTitlesTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advertDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockEditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blocksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocksWithTitlesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // blockEditPanel
            // 
            this.blockEditPanel.Controls.Add(this.addBlockButton);
            this.blockEditPanel.Controls.Add(this.changeBlockButton);
            this.blockEditPanel.Controls.Add(this.deleteBlockButton);
            this.blockEditPanel.Location = new System.Drawing.Point(612, 37);
            this.blockEditPanel.Name = "blockEditPanel";
            this.blockEditPanel.Size = new System.Drawing.Size(176, 164);
            this.blockEditPanel.TabIndex = 9;
            // 
            // addBlockButton
            // 
            this.addBlockButton.BackColor = System.Drawing.Color.Navy;
            this.addBlockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBlockButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.addBlockButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.addBlockButton.Location = new System.Drawing.Point(3, 3);
            this.addBlockButton.Name = "addBlockButton";
            this.addBlockButton.Size = new System.Drawing.Size(170, 41);
            this.addBlockButton.TabIndex = 3;
            this.addBlockButton.Text = "Добавить блок";
            this.addBlockButton.UseVisualStyleBackColor = false;
            // 
            // changeBlockButton
            // 
            this.changeBlockButton.BackColor = System.Drawing.Color.Olive;
            this.changeBlockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeBlockButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeBlockButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.changeBlockButton.Location = new System.Drawing.Point(3, 120);
            this.changeBlockButton.Name = "changeBlockButton";
            this.changeBlockButton.Size = new System.Drawing.Size(170, 41);
            this.changeBlockButton.TabIndex = 5;
            this.changeBlockButton.Text = "Изменить выбранный блок";
            this.changeBlockButton.UseVisualStyleBackColor = false;
            // 
            // deleteBlockButton
            // 
            this.deleteBlockButton.BackColor = System.Drawing.Color.Maroon;
            this.deleteBlockButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBlockButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.deleteBlockButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.deleteBlockButton.Location = new System.Drawing.Point(3, 61);
            this.deleteBlockButton.Name = "deleteBlockButton";
            this.deleteBlockButton.Size = new System.Drawing.Size(170, 41);
            this.deleteBlockButton.TabIndex = 4;
            this.deleteBlockButton.Text = "Удалить выбранный блок";
            this.deleteBlockButton.UseVisualStyleBackColor = false;
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
            this.iDDataGridViewTextBoxColumn,
            this.programDataGridViewTextBoxColumn,
            this.advertDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn});
            this.blocksDataGridView.DataSource = this.blocksWithTitlesBindingSource;
            this.blocksDataGridView.Location = new System.Drawing.Point(12, 37);
            this.blocksDataGridView.MultiSelect = false;
            this.blocksDataGridView.Name = "blocksDataGridView";
            this.blocksDataGridView.ReadOnly = true;
            this.blocksDataGridView.Size = new System.Drawing.Size(594, 164);
            this.blocksDataGridView.TabIndex = 10;
            // 
            // blocksNameLabel
            // 
            this.blocksNameLabel.AutoSize = true;
            this.blocksNameLabel.BackColor = System.Drawing.SystemColors.Window;
            this.blocksNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blocksNameLabel.Location = new System.Drawing.Point(12, 9);
            this.blocksNameLabel.Name = "blocksNameLabel";
            this.blocksNameLabel.Size = new System.Drawing.Size(73, 25);
            this.blocksNameLabel.TabIndex = 11;
            this.blocksNameLabel.Text = "Блоки";
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
            // BlockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 217);
            this.Controls.Add(this.blocksNameLabel);
            this.Controls.Add(this.blocksDataGridView);
            this.Controls.Add(this.blockEditPanel);
            this.Name = "BlockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Блоки";
            this.Load += new System.EventHandler(this.BlockForm_Load);
            this.blockEditPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.blocksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advertDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocksWithTitlesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel blockEditPanel;
        private System.Windows.Forms.Button addBlockButton;
        private System.Windows.Forms.Button changeBlockButton;
        private System.Windows.Forms.Button deleteBlockButton;
        private System.Windows.Forms.DataGridView blocksDataGridView;
        private System.Windows.Forms.Label blocksNameLabel;
        private AdvertDataSet advertDataSet;
        private System.Windows.Forms.BindingSource blocksWithTitlesBindingSource;
        private AdvertDataSetTableAdapters.BlocksWithTitlesTableAdapter blocksWithTitlesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn advertDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
    }
}