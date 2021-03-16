namespace Proiect
{
    partial class Furnizor
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
            this.listBoxCereriF = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeschide = new System.Windows.Forms.Button();
            this.dgvListaCerere = new System.Windows.Forms.DataGridView();
            this.buttonActualizeaza = new System.Windows.Forms.Button();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCerere)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCereriF
            // 
            this.listBoxCereriF.FormattingEnabled = true;
            this.listBoxCereriF.Location = new System.Drawing.Point(19, 45);
            this.listBoxCereriF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxCereriF.Name = "listBoxCereriF";
            this.listBoxCereriF.Size = new System.Drawing.Size(164, 147);
            this.listBoxCereriF.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cererile pentru tine:";
            // 
            // buttonDeschide
            // 
            this.buttonDeschide.Location = new System.Drawing.Point(19, 205);
            this.buttonDeschide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeschide.Name = "buttonDeschide";
            this.buttonDeschide.Size = new System.Drawing.Size(163, 28);
            this.buttonDeschide.TabIndex = 2;
            this.buttonDeschide.Text = "Deschide";
            this.buttonDeschide.UseVisualStyleBackColor = true;
            this.buttonDeschide.Click += new System.EventHandler(this.buttonDeschide_Click);
            // 
            // dgvListaCerere
            // 
            this.dgvListaCerere.AllowUserToAddRows = false;
            this.dgvListaCerere.AllowUserToDeleteRows = false;
            this.dgvListaCerere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCerere.Location = new System.Drawing.Point(212, 28);
            this.dgvListaCerere.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvListaCerere.MultiSelect = false;
            this.dgvListaCerere.Name = "dgvListaCerere";
            this.dgvListaCerere.RowTemplate.Height = 24;
            this.dgvListaCerere.Size = new System.Drawing.Size(764, 205);
            this.dgvListaCerere.TabIndex = 3;
            // 
            // buttonActualizeaza
            // 
            this.buttonActualizeaza.Location = new System.Drawing.Point(812, 246);
            this.buttonActualizeaza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonActualizeaza.Name = "buttonActualizeaza";
            this.buttonActualizeaza.Size = new System.Drawing.Size(163, 28);
            this.buttonActualizeaza.TabIndex = 4;
            this.buttonActualizeaza.Text = "Actualizeaza";
            this.buttonActualizeaza.UseVisualStyleBackColor = true;
            this.buttonActualizeaza.Click += new System.EventHandler(this.buttonActualizeaza_Click);
            // 
            // buttonSterge
            // 
            this.buttonSterge.Location = new System.Drawing.Point(212, 246);
            this.buttonSterge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(163, 28);
            this.buttonSterge.TabIndex = 5;
            this.buttonSterge.Text = "Sterge inregistrare";
            this.buttonSterge.UseVisualStyleBackColor = true;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 292);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Deconectare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Furnizor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 331);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.buttonActualizeaza);
            this.Controls.Add(this.dgvListaCerere);
            this.Controls.Add(this.buttonDeschide);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCereriF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Furnizor";
            this.Text = "Furnizor";
            this.Load += new System.EventHandler(this.Furnizor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCerere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCereriF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeschide;
        private System.Windows.Forms.DataGridView dgvListaCerere;
        private System.Windows.Forms.Button buttonActualizeaza;
        private System.Windows.Forms.Button buttonSterge;
        private System.Windows.Forms.Button button1;

    }
}