namespace Dino
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ground = new System.Windows.Forms.PictureBox();
            this.cactus = new System.Windows.Forms.PictureBox();
            this.dinozaur = new System.Windows.Forms.PictureBox();
            this.labelScor = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.ground2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinozaur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Image = global::Dino.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-14, 380);
            this.ground.Margin = new System.Windows.Forms.Padding(2);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(900, 99);
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // cactus
            // 
            this.cactus.Image = global::Dino.Properties.Resources.cactus;
            this.cactus.Location = new System.Drawing.Point(900, 300);
            this.cactus.Margin = new System.Windows.Forms.Padding(2);
            this.cactus.Name = "cactus";
            this.cactus.Size = new System.Drawing.Size(50, 80);
            this.cactus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cactus.TabIndex = 0;
            this.cactus.TabStop = false;
            // 
            // dinozaur
            // 
            this.dinozaur.Image = global::Dino.Properties.Resources.gaina;
            this.dinozaur.Location = new System.Drawing.Point(105, 230);
            this.dinozaur.Margin = new System.Windows.Forms.Padding(2);
            this.dinozaur.Name = "dinozaur";
            this.dinozaur.Size = new System.Drawing.Size(130, 150);
            this.dinozaur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dinozaur.TabIndex = 1;
            this.dinozaur.TabStop = false;
            // 
            // labelScor
            // 
            this.labelScor.AutoSize = true;
            this.labelScor.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelScor.Location = new System.Drawing.Point(9, 7);
            this.labelScor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelScor.Name = "labelScor";
            this.labelScor.Size = new System.Drawing.Size(146, 34);
            this.labelScor.TabIndex = 2;
            this.labelScor.Text = "SCOR TOTAL: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 5;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // ground2
            // 
            this.ground2.Image = global::Dino.Properties.Resources.ground;
            this.ground2.Location = new System.Drawing.Point(886, 380);
            this.ground2.Margin = new System.Windows.Forms.Padding(2);
            this.ground2.Name = "ground2";
            this.ground2.Size = new System.Drawing.Size(900, 99);
            this.ground2.TabIndex = 3;
            this.ground2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(846, 473);
            this.Controls.Add(this.ground2);
            this.Controls.Add(this.labelScor);
            this.Controls.Add(this.dinozaur);
            this.Controls.Add(this.cactus);
            this.Controls.Add(this.ground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Dino";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownIsPressed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpIsPressed);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinozaur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox cactus;
        private System.Windows.Forms.PictureBox dinozaur;
        private System.Windows.Forms.Label labelScor;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox ground2;
    }
}

