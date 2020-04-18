﻿using System.ComponentModel;
using System.Windows.Forms;

namespace Ping_Pong
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.pnlSpiel = new System.Windows.Forms.Panel();
            this.picSchlägerrechts = new System.Windows.Forms.Panel();
            this.picCPU = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrSpiel = new System.Windows.Forms.Timer(this.components);
            this.label = new System.Windows.Forms.Label();
            this.txtPunkte = new System.Windows.Forms.TextBox();
            this.vsbScrollbarrechts = new System.Windows.Forms.VScrollBar();
            this.btnbeenden = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPunktePlayer = new System.Windows.Forms.TextBox();
            this.btnweiter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.picBall)).BeginInit();
            this.pnlSpiel.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.Red;
            this.picBall.Location = new System.Drawing.Point(472, 228);
            this.picBall.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(33, 34);
            this.picBall.TabIndex = 0;
            this.picBall.TabStop = false;
            // 
            // pnlSpiel
            // 
            this.pnlSpiel.BackColor = System.Drawing.Color.Black;
            this.pnlSpiel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSpiel.Controls.Add(this.picSchlägerrechts);
            this.pnlSpiel.Controls.Add(this.picCPU);
            this.pnlSpiel.Controls.Add(this.picBall);
            this.pnlSpiel.Location = new System.Drawing.Point(0, 0);
            this.pnlSpiel.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pnlSpiel.Name = "pnlSpiel";
            this.pnlSpiel.Size = new System.Drawing.Size(515, 378);
            this.pnlSpiel.TabIndex = 1;
            // 
            // picSchlägerrechts
            // 
            this.picSchlägerrechts.BackColor = System.Drawing.Color.White;
            this.picSchlägerrechts.Location = new System.Drawing.Point(505, 128);
            this.picSchlägerrechts.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.picSchlägerrechts.Name = "picSchlägerrechts";
            this.picSchlägerrechts.Size = new System.Drawing.Size(10, 54);
            this.picSchlägerrechts.TabIndex = 1;
            // 
            // picCPU
            // 
            this.picCPU.BackColor = System.Drawing.Color.White;
            this.picCPU.Location = new System.Drawing.Point(2, 128);
            this.picCPU.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.picCPU.Name = "picCPU";
            this.picCPU.Size = new System.Drawing.Size(10, 54);
            this.picCPU.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(11, 472);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(134, 54);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Spiel Starten\r\n/ Restart\r\n";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrSpiel
            // 
            this.tmrSpiel.Interval = 20;
            this.tmrSpiel.Tick += new System.EventHandler(this.tmrSpiel_Tick);
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label.Location = new System.Drawing.Point(11, 399);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(95, 39);
            this.label.TabIndex = 4;
            this.label.Text = "CPU";
            // 
            // txtPunkte
            // 
            this.txtPunkte.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtPunkte.ForeColor = System.Drawing.Color.Purple;
            this.txtPunkte.Location = new System.Drawing.Point(77, 396);
            this.txtPunkte.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtPunkte.Name = "txtPunkte";
            this.txtPunkte.Size = new System.Drawing.Size(94, 39);
            this.txtPunkte.TabIndex = 5;
            this.txtPunkte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vsbScrollbarrechts
            // 
            this.vsbScrollbarrechts.LargeChange = 15;
            this.vsbScrollbarrechts.Location = new System.Drawing.Point(529, 34);
            this.vsbScrollbarrechts.Name = "vsbScrollbarrechts";
            this.vsbScrollbarrechts.Size = new System.Drawing.Size(20, 348);
            this.vsbScrollbarrechts.TabIndex = 6;
            this.vsbScrollbarrechts.Scroll +=
                new System.Windows.Forms.ScrollEventHandler(this.vsbScrollbarrechts_Scroll);
            // 
            // btnbeenden
            // 
            this.btnbeenden.Location = new System.Drawing.Point(377, 472);
            this.btnbeenden.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnbeenden.Name = "btnbeenden";
            this.btnbeenden.Size = new System.Drawing.Size(135, 54);
            this.btnbeenden.TabIndex = 12;
            this.btnbeenden.Text = "Beenden";
            this.btnbeenden.UseVisualStyleBackColor = true;
            this.btnbeenden.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(311, 396);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 39);
            this.label3.TabIndex = 14;
            this.label3.Text = "Player 1";
            // 
            // txtPunktePlayer
            // 
            this.txtPunktePlayer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtPunktePlayer.ForeColor = System.Drawing.Color.Purple;
            this.txtPunktePlayer.Location = new System.Drawing.Point(418, 396);
            this.txtPunktePlayer.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtPunktePlayer.Name = "txtPunktePlayer";
            this.txtPunktePlayer.Size = new System.Drawing.Size(94, 39);
            this.txtPunktePlayer.TabIndex = 15;
            this.txtPunktePlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnweiter
            // 
            this.btnweiter.Location = new System.Drawing.Point(180, 472);
            this.btnweiter.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnweiter.Name = "btnweiter";
            this.btnweiter.Size = new System.Drawing.Size(134, 54);
            this.btnweiter.TabIndex = 16;
            this.btnweiter.Text = "Weiter";
            this.btnweiter.UseVisualStyleBackColor = true;
            this.btnweiter.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(569, 590);
            this.Controls.Add(this.btnweiter);
            this.Controls.Add(this.txtPunktePlayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnbeenden);
            this.Controls.Add(this.vsbScrollbarrechts);
            this.Controls.Add(this.txtPunkte);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlSpiel);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize) (this.picBall)).EndInit();
            this.pnlSpiel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.VScrollBar vsbScrollbarrechts;
        private System.Windows.Forms.TextBox txtPunkte;
        private System.Windows.Forms.Panel picSchlägerrechts;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrSpiel;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Panel pnlSpiel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel picCPU;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtPunktePlayer;
        private System.Windows.Forms.Button btnweiter;
        private System.Windows.Forms.Button btnbeenden;
    }
}