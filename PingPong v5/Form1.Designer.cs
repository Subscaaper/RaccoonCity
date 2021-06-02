using System.ComponentModel;
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
            this.picLine = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.Panel();
            this.picCPU = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrSpiel = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlayerPoints = new System.Windows.Forms.TextBox();
            this.vsbScrollbarrechts = new System.Windows.Forms.VScrollBar();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCpuPoints = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSetBall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.picBall)).BeginInit();
            this.pnlSpiel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picLine)).BeginInit();
            this.SuspendLayout();
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.Red;
            this.picBall.Location = new System.Drawing.Point(45, 157);
            this.picBall.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(40, 40);
            this.picBall.TabIndex = 0;
            this.picBall.TabStop = false;
            // 
            // pnlSpiel
            // 
            this.pnlSpiel.BackColor = System.Drawing.Color.Black;
            this.pnlSpiel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSpiel.Controls.Add(this.picLine);
            this.pnlSpiel.Controls.Add(this.picPlayer);
            this.pnlSpiel.Controls.Add(this.picCPU);
            this.pnlSpiel.Controls.Add(this.picBall);
            this.pnlSpiel.Location = new System.Drawing.Point(37, 42);
            this.pnlSpiel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlSpiel.Name = "pnlSpiel";
            this.pnlSpiel.Size = new System.Drawing.Size(652, 330);
            this.pnlSpiel.TabIndex = 1;
            // 
            // picLine
            // 
            this.picLine.BackColor = System.Drawing.Color.White;
            this.picLine.Location = new System.Drawing.Point(317, -1);
            this.picLine.Name = "picLine";
            this.picLine.Size = new System.Drawing.Size(10, 328);
            this.picLine.TabIndex = 2;
            this.picLine.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.White;
            this.picPlayer.Location = new System.Drawing.Point(638, 119);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(10, 60);
            this.picPlayer.TabIndex = 1;
            // 
            // picCPU
            // 
            this.picCPU.BackColor = System.Drawing.Color.White;
            this.picCPU.Location = new System.Drawing.Point(2, 267);
            this.picCPU.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picCPU.Name = "picCPU";
            this.picCPU.Size = new System.Drawing.Size(10, 60);
            this.picCPU.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(37, 384);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(117, 40);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Spiel Starten / Restart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnStart_KeyDown);
            // 
            // tmrSpiel
            // 
            this.tmrSpiel.Interval = 20;
            this.tmrSpiel.Tick += new System.EventHandler(this.tmrSpiel_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(454, 391);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player 1";
            // 
            // txtPlayerPoints
            // 
            this.txtPlayerPoints.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtPlayerPoints.ForeColor = System.Drawing.Color.Purple;
            this.txtPlayerPoints.Location = new System.Drawing.Point(541, 391);
            this.txtPlayerPoints.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPlayerPoints.Name = "txtPlayerPoints";
            this.txtPlayerPoints.ReadOnly = true;
            this.txtPlayerPoints.Size = new System.Drawing.Size(63, 33);
            this.txtPlayerPoints.TabIndex = 5;
            this.txtPlayerPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vsbScrollbarrechts
            // 
            this.vsbScrollbarrechts.LargeChange = 40;
            this.vsbScrollbarrechts.Location = new System.Drawing.Point(694, 42);
            this.vsbScrollbarrechts.Name = "vsbScrollbarrechts";
            this.vsbScrollbarrechts.Size = new System.Drawing.Size(20, 313);
            this.vsbScrollbarrechts.TabIndex = 6;
            this.vsbScrollbarrechts.Scroll +=
                new System.Windows.Forms.ScrollEventHandler(this.vsbScrollbarrechts_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 384);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Beenden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCpuPoints
            // 
            this.txtCpuPoints.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtCpuPoints.ForeColor = System.Drawing.Color.Purple;
            this.txtCpuPoints.Location = new System.Drawing.Point(232, 391);
            this.txtCpuPoints.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCpuPoints.Name = "txtCpuPoints";
            this.txtCpuPoints.ReadOnly = true;
            this.txtCpuPoints.Size = new System.Drawing.Size(68, 33);
            this.txtCpuPoints.TabIndex = 14;
            this.txtCpuPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(169, 393);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "CPU";
            // 
            // btnSetBall
            // 
            this.btnSetBall.Location = new System.Drawing.Point(330, 389);
            this.btnSetBall.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSetBall.Name = "btnSetBall";
            this.btnSetBall.Size = new System.Drawing.Size(106, 35);
            this.btnSetBall.TabIndex = 15;
            this.btnSetBall.Text = "Set Ball";
            this.btnSetBall.UseVisualStyleBackColor = true;
            this.btnSetBall.Visible = false;
            this.btnSetBall.Click += new System.EventHandler(this.btnSetBall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(769, 465);
            this.Controls.Add(this.btnSetBall);
            this.Controls.Add(this.txtCpuPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vsbScrollbarrechts);
            this.Controls.Add(this.txtPlayerPoints);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlSpiel);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.picBall)).EndInit();
            this.pnlSpiel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.VScrollBar vsbScrollbarrechts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrSpiel;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Panel pnlSpiel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCpuPoints;
        private System.Windows.Forms.TextBox txtPlayerPoints;
        private System.Windows.Forms.Button btnSetBall;
        private System.Windows.Forms.Panel picCPU;
        private System.Windows.Forms.Panel picPlayer;
        private System.Windows.Forms.PictureBox picLine;
    }
}