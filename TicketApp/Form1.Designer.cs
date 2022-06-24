namespace TicketApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TicketLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusTicketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Détails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindStoreDataSet = new TicketApp.NorthwindStoreDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.userControl13 = new TicketApp.UserControl1();
            this.userControl12 = new TicketApp.UserControl1();
            this.userControl21 = new TicketApp.UserControl2();
            this.userControl11 = new TicketApp.UserControl1();
            this.userControl31 = new TicketApp.UserControl3();
            this.ticketTableAdapter = new TicketApp.NorthwindStoreDataSetTableAdapters.TicketTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResolu = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.employeeTableAdapter = new TicketApp.NorthwindStoreDataSet2TableAdapters.EmployeeTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindStoreDataSet)).BeginInit();
            this.panel1.SuspendLayout();
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
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.userControl13);
            this.panel2.Controls.Add(this.userControl12);
            this.panel2.Controls.Add(this.userControl21);
            this.panel2.Controls.Add(this.userControl11);
            this.panel2.Controls.Add(this.userControl31);
            this.panel2.Location = new System.Drawing.Point(294, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 552);
            this.panel2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(953, 507);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Suivant";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn,
            this.statusTicketDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.dateCreationDataGridViewTextBoxColumn,
            this.Détails});
            this.dataGridView1.DataSource = this.ticketBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1067, 501);
            this.dataGridView1.TabIndex = 0;
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
            this.titleDataGridViewTextBoxColumn.HeaderText = "Titre";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "Technicien";
            this.employeeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusTicketDataGridViewTextBoxColumn
            // 
            this.statusTicketDataGridViewTextBoxColumn.DataPropertyName = "StatusTicket";
            this.statusTicketDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusTicketDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusTicketDataGridViewTextBoxColumn.Name = "statusTicketDataGridViewTextBoxColumn";
            this.statusTicketDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Categorie";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateCreationDataGridViewTextBoxColumn
            // 
            this.dateCreationDataGridViewTextBoxColumn.DataPropertyName = "DateCreation";
            this.dateCreationDataGridViewTextBoxColumn.HeaderText = "Date de création";
            this.dateCreationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateCreationDataGridViewTextBoxColumn.Name = "dateCreationDataGridViewTextBoxColumn";
            this.dateCreationDataGridViewTextBoxColumn.Width = 125;
            // 
            // Détails
            // 
            this.Détails.DataPropertyName = "Détails";
            this.Détails.HeaderText = "Détails";
            this.Détails.MinimumWidth = 6;
            this.Détails.Name = "Détails";
            this.Détails.Text = "Détails";
            this.Détails.ToolTipText = "Détails";
            this.Détails.Width = 125;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(848, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Précedent";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // userControl13
            // 
            this.userControl13.BackColor = System.Drawing.Color.LightCoral;
            this.userControl13.Location = new System.Drawing.Point(0, 0);
            this.userControl13.Name = "userControl13";
            this.userControl13.Size = new System.Drawing.Size(1157, 759);
            this.userControl13.TabIndex = 8;
            // 
            // userControl12
            // 
            this.userControl12.BackColor = System.Drawing.Color.LightCoral;
            this.userControl12.Location = new System.Drawing.Point(0, 0);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(1157, 759);
            this.userControl12.TabIndex = 7;
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.PaleGreen;
            this.userControl21.Location = new System.Drawing.Point(0, 0);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(1067, 552);
            this.userControl21.TabIndex = 6;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.LightCoral;
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1067, 552);
            this.userControl11.TabIndex = 5;
            // 
            // userControl31
            // 
            this.userControl31.BackColor = System.Drawing.Color.LemonChiffon;
            this.userControl31.Location = new System.Drawing.Point(0, 0);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(1067, 552);
            this.userControl31.TabIndex = 9;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnResolu);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.btnDisplay);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Location = new System.Drawing.Point(16, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 551);
            this.panel1.TabIndex = 3;
            // 
            // btnResolu
            // 
            this.btnResolu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnResolu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolu.Location = new System.Drawing.Point(0, 266);
            this.btnResolu.Name = "btnResolu";
            this.btnResolu.Size = new System.Drawing.Size(253, 94);
            this.btnResolu.TabIndex = 3;
            this.btnResolu.Text = "Résolu";
            this.btnResolu.UseVisualStyleBackColor = false;
            this.btnResolu.Click += new System.EventHandler(this.btnResolu_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(0, 175);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(253, 94);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Nouveau Ticket";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDisplay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(0, 89);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(253, 94);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Afficher Ticket";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(0, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(253, 94);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Créer un ticket";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 654);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TicketLabel);
            this.Name = "Form1";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindStoreDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TicketLabel;
        private System.Windows.Forms.Panel panel2;
        private NorthwindStoreDataSet northwindStoreDataSet;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private NorthwindStoreDataSetTableAdapters.TicketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnResolu;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnCreate;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusTicketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Détails;
        private UserControl1 userControl12;
        private UserControl1 userControl13;
        private UserControl3 userControl31;
        private NorthwindStoreDataSet2TableAdapters.EmployeeTableAdapter employeeTableAdapter;
    }
}

