﻿namespace Taschenrechner
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
            this.btnDivision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOperand1
            // 
            this.txtOperand1.Location = new System.Drawing.Point(66, 56);
            this.txtOperand1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(106, 27);
            this.txtOperand1.TabIndex = 0;
            // 
            // txtOperand2
            // 
            this.txtOperand2.Location = new System.Drawing.Point(247, 56);
            this.txtOperand2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(110, 27);
            this.txtOperand2.TabIndex = 1;
            // 
            // lblOperator
            // 
            this.lblOperator.Location = new System.Drawing.Point(182, 59);
            this.lblOperator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(64, 26);
            this.lblOperator.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(66, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ergebnis:";
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(66, 179);
            this.btnAddition.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(57, 56);
            this.btnAddition.TabIndex = 5;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // lblErgebnis
            // 
            this.lblErgebnis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblErgebnis.Location = new System.Drawing.Point(152, 121);
            this.lblErgebnis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErgebnis.Name = "lblErgebnis";
            this.lblErgebnis.Size = new System.Drawing.Size(166, 32);
            this.lblErgebnis.TabIndex = 6;
            // 
            // btnSubtraktion
            // 
            this.btnSubtraktion.Location = new System.Drawing.Point(138, 179);
            this.btnSubtraktion.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnSubtraktion.Name = "btnSubtraktion";
            this.btnSubtraktion.Size = new System.Drawing.Size(58, 56);
            this.btnSubtraktion.TabIndex = 7;
            this.btnSubtraktion.Text = "-";
            this.btnSubtraktion.UseVisualStyleBackColor = true;
            this.btnSubtraktion.Click += new System.EventHandler(this.btnSubtraktion_Click);
            // 
            // btnMittelwert
            // 
            this.btnMittelwert.Location = new System.Drawing.Point(66, 241);
            this.btnMittelwert.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnMittelwert.Name = "btnMittelwert";
            this.btnMittelwert.Size = new System.Drawing.Size(130, 54);
            this.btnMittelwert.TabIndex = 8;
            this.btnMittelwert.Text = "Mittelwert";
            this.btnMittelwert.UseVisualStyleBackColor = true;
            this.btnMittelwert.Click += new System.EventHandler(this.btnMittelwert_Click);
            // 
            // btnMaximum
            // 
            this.btnMaximum.Location = new System.Drawing.Point(203, 241);
            this.btnMaximum.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnMaximum.Name = "btnMaximum";
            this.btnMaximum.Size = new System.Drawing.Size(127, 54);
            this.btnMaximum.TabIndex = 9;
            this.btnMaximum.Text = "Maximum";
            this.btnMaximum.UseVisualStyleBackColor = true;
            this.btnMaximum.Click += new System.EventHandler(this.btnMaximum_Click);
            // 
            // btnPotenz
            // 
            this.btnPotenz.Location = new System.Drawing.Point(66, 304);
            this.btnPotenz.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnPotenz.Name = "btnPotenz";
            this.btnPotenz.Size = new System.Drawing.Size(130, 54);
            this.btnPotenz.TabIndex = 10;
            this.btnPotenz.Text = "Potenz";
            this.btnPotenz.UseVisualStyleBackColor = true;
            this.btnPotenz.Click += new System.EventHandler(this.btnPotenz_Click);
            // 
            // btnMultiplikation
            // 
            this.btnMultiplikation.Location = new System.Drawing.Point(209, 179);
            this.btnMultiplikation.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnMultiplikation.Name = "btnMultiplikation";
            this.btnMultiplikation.Size = new System.Drawing.Size(58, 56);
            this.btnMultiplikation.TabIndex = 12;
            this.btnMultiplikation.Text = "*";
            this.btnMultiplikation.UseVisualStyleBackColor = true;
            this.btnMultiplikation.Click += new System.EventHandler(this.btnMultiplikation_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(283, 179);
            this.btnDivision.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(58, 56);
            this.btnDivision.TabIndex = 13;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 476);
            this.Controls.Add(this.btnDivision);
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
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
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
        private System.Windows.Forms.Button btnDivision;
    }
}