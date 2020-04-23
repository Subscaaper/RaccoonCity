namespace Taschenrechner
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
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddition = new System.Windows.Forms.Button();
            this.lblErgebnis = new System.Windows.Forms.Label();
            this.btnSubtraktion = new System.Windows.Forms.Button();
            this.btnMittelwert = new System.Windows.Forms.Button();
            this.btnMaximum = new System.Windows.Forms.Button();
            this.btnPotenz = new System.Windows.Forms.Button();
            this.btnMultiplikation = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.txtOperand1.Location = new System.Drawing.Point(58, 42);
            this.txtOperand1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(93, 23);
            this.txtOperand1.TabIndex = 0;
            this.txtOperand2.Location = new System.Drawing.Point(216, 42);
            this.txtOperand2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(97, 23);
            this.txtOperand2.TabIndex = 1;
            this.lblOperator.Location = new System.Drawing.Point(159, 44);
            this.lblOperator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(56, 20);
            this.lblOperator.TabIndex = 2;
            this.label2.Location = new System.Drawing.Point(58, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ergebnis:";
            this.btnAddition.Location = new System.Drawing.Point(58, 134);
            this.btnAddition.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(50, 42);
            this.btnAddition.TabIndex = 5;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            this.lblErgebnis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblErgebnis.Location = new System.Drawing.Point(133, 91);
            this.lblErgebnis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErgebnis.Name = "lblErgebnis";
            this.lblErgebnis.Size = new System.Drawing.Size(145, 24);
            this.lblErgebnis.TabIndex = 6;
            this.btnSubtraktion.Location = new System.Drawing.Point(121, 134);
            this.btnSubtraktion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSubtraktion.Name = "btnSubtraktion";
            this.btnSubtraktion.Size = new System.Drawing.Size(51, 42);
            this.btnSubtraktion.TabIndex = 7;
            this.btnSubtraktion.Text = "-";
            this.btnSubtraktion.UseVisualStyleBackColor = true;
            this.btnSubtraktion.Click += new System.EventHandler(this.btnSubtraktion_Click);
            this.btnMittelwert.Location = new System.Drawing.Point(58, 181);
            this.btnMittelwert.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMittelwert.Name = "btnMittelwert";
            this.btnMittelwert.Size = new System.Drawing.Size(114, 40);
            this.btnMittelwert.TabIndex = 8;
            this.btnMittelwert.Text = "Mittelwert";
            this.btnMittelwert.UseVisualStyleBackColor = true;
            this.btnMittelwert.Click += new System.EventHandler(this.btnMittelwert_Click);
            this.btnMaximum.Location = new System.Drawing.Point(178, 181);
            this.btnMaximum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMaximum.Name = "btnMaximum";
            this.btnMaximum.Size = new System.Drawing.Size(111, 40);
            this.btnMaximum.TabIndex = 9;
            this.btnMaximum.Text = "Maximum";
            this.btnMaximum.UseVisualStyleBackColor = true;
            this.btnMaximum.Click += new System.EventHandler(this.btnMaximum_Click);
            this.btnPotenz.Location = new System.Drawing.Point(58, 228);
            this.btnPotenz.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPotenz.Name = "btnPotenz";
            this.btnPotenz.Size = new System.Drawing.Size(114, 40);
            this.btnPotenz.TabIndex = 10;
            this.btnPotenz.Text = "Potenz";
            this.btnPotenz.UseVisualStyleBackColor = true;
            this.btnPotenz.Click += new System.EventHandler(this.btnPotenz_Click);
            this.btnMultiplikation.Location = new System.Drawing.Point(183, 134);
            this.btnMultiplikation.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnMultiplikation.Name = "btnMultiplikation";
            this.btnMultiplikation.Size = new System.Drawing.Size(51, 42);
            this.btnMultiplikation.TabIndex = 12;
            this.btnMultiplikation.Text = "*";
            this.btnMultiplikation.UseVisualStyleBackColor = true;
            this.btnMultiplikation.Click += new System.EventHandler(this.btnMultiplikation_Click);
            this.button1.Location = new System.Drawing.Point(248, 134);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "/";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 357);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMultiplikation);
            this.Controls.Add(this.btnPotenz);
            this.Controls.Add(this.btnMaximum);
            this.Controls.Add(this.btnMittelwert);
            this.Controls.Add(this.btnSubtraktion);
            this.Controls.Add(this.lblErgebnis);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.txtOperand1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.TextBox txtOperand2;
        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Label lblErgebnis;
        private System.Windows.Forms.Button btnPotenz;
        private System.Windows.Forms.Button btnMaximum;
        private System.Windows.Forms.Button btnMittelwert;
        private System.Windows.Forms.Button btnSubtraktion;
        private System.Windows.Forms.Button btnMultiplikation;
        private System.Windows.Forms.Button button1;
    }
}