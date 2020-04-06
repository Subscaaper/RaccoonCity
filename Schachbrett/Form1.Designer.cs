namespace Schachbrett
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
            this.nudAnzahlZahlen = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnlSchachbrett = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize) (this.nudAnzahlZahlen)).BeginInit();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudAnzahlZahlen
            // 
            this.nudAnzahlZahlen.Increment = new decimal(new int[] {2, 0, 0, 0});
            this.nudAnzahlZahlen.Location = new System.Drawing.Point(30, 31);
            this.nudAnzahlZahlen.Maximum = new decimal(new int[] {30, 0, 0, 0});
            this.nudAnzahlZahlen.Name = "nudAnzahlZahlen";
            this.nudAnzahlZahlen.Size = new System.Drawing.Size(52, 27);
            this.nudAnzahlZahlen.TabIndex = 0;
          
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(117, 29);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(163, 29);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.Black;
            this.pnl1.Controls.Add(this.nudAnzahlZahlen);
            this.pnl1.Controls.Add(this.btnStart);
            this.pnl1.Location = new System.Drawing.Point(49, 42);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(492, 90);
            this.pnl1.TabIndex = 2;
            // 
            // pnlSchachbrett
            // 
            this.pnlSchachbrett.BackColor = System.Drawing.Color.White;
            this.pnlSchachbrett.Location = new System.Drawing.Point(49, 149);
            this.pnlSchachbrett.Name = "pnlSchachbrett";
            this.pnlSchachbrett.Size = new System.Drawing.Size(491, 379);
            this.pnlSchachbrett.TabIndex = 3;
            // 
            // frmSchachbrett
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 562);
            this.Controls.Add(this.pnlSchachbrett);
            this.Controls.Add(this.pnl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSchachbrett";
            this.Text = "Schachbrett";
            ((System.ComponentModel.ISupportInitialize) (this.nudAnzahlZahlen)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnlSchachbrett;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown nudAnzahlZahlen;
    }
}