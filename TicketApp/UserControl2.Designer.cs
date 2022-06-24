namespace TicketApp
{
    partial class UserControl2
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
            this.northwindStoreDataSet = new TicketApp.NorthwindStoreDataSet();
            this.northwindStoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindStoreDataSet1 = new TicketApp.NorthwindStoreDataSet1();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketTableAdapter = new TicketApp.NorthwindStoreDataSet1TableAdapters.TicketTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.northwindStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindStoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindStoreDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // northwindStoreDataSet
            // 
            this.northwindStoreDataSet.DataSetName = "NorthwindStoreDataSet";
            this.northwindStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // northwindStoreDataSetBindingSource
            // 
            this.northwindStoreDataSetBindingSource.DataSource = this.northwindStoreDataSet;
            this.northwindStoreDataSetBindingSource.Position = 0;
            // 
            // northwindStoreDataSet1
            // 
            this.northwindStoreDataSet1.DataSetName = "NorthwindStoreDataSet1";
            this.northwindStoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.northwindStoreDataSet1;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1123, 765);
            ((System.ComponentModel.ISupportInitialize)(this.northwindStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindStoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindStoreDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource northwindStoreDataSetBindingSource;
        private NorthwindStoreDataSet northwindStoreDataSet;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private NorthwindStoreDataSet1 northwindStoreDataSet1;
        private NorthwindStoreDataSet1TableAdapters.TicketTableAdapter ticketTableAdapter;
    }
}
