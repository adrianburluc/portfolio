namespace Proiect
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConectare = new System.Windows.Forms.Button();
            this.buttonInregistrare = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAngajat = new System.Windows.Forms.RadioButton();
            this.rbFurnizor = new System.Windows.Forms.RadioButton();
            this.rbBeneficiar = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID User";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(94, 31);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(183, 26);
            this.textBoxID.TabIndex = 1;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParola.Location = new System.Drawing.Point(94, 74);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.PasswordChar = '*';
            this.textBoxParola.Size = new System.Drawing.Size(183, 26);
            this.textBoxParola.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parola";
            // 
            // buttonConectare
            // 
            this.buttonConectare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConectare.Location = new System.Drawing.Point(41, 162);
            this.buttonConectare.Name = "buttonConectare";
            this.buttonConectare.Size = new System.Drawing.Size(297, 37);
            this.buttonConectare.TabIndex = 3;
            this.buttonConectare.Text = "Conectare";
            this.buttonConectare.UseVisualStyleBackColor = true;
            this.buttonConectare.Click += new System.EventHandler(this.buttonConectare_Click);
            // 
            // buttonInregistrare
            // 
            this.buttonInregistrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInregistrare.Location = new System.Drawing.Point(366, 162);
            this.buttonInregistrare.Name = "buttonInregistrare";
            this.buttonInregistrare.Size = new System.Drawing.Size(277, 37);
            this.buttonInregistrare.TabIndex = 4;
            this.buttonInregistrare.Text = "Inregistrare";
            this.buttonInregistrare.UseVisualStyleBackColor = true;
            this.buttonInregistrare.Click += new System.EventHandler(this.buttonInregistrare_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAngajat);
            this.groupBox1.Controls.Add(this.rbFurnizor);
            this.groupBox1.Controls.Add(this.rbBeneficiar);
            this.groupBox1.Location = new System.Drawing.Point(366, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 129);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecteaza tipul contului:";
            // 
            // rbAngajat
            // 
            this.rbAngajat.AutoSize = true;
            this.rbAngajat.Location = new System.Drawing.Point(19, 83);
            this.rbAngajat.Name = "rbAngajat";
            this.rbAngajat.Size = new System.Drawing.Size(77, 21);
            this.rbAngajat.TabIndex = 2;
            this.rbAngajat.Text = "Angajat";
            this.rbAngajat.UseVisualStyleBackColor = true;
            // 
            // rbFurnizor
            // 
            this.rbFurnizor.AutoSize = true;
            this.rbFurnizor.Location = new System.Drawing.Point(19, 56);
            this.rbFurnizor.Name = "rbFurnizor";
            this.rbFurnizor.Size = new System.Drawing.Size(81, 21);
            this.rbFurnizor.TabIndex = 1;
            this.rbFurnizor.Text = "Furnizor";
            this.rbFurnizor.UseVisualStyleBackColor = true;
            // 
            // rbBeneficiar
            // 
            this.rbBeneficiar.AutoSize = true;
            this.rbBeneficiar.Location = new System.Drawing.Point(19, 29);
            this.rbBeneficiar.Name = "rbBeneficiar";
            this.rbBeneficiar.Size = new System.Drawing.Size(92, 21);
            this.rbBeneficiar.TabIndex = 0;
            this.rbBeneficiar.Text = "Beneficiar";
            this.rbBeneficiar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxID);
            this.groupBox2.Controls.Add(this.textBoxParola);
            this.groupBox2.Location = new System.Drawing.Point(41, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 129);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Introdu datele contului:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 240);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonInregistrare);
            this.Controls.Add(this.buttonConectare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConectare;
        private System.Windows.Forms.Button buttonInregistrare;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAngajat;
        private System.Windows.Forms.RadioButton rbFurnizor;
        private System.Windows.Forms.RadioButton rbBeneficiar;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

