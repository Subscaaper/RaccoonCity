﻿using System.ComponentModel;

namespace Ping_Pong
{
    partial class Gameover
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label2 = new System.Windows.Forms.Label();
            this.lblPunkte = new System.Windows.Forms.Label();
            this.lblErgebnisse = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnEintragen = new System.Windows.Forms.Button();
            this.btnzurück = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(49, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Punkte:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(131, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // lblPunkte
            // 
            this.lblPunkte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPunkte.Location = new System.Drawing.Point(49, 97);
            this.lblPunkte.Name = "lblPunkte";
            this.lblPunkte.Size = new System.Drawing.Size(67, 27);
            this.lblPunkte.TabIndex = 2;
            // 
            // lblErgebnisse
            // 
            this.lblErgebnisse.BackColor = System.Drawing.Color.Cyan;
            this.lblErgebnisse.Location = new System.Drawing.Point(49, 144);
            this.lblErgebnisse.Name = "lblErgebnisse";
            this.lblErgebnisse.Size = new System.Drawing.Size(198, 204);
            this.lblErgebnisse.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(116, 27);
            this.txtName.TabIndex = 4;
            // 
            // btnEintragen
            // 
            this.btnEintragen.Location = new System.Drawing.Point(306, 88);
            this.btnEintragen.Name = "btnEintragen";
            this.btnEintragen.Size = new System.Drawing.Size(103, 36);
            this.btnEintragen.TabIndex = 5;
            this.btnEintragen.Text = "Eintragen";
            this.btnEintragen.UseVisualStyleBackColor = true;
            this.btnEintragen.Click += new System.EventHandler(this.btnEintragen_Click);
            // 
            // btnzurück
            // 
            this.btnzurück.Location = new System.Drawing.Point(306, 312);
            this.btnzurück.Name = "btnzurück";
            this.btnzurück.Size = new System.Drawing.Size(103, 36);
            this.btnzurück.TabIndex = 6;
            this.btnzurück.Text = "Zurück";
            this.btnzurück.UseVisualStyleBackColor = true;
            this.btnzurück.Click += new System.EventHandler(this.btnzurück_Click);
            // 
            // frmGameover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(421, 410);
            this.Controls.Add(this.btnzurück);
            this.Controls.Add(this.btnEintragen);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblErgebnisse);
            this.Controls.Add(this.lblPunkte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGameover";
            this.Text = "Gameover";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPunkte;
        private System.Windows.Forms.Label lblErgebnisse;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnzurück;
        private System.Windows.Forms.Button btnEintragen;
    }
}