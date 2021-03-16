namespace Proiect
{
    partial class Angajat
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGenereaza = new System.Windows.Forms.Button();
            this.labelCod = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonTrimiteCerereC = new System.Windows.Forms.Button();
            this.listBoxListaM = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxFurnizor = new System.Windows.Forms.ListBox();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.buttonCautaFurnizor = new System.Windows.Forms.Button();
            this.textBoxCautaFurnizor = new System.Windows.Forms.TextBox();
            this.listBoxMedicament = new System.Windows.Forms.ListBox();
            this.buttonCautaMedicament = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCautaMedicament = new System.Windows.Forms.TextBox();
            this.textBoxCantitate = new System.Windows.Forms.TextBox();
            this.dgvStoc = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelnrcereri = new System.Windows.Forms.Label();
            this.labelnrb = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelnra = new System.Windows.Forms.Label();
            this.labelnrf = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvStocMed = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonRespinge = new System.Windows.Forms.Button();
            this.buttonAproba = new System.Windows.Forms.Button();
            this.dgvListaCerere = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxCereriFinalizate = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.dgvStoc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocMed)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCerere)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGenereaza);
            this.groupBox1.Controls.Add(this.labelCod);
            this.groupBox1.Location = new System.Drawing.Point(19, 197);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(231, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genereaza cod de inregistrare angajat";
            // 
            // buttonGenereaza
            // 
            this.buttonGenereaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenereaza.Location = new System.Drawing.Point(16, 46);
            this.buttonGenereaza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGenereaza.Name = "buttonGenereaza";
            this.buttonGenereaza.Size = new System.Drawing.Size(190, 29);
            this.buttonGenereaza.TabIndex = 2;
            this.buttonGenereaza.Text = "Genereaza";
            this.buttonGenereaza.UseVisualStyleBackColor = true;
            this.buttonGenereaza.Click += new System.EventHandler(this.buttonGenereaza_Click);
            // 
            // labelCod
            // 
            this.labelCod.AutoSize = true;
            this.labelCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCod.Location = new System.Drawing.Point(14, 21);
            this.labelCod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(41, 17);
            this.labelCod.TabIndex = 0;
            this.labelCod.Text = "Cod: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.buttonSterge);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.buttonTrimiteCerereC);
            this.groupBox2.Controls.Add(this.listBoxListaM);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.listBoxFurnizor);
            this.groupBox2.Controls.Add(this.buttonAdauga);
            this.groupBox2.Controls.Add(this.buttonCautaFurnizor);
            this.groupBox2.Controls.Add(this.textBoxCautaFurnizor);
            this.groupBox2.Controls.Add(this.listBoxMedicament);
            this.groupBox2.Controls.Add(this.buttonCautaMedicament);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxCautaMedicament);
            this.groupBox2.Controls.Add(this.textBoxCantitate);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(896, 349);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Completeaza cerere cumparare";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(34, 280);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Inregistreaza medicament";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSterge
            // 
            this.buttonSterge.Location = new System.Drawing.Point(506, 210);
            this.buttonSterge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(278, 29);
            this.buttonSterge.TabIndex = 17;
            this.buttonSterge.Text = "Sterge din lista";
            this.buttonSterge.UseVisualStyleBackColor = true;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cosul medicamentelor adaugate";
            // 
            // buttonTrimiteCerereC
            // 
            this.buttonTrimiteCerereC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrimiteCerereC.Location = new System.Drawing.Point(506, 247);
            this.buttonTrimiteCerereC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTrimiteCerereC.Name = "buttonTrimiteCerereC";
            this.buttonTrimiteCerereC.Size = new System.Drawing.Size(278, 35);
            this.buttonTrimiteCerereC.TabIndex = 4;
            this.buttonTrimiteCerereC.Text = "3. Trimite cerere";
            this.buttonTrimiteCerereC.UseVisualStyleBackColor = true;
            this.buttonTrimiteCerereC.Click += new System.EventHandler(this.buttonTrimiteCerereC_Click);
            // 
            // listBoxListaM
            // 
            this.listBoxListaM.FormattingEnabled = true;
            this.listBoxListaM.Location = new System.Drawing.Point(506, 58);
            this.listBoxListaM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxListaM.Name = "listBoxListaM";
            this.listBoxListaM.Size = new System.Drawing.Size(278, 147);
            this.listBoxListaM.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "1. Adauga medicament";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "2. Selecteaza furnizor";
            // 
            // listBoxFurnizor
            // 
            this.listBoxFurnizor.FormattingEnabled = true;
            this.listBoxFurnizor.Location = new System.Drawing.Point(272, 84);
            this.listBoxFurnizor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxFurnizor.Name = "listBoxFurnizor";
            this.listBoxFurnizor.Size = new System.Drawing.Size(156, 199);
            this.listBoxFurnizor.TabIndex = 0;
            this.listBoxFurnizor.SelectedIndexChanged += new System.EventHandler(this.listBoxFurnizor_SelectedIndexChanged);
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(34, 248);
            this.buttonAdauga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(156, 29);
            this.buttonAdauga.TabIndex = 10;
            this.buttonAdauga.Text = "Adauga in lista";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // buttonCautaFurnizor
            // 
            this.buttonCautaFurnizor.Location = new System.Drawing.Point(370, 58);
            this.buttonCautaFurnizor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCautaFurnizor.Name = "buttonCautaFurnizor";
            this.buttonCautaFurnizor.Size = new System.Drawing.Size(58, 23);
            this.buttonCautaFurnizor.TabIndex = 8;
            this.buttonCautaFurnizor.Text = "Cauta";
            this.buttonCautaFurnizor.UseVisualStyleBackColor = true;
            this.buttonCautaFurnizor.Click += new System.EventHandler(this.buttonCautaFurnizor_Click);
            // 
            // textBoxCautaFurnizor
            // 
            this.textBoxCautaFurnizor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCautaFurnizor.Location = new System.Drawing.Point(272, 58);
            this.textBoxCautaFurnizor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCautaFurnizor.Name = "textBoxCautaFurnizor";
            this.textBoxCautaFurnizor.Size = new System.Drawing.Size(94, 23);
            this.textBoxCautaFurnizor.TabIndex = 6;
            // 
            // listBoxMedicament
            // 
            this.listBoxMedicament.FormattingEnabled = true;
            this.listBoxMedicament.Location = new System.Drawing.Point(34, 84);
            this.listBoxMedicament.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxMedicament.Name = "listBoxMedicament";
            this.listBoxMedicament.Size = new System.Drawing.Size(156, 134);
            this.listBoxMedicament.TabIndex = 1;
            // 
            // buttonCautaMedicament
            // 
            this.buttonCautaMedicament.Location = new System.Drawing.Point(133, 58);
            this.buttonCautaMedicament.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCautaMedicament.Name = "buttonCautaMedicament";
            this.buttonCautaMedicament.Size = new System.Drawing.Size(58, 23);
            this.buttonCautaMedicament.TabIndex = 9;
            this.buttonCautaMedicament.Text = "Cauta";
            this.buttonCautaMedicament.UseVisualStyleBackColor = true;
            this.buttonCautaMedicament.Click += new System.EventHandler(this.buttonCautaMedicament_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantitate";
            // 
            // textBoxCautaMedicament
            // 
            this.textBoxCautaMedicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCautaMedicament.Location = new System.Drawing.Point(34, 58);
            this.textBoxCautaMedicament.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCautaMedicament.Name = "textBoxCautaMedicament";
            this.textBoxCautaMedicament.Size = new System.Drawing.Size(94, 23);
            this.textBoxCautaMedicament.TabIndex = 7;
            // 
            // textBoxCantitate
            // 
            this.textBoxCantitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantitate.Location = new System.Drawing.Point(98, 222);
            this.textBoxCantitate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCantitate.Name = "textBoxCantitate";
            this.textBoxCantitate.Size = new System.Drawing.Size(93, 23);
            this.textBoxCantitate.TabIndex = 3;
            // 
            // dgvStoc
            // 
            this.dgvStoc.Controls.Add(this.tabPage1);
            this.dgvStoc.Controls.Add(this.tabPage4);
            this.dgvStoc.Controls.Add(this.tabPage3);
            this.dgvStoc.Controls.Add(this.tabPage2);
            this.dgvStoc.Location = new System.Drawing.Point(9, 10);
            this.dgvStoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvStoc.Name = "dgvStoc";
            this.dgvStoc.SelectedIndex = 0;
            this.dgvStoc.Size = new System.Drawing.Size(910, 381);
            this.dgvStoc.TabIndex = 7;
            this.dgvStoc.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(902, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pagina principala";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelnrcereri);
            this.groupBox3.Controls.Add(this.labelnrb);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.labelnra);
            this.groupBox3.Controls.Add(this.labelnrf);
            this.groupBox3.Location = new System.Drawing.Point(19, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(231, 167);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // labelnrcereri
            // 
            this.labelnrcereri.AutoSize = true;
            this.labelnrcereri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnrcereri.Location = new System.Drawing.Point(4, 23);
            this.labelnrcereri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnrcereri.Name = "labelnrcereri";
            this.labelnrcereri.Size = new System.Drawing.Size(186, 17);
            this.labelnrcereri.TabIndex = 6;
            this.labelnrcereri.Text = "Cereri cumparare finalizate: ";
            // 
            // labelnrb
            // 
            this.labelnrb.AutoSize = true;
            this.labelnrb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnrb.Location = new System.Drawing.Point(4, 87);
            this.labelnrb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnrb.Name = "labelnrb";
            this.labelnrb.Size = new System.Drawing.Size(152, 17);
            this.labelnrb.TabIndex = 10;
            this.labelnrb.Text = "Beneficiari inregistrati: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cereri vanzare: -";
            // 
            // labelnra
            // 
            this.labelnra.AutoSize = true;
            this.labelnra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnra.Location = new System.Drawing.Point(4, 139);
            this.labelnra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnra.Name = "labelnra";
            this.labelnra.Size = new System.Drawing.Size(133, 17);
            this.labelnra.TabIndex = 8;
            this.labelnra.Text = "Angajati inregistrati:";
            // 
            // labelnrf
            // 
            this.labelnrf.AutoSize = true;
            this.labelnrf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnrf.Location = new System.Drawing.Point(4, 113);
            this.labelnrf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnrf.Name = "labelnrf";
            this.labelnrf.Size = new System.Drawing.Size(141, 17);
            this.labelnrf.TabIndex = 9;
            this.labelnrf.Text = "Furnizori inregistrati: ";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(19, 314);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(128, 29);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Deconectare";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.Controls.Add(this.dgvStocMed);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Size = new System.Drawing.Size(902, 355);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Stoc medicamente";
            // 
            // dgvStocMed
            // 
            this.dgvStocMed.AllowUserToAddRows = false;
            this.dgvStocMed.AllowUserToDeleteRows = false;
            this.dgvStocMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStocMed.Location = new System.Drawing.Point(92, 37);
            this.dgvStocMed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvStocMed.MultiSelect = false;
            this.dgvStocMed.Name = "dgvStocMed";
            this.dgvStocMed.RowTemplate.Height = 24;
            this.dgvStocMed.Size = new System.Drawing.Size(719, 245);
            this.dgvStocMed.TabIndex = 17;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.buttonRespinge);
            this.tabPage3.Controls.Add(this.buttonAproba);
            this.tabPage3.Controls.Add(this.dgvListaCerere);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.listBoxCereriFinalizate);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(902, 355);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cereri cumparare finalizate";
            // 
            // buttonRespinge
            // 
            this.buttonRespinge.Location = new System.Drawing.Point(547, 310);
            this.buttonRespinge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRespinge.Name = "buttonRespinge";
            this.buttonRespinge.Size = new System.Drawing.Size(163, 28);
            this.buttonRespinge.TabIndex = 18;
            this.buttonRespinge.Text = "Respinge cerere";
            this.buttonRespinge.UseVisualStyleBackColor = true;
            this.buttonRespinge.Click += new System.EventHandler(this.buttonRespinge_Click);
            // 
            // buttonAproba
            // 
            this.buttonAproba.Location = new System.Drawing.Point(714, 310);
            this.buttonAproba.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAproba.Name = "buttonAproba";
            this.buttonAproba.Size = new System.Drawing.Size(163, 28);
            this.buttonAproba.TabIndex = 17;
            this.buttonAproba.Text = "Aproba cerere";
            this.buttonAproba.UseVisualStyleBackColor = true;
            this.buttonAproba.Click += new System.EventHandler(this.buttonAproba_Click);
            // 
            // dgvListaCerere
            // 
            this.dgvListaCerere.AllowUserToAddRows = false;
            this.dgvListaCerere.AllowUserToDeleteRows = false;
            this.dgvListaCerere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCerere.Location = new System.Drawing.Point(207, 30);
            this.dgvListaCerere.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvListaCerere.MultiSelect = false;
            this.dgvListaCerere.Name = "dgvListaCerere";
            this.dgvListaCerere.RowTemplate.Height = 24;
            this.dgvListaCerere.Size = new System.Drawing.Size(670, 245);
            this.dgvListaCerere.TabIndex = 16;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(14, 246);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(163, 28);
            this.button5.TabIndex = 15;
            this.button5.Text = "Deschide";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cereri finalizate";
            // 
            // listBoxCereriFinalizate
            // 
            this.listBoxCereriFinalizate.FormattingEnabled = true;
            this.listBoxCereriFinalizate.Location = new System.Drawing.Point(14, 30);
            this.listBoxCereriFinalizate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxCereriFinalizate.Name = "listBoxCereriFinalizate";
            this.listBoxCereriFinalizate.Size = new System.Drawing.Size(164, 212);
            this.listBoxCereriFinalizate.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(902, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Creeaza cerere cumparare";
            // 
            // Angajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 399);
            this.Controls.Add(this.dgvStoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Angajat";
            this.Text = "Angajat";
            this.Load += new System.EventHandler(this.Angajat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.dgvStoc.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocMed)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCerere)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGenereaza;
        private System.Windows.Forms.Label labelCod;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSterge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxListaM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxFurnizor;
        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.Button buttonCautaFurnizor;
        private System.Windows.Forms.TextBox textBoxCautaFurnizor;
        private System.Windows.Forms.ListBox listBoxMedicament;
        private System.Windows.Forms.Button buttonCautaMedicament;
        private System.Windows.Forms.Button buttonTrimiteCerereC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCautaMedicament;
        private System.Windows.Forms.TextBox textBoxCantitate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl dgvStoc;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonRespinge;
        private System.Windows.Forms.Button buttonAproba;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxCereriFinalizate;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvStocMed;
        private System.Windows.Forms.DataGridView dgvListaCerere;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelnrcereri;
        private System.Windows.Forms.Label labelnrb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelnrf;
        private System.Windows.Forms.Label labelnra;
    }
}