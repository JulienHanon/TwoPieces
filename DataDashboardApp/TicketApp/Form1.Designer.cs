namespace TicketApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTicket = new System.Windows.Forms.Label();
            this.panelApp = new System.Windows.Forms.Panel();
            this.panelTicket = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecendent = new System.Windows.Forms.Button();
            this.panelTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTicket
            // 
            this.labelTicket.AutoSize = true;
            this.labelTicket.Location = new System.Drawing.Point(13, 13);
            this.labelTicket.Name = "labelTicket";
            this.labelTicket.Size = new System.Drawing.Size(48, 20);
            this.labelTicket.TabIndex = 0;
            this.labelTicket.Text = "Ticket";
            // 
            // panelApp
            // 
            this.panelApp.Location = new System.Drawing.Point(16, 59);
            this.panelApp.Name = "panelApp";
            this.panelApp.Size = new System.Drawing.Size(220, 559);
            this.panelApp.TabIndex = 1;
            // 
            // panelTicket
            // 
            this.panelTicket.Controls.Add(this.dataGridView1);
            this.panelTicket.Controls.Add(this.btnSuivant);
            this.panelTicket.Controls.Add(this.btnPrecendent);
            this.panelTicket.Location = new System.Drawing.Point(255, 59);
            this.panelTicket.Name = "panelTicket";
            this.panelTicket.Size = new System.Drawing.Size(920, 559);
            this.panelTicket.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(300, 188);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(807, 521);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(94, 29);
            this.btnSuivant.TabIndex = 1;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            // 
            // btnPrecendent
            // 
            this.btnPrecendent.Location = new System.Drawing.Point(707, 521);
            this.btnPrecendent.Name = "btnPrecendent";
            this.btnPrecendent.Size = new System.Drawing.Size(94, 29);
            this.btnPrecendent.TabIndex = 0;
            this.btnPrecendent.Text = "Précedent";
            this.btnPrecendent.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 641);
            this.Controls.Add(this.panelTicket);
            this.Controls.Add(this.panelApp);
            this.Controls.Add(this.labelTicket);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelTicket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTicket;
        private Panel panelApp;
        private Panel panelTicket;
        private Button btnSuivant;
        private Button btnPrecendent;
        private DataGridView dataGridView1;
    }
}