using System.ComponentModel;
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
            this.btnretry = new System.Windows.Forms.Button();
            this.lblPunkteCPU = new System.Windows.Forms.Label();
            this.lblPunktePlayer = new System.Windows.Forms.Label();
            this.txtNachricht = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnretry
            // 
            this.btnretry.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnretry.Location = new System.Drawing.Point(91, 202);
            this.btnretry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnretry.Name = "btnretry";
            this.btnretry.Size = new System.Drawing.Size(193, 64);
            this.btnretry.TabIndex = 0;
            this.btnretry.Text = "Game on !";
            this.btnretry.UseVisualStyleBackColor = true;
            this.btnretry.Click += new System.EventHandler(this.btnretry_Click);
            // 
            // lblPunkteCPU
            // 
            this.lblPunkteCPU.BackColor = System.Drawing.Color.White;
            this.lblPunkteCPU.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPunkteCPU.Location = new System.Drawing.Point(386, 140);
            this.lblPunkteCPU.Name = "lblPunkteCPU";
            this.lblPunkteCPU.Size = new System.Drawing.Size(193, 60);
            this.lblPunkteCPU.TabIndex = 2;
            // 
            // lblPunktePlayer
            // 
            this.lblPunktePlayer.BackColor = System.Drawing.Color.White;
            this.lblPunktePlayer.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPunktePlayer.Location = new System.Drawing.Point(90, 140);
            this.lblPunktePlayer.Name = "lblPunktePlayer";
            this.lblPunktePlayer.Size = new System.Drawing.Size(194, 60);
            this.lblPunktePlayer.TabIndex = 3;
            // 
            // txtNachricht
            // 
            this.txtNachricht.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNachricht.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtNachricht.ForeColor = System.Drawing.Color.Red;
            this.txtNachricht.Location = new System.Drawing.Point(88, 55);
            this.txtNachricht.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNachricht.Name = "txtNachricht";
            this.txtNachricht.Size = new System.Drawing.Size(491, 52);
            this.txtNachricht.TabIndex = 4;
            this.txtNachricht.Text = "Another Try ? :)";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.Location = new System.Drawing.Point(386, 202);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 64);
            this.button1.TabIndex = 5;
            this.button1.Text = "Quit ?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gameover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 365);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNachricht);
            this.Controls.Add(this.lblPunktePlayer);
            this.Controls.Add(this.lblPunkteCPU);
            this.Controls.Add(this.btnretry);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Gameover";
            this.Text = "Score";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNachricht;
        private System.Windows.Forms.Button btnretry;
        private System.Windows.Forms.Label lblPunktePlayer;
        private System.Windows.Forms.Label lblPunkteCPU;
        private System.Windows.Forms.Button button1;
    }
}