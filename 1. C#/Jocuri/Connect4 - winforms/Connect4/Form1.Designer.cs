namespace Connect4
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
            this.table = new System.Windows.Forms.PictureBox();
            this.redball = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelWinner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redball)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.Transparent;
            this.table.Image = global::Connect4.Properties.Resources.front;
            this.table.Location = new System.Drawing.Point(70, 130);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(430, 370);
            this.table.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.table.TabIndex = 1;
            this.table.TabStop = false;
            this.table.Tag = "1";
            // 
            // redball
            // 
            this.redball.Image = global::Connect4.Properties.Resources.red_ball;
            this.redball.Location = new System.Drawing.Point(80, 70);
            this.redball.Name = "redball";
            this.redball.Size = new System.Drawing.Size(50, 50);
            this.redball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redball.TabIndex = 2;
            this.redball.TabStop = false;
            this.redball.Tag = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(192, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "CONNECT 4";
            // 
            // labelWinner
            // 
            this.labelWinner.AutoSize = true;
            this.labelWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWinner.ForeColor = System.Drawing.Color.White;
            this.labelWinner.Location = new System.Drawing.Point(65, 24);
            this.labelWinner.Name = "labelWinner";
            this.labelWinner.Size = new System.Drawing.Size(125, 25);
            this.labelWinner.TabIndex = 4;
            this.labelWinner.Text = "RED WINS!";
            this.labelWinner.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(59)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(579, 591);
            this.Controls.Add(this.labelWinner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.redball);
            this.Controls.Add(this.table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Connect 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressed);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox table;
        private System.Windows.Forms.PictureBox redball;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelWinner;

    }
}

