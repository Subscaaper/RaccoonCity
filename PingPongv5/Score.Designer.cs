﻿using System.ComponentModel;
using System.Windows.Forms;

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
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPunktePlayer = new System.Windows.Forms.Label();
            this.lblPunkteCPU = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.txtCPU.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtCPU.Location = new System.Drawing.Point(50, 108);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(56, 33);
            this.txtCPU.TabIndex = 0;
            this.txtCPU.Text = "CPU";
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox1.Location = new System.Drawing.Point(199, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 33);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Player 1";
            this.lblPunktePlayer.BackColor = System.Drawing.Color.DarkGray;
            this.lblPunktePlayer.Location = new System.Drawing.Point(289, 108);
            this.lblPunktePlayer.Name = "lblPunktePlayer";
            this.lblPunktePlayer.Size = new System.Drawing.Size(68, 33);
            this.lblPunktePlayer.TabIndex = 2;
            this.lblPunkteCPU.BackColor = System.Drawing.Color.Silver;
            this.lblPunkteCPU.Location = new System.Drawing.Point(112, 108);
            this.lblPunkteCPU.Name = "lblPunkteCPU";
            this.lblPunkteCPU.Size = new System.Drawing.Size(64, 33);
            this.lblPunkteCPU.TabIndex = 3;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(52, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 90);
            this.label1.TabIndex = 4;
            this.label1.Text = "Congratulations !! :)\r\n\r\nAnother  Try ? :P";
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.Location = new System.Drawing.Point(50, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Return to  Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button2.Location = new System.Drawing.Point(226, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Quit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(386, 314);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPunkteCPU);
            this.Controls.Add(this.lblPunktePlayer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtCPU);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Gameover";
            this.Text = "Gameover";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPunkteCPU;
        private System.Windows.Forms.Label lblPunktePlayer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}