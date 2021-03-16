namespace Proiect
{
    partial class angajat_cereri
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
            this.buttonAproba = new System.Windows.Forms.Button();
            this.dgvListaCerere = new System.Windows.Forms.DataGridView();
            this.buttonDeschide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCereriFinalizate = new System.Windows.Forms.ListBox();
            this.buttonRespinge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCerere)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAproba
            // 
            this.buttonAproba.Location = new System.Drawing.Point(958, 308);
            this.buttonAproba.Name = "buttonAproba";
            this.buttonAproba.Size = new System.Drawing.Size(217, 35);
            this.buttonAproba.TabIndex = 10;
            this.buttonAproba.Text = "Aproba cerere";
            this.buttonAproba.UseVisualStyleBackColor = true;
            // 
            // dgvListaCerere
            // 
            this.dgvListaCerere.AllowUserToAddRows = false;
            this.dgvListaCerere.AllowUserToDeleteRows = false;
            this.dgvListaCerere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCerere.Location = new System.Drawing.Point(282, 35);
            this.dgvListaCerere.MultiSelect = false;
            this.dgvListaCerere.Name = "dgvListaCerere";
            this.dgvListaCerere.RowTemplate.Height = 24;
            this.dgvListaCerere.Size = new System.Drawing.Size(893, 252);
            this.dgvListaCerere.TabIndex = 9;
            // 
            // buttonDeschide
            // 
            this.buttonDeschide.Location = new System.Drawing.Point(25, 252);
            this.buttonDeschide.Name = "buttonDeschide";
            this.buttonDeschide.Size = new System.Drawing.Size(217, 35);
            this.buttonDeschide.TabIndex = 8;
            this.buttonDeschide.Text = "Deschide";
            this.buttonDeschide.UseVisualStyleBackColor = true;
            this.buttonDeschide.Click += new System.EventHandler(this.buttonDeschide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cererile pentru tine:";
            // 
            // listBoxCereriFinalizate
            // 
            this.listBoxCereriFinalizate.FormattingEnabled = true;
            this.listBoxCereriFinalizate.ItemHeight = 16;
            this.listBoxCereriFinalizate.Location = new System.Drawing.Point(25, 55);
            this.listBoxCereriFinalizate.Name = "listBoxCereriFinalizate";
            this.listBoxCereriFinalizate.Size = new System.Drawing.Size(217, 180);
            this.listBoxCereriFinalizate.TabIndex = 6;
            this.listBoxCereriFinalizate.SelectedIndexChanged += new System.EventHandler(this.listBoxCereriFinalizate_SelectedIndexChanged);
            // 
            // buttonRespinge
            // 
            this.buttonRespinge.Location = new System.Drawing.Point(735, 308);
            this.buttonRespinge.Name = "buttonRespinge";
            this.buttonRespinge.Size = new System.Drawing.Size(217, 35);
            this.buttonRespinge.TabIndex = 12;
            this.buttonRespinge.Text = "Respinge cerere";
            this.buttonRespinge.UseVisualStyleBackColor = true;
            this.buttonRespinge.Click += new System.EventHandler(this.buttonRespinge_Click);
            // 
            // angajat_cereri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 412);
            this.Controls.Add(this.buttonRespinge);
            this.Controls.Add(this.buttonAproba);
            this.Controls.Add(this.dgvListaCerere);
            this.Controls.Add(this.buttonDeschide);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCereriFinalizate);
            this.Name = "angajat_cereri";
            this.Text = "Cereri finalizate";
            this.Load += new System.EventHandler(this.angajat_cereri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCerere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAproba;
        private System.Windows.Forms.DataGridView dgvListaCerere;
        private System.Windows.Forms.Button buttonDeschide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxCereriFinalizate;
        private System.Windows.Forms.Button buttonRespinge;

    }
}