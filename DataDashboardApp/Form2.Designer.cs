namespace DashboardApp
{
    partial class Form2
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
            this.TicketLabel = new System.Windows.Forms.Label();
            this.panelTicket = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supporterNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusTicketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindStoreDataSet = new DashboardApp.NorthwindStoreDataSet();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecendent = new System.Windows.Forms.Button();
            this.panelApp = new System.Windows.Forms.Panel();
            this.btnDashboardApp = new System.Windows.Forms.Button();
            this.ticketTableAdapter = new DashboardApp.NorthwindStoreDataSetTableAdapters.TicketTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindStoreDataSet)).BeginInit();
            this.panelApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // TicketLabel
            // 
            this.TicketLabel.AutoSize = true;
            this.TicketLabel.Location = new System.Drawing.Point(13, 13);
            this.TicketLabel.Name = "TicketLabel";
            this.TicketLabel.Size = new System.Drawing.Size(44, 16);
            this.TicketLabel.TabIndex = 0;
            this.TicketLabel.Text = "Ticket";
            // 
            // panelTicket
            // 
            this.panelTicket.Controls.Add(this.dataGridView1);
            this.panelTicket.Controls.Add(this.btnSuivant);
            this.panelTicket.Controls.Add(this.btnPrecendent);
            this.panelTicket.Location = new System.Drawing.Point(255, 59);
            this.panelTicket.Name = "panelTicket";
            this.panelTicket.Size = new System.Drawing.Size(920, 559);
            this.panelTicket.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn,
            this.supporterNameDataGridViewTextBoxColumn,
            this.statusTicketDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.dateCreationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ticketBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(923, 515);
            this.dataGridView1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // supporterNameDataGridViewTextBoxColumn
            // 
            this.supporterNameDataGridViewTextBoxColumn.DataPropertyName = "SupporterName";
            this.supporterNameDataGridViewTextBoxColumn.HeaderText = "SupporterName";
            this.supporterNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supporterNameDataGridViewTextBoxColumn.Name = "supporterNameDataGridViewTextBoxColumn";
            this.supporterNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusTicketDataGridViewTextBoxColumn
            // 
            this.statusTicketDataGridViewTextBoxColumn.DataPropertyName = "StatusTicket";
            this.statusTicketDataGridViewTextBoxColumn.HeaderText = "StatusTicket";
            this.statusTicketDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusTicketDataGridViewTextBoxColumn.Name = "statusTicketDataGridViewTextBoxColumn";
            this.statusTicketDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateCreationDataGridViewTextBoxColumn
            // 
            this.dateCreationDataGridViewTextBoxColumn.DataPropertyName = "DateCreation";
            this.dateCreationDataGridViewTextBoxColumn.HeaderText = "DateCreation";
            this.dateCreationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateCreationDataGridViewTextBoxColumn.Name = "dateCreationDataGridViewTextBoxColumn";
            this.dateCreationDataGridViewTextBoxColumn.Width = 125;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.northwindStoreDataSet;
            // 
            // northwindStoreDataSet
            // 
            this.northwindStoreDataSet.DataSetName = "NorthwindStoreDataSet";
            this.northwindStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(807, 521);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(88, 23);
            this.btnSuivant.TabIndex = 1;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            // 
            // btnPrecendent
            // 
            this.btnPrecendent.Location = new System.Drawing.Point(718, 521);
            this.btnPrecendent.Name = "btnPrecendent";
            this.btnPrecendent.Size = new System.Drawing.Size(83, 23);
            this.btnPrecendent.TabIndex = 0;
            this.btnPrecendent.Text = "Précedent";
            this.btnPrecendent.UseVisualStyleBackColor = true;
            // 
            // panelApp
            // 
            this.panelApp.Controls.Add(this.button2);
            this.panelApp.Controls.Add(this.button1);
            this.panelApp.Controls.Add(this.btnDashboardApp);
            this.panelApp.Location = new System.Drawing.Point(16, 59);
            this.panelApp.Name = "panelApp";
            this.panelApp.Size = new System.Drawing.Size(220, 559);
            this.panelApp.TabIndex = 2;
            // 
            // btnDashboardApp
            // 
            this.btnDashboardApp.Location = new System.Drawing.Point(3, 3);
            this.btnDashboardApp.Name = "btnDashboardApp";
            this.btnDashboardApp.Size = new System.Drawing.Size(217, 103);
            this.btnDashboardApp.TabIndex = 0;
            this.btnDashboardApp.Text = "button1";
            this.btnDashboardApp.UseVisualStyleBackColor = true;
            this.btnDashboardApp.Click += new System.EventHandler(this.button1_Click);
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 103);
            this.button1.TabIndex = 1;
            this.button1.Text = "button2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 121);
            this.button2.TabIndex = 2;
            this.button2.Text = "button3";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 641);
            this.Controls.Add(this.panelApp);
            this.Controls.Add(this.panelTicket);
            this.Controls.Add(this.TicketLabel);
            this.Name = "Form2";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelTicket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindStoreDataSet)).EndInit();
            this.panelApp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TicketLabel;
        private System.Windows.Forms.Panel panelTicket;
        private System.Windows.Forms.Panel panelApp;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecendent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NorthwindStoreDataSet northwindStoreDataSet;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private NorthwindStoreDataSetTableAdapters.TicketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supporterNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusTicketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDashboardApp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}