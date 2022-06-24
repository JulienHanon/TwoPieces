namespace TicketApp
{
    partial class UserControl1
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelCreate = new System.Windows.Forms.Label();
            this.btnCreer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.northwindStoreDataSet2 = new TicketApp.NorthwindStoreDataSet2();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boxTechnicien = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.northwindStoreDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCreate
            // 
            this.labelCreate.AutoSize = true;
            this.labelCreate.Location = new System.Drawing.Point(33, 33);
            this.labelCreate.Name = "labelCreate";
            this.labelCreate.Size = new System.Drawing.Size(116, 16);
            this.labelCreate.TabIndex = 0;
            this.labelCreate.Text = "Création de Ticket";
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(142, 349);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(127, 53);
            this.btnCreer.TabIndex = 1;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(298, 349);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 53);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Titre";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 282);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(321, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Details";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(104, 223);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(321, 24);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Text = "Categorie";
            // 
            // northwindStoreDataSet2
            // 
            this.northwindStoreDataSet2.DataSetName = "NorthwindStoreDataSet2";
            this.northwindStoreDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.northwindStoreDataSet2;
            // 
            // boxTechnicien
            // 
            this.boxTechnicien.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeeBindingSource, "EmployeeName", true));
            this.boxTechnicien.DataSource = this.employeeBindingSource;
            this.boxTechnicien.DisplayMember = "EmployeeName";
            this.boxTechnicien.FormattingEnabled = true;
            this.boxTechnicien.Location = new System.Drawing.Point(104, 164);
            this.boxTechnicien.Name = "boxTechnicien";
            this.boxTechnicien.Size = new System.Drawing.Size(321, 24);
            this.boxTechnicien.TabIndex = 8;
            this.boxTechnicien.ValueMember = "EmployeeName";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.Controls.Add(this.boxTechnicien);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.labelCreate);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1157, 759);
            ((System.ComponentModel.ISupportInitialize)(this.northwindStoreDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreate;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private NorthwindStoreDataSet2 northwindStoreDataSet2;
        private System.Windows.Forms.ComboBox boxTechnicien;
    }
}
