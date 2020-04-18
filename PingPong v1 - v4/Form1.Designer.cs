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
            this.picSchlägerrechts = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrSpiel = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtPunkte = new System.Windows.Forms.TextBox();
            this.vsbScrollbarrechts = new System.Windows.Forms.VScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpSteuerung = new System.Windows.Forms.GroupBox();
            this.rdbSchläger = new System.Windows.Forms.RadioButton();
            this.rdbBall = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize) (this.picBall)).BeginInit();
            this.pnlSpiel.SuspendLayout();
            this.grpSteuerung.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.Red;
            this.picBall.Location = new System.Drawing.Point(152, 94);
            this.picBall.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(31, 34);
            this.picBall.TabIndex = 0;
            this.picBall.TabStop = false;
            // 
            // pnlSpiel
            // 
            this.pnlSpiel.BackColor = System.Drawing.Color.Black;
            this.pnlSpiel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSpiel.Controls.Add(this.picSchlägerrechts);
            this.pnlSpiel.Controls.Add(this.picBall);
            this.pnlSpiel.Location = new System.Drawing.Point(26, 34);
            this.pnlSpiel.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pnlSpiel.Name = "pnlSpiel";
            this.pnlSpiel.Size = new System.Drawing.Size(500, 346);
            this.pnlSpiel.TabIndex = 1;
            // 
            // picSchlägerrechts
            // 
            this.picSchlägerrechts.BackColor = System.Drawing.Color.White;
            this.picSchlägerrechts.Location = new System.Drawing.Point(489, 21);
            this.picSchlägerrechts.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.picSchlägerrechts.Name = "picSchlägerrechts";
            this.picSchlägerrechts.Size = new System.Drawing.Size(10, 54);
            this.picSchlägerrechts.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(26, 472);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(134, 54);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Spiel Starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
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
            this.label1.Location = new System.Drawing.Point(26, 401);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Punkte :";
            // 
            // txtPunkte
            // 
            this.txtPunkte.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtPunkte.ForeColor = System.Drawing.Color.Purple;
            this.txtPunkte.Location = new System.Drawing.Point(130, 401);
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
            this.vsbScrollbarrechts.Size = new System.Drawing.Size(20, 346);
            this.vsbScrollbarrechts.TabIndex = 6;
            this.vsbScrollbarrechts.Scroll +=
                new System.Windows.Forms.ScrollEventHandler(this.vsbScrollbarrechts_Scroll);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(542, 416);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 116);
            this.label2.TabIndex = 7;
            this.label2.Text =
                "Steuerung\r\nW = horizontale Flugrichtung\r\nS = vertikale Flugrichtung\r\nP = Spiel Pa" +
                "usieren\r\nF = Spiel Fortfahren\r\n\r\n\r\n";
            // 
            // btnUp
            // 
            this.btnUp.ForeColor = System.Drawing.Color.Blue;
            this.btnUp.Location = new System.Drawing.Point(638, 149);
            this.btnUp.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(38, 40);
            this.btnUp.TabIndex = 8;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(600, 188);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(40, 36);
            this.btnLeft.TabIndex = 9;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(638, 221);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(38, 39);
            this.btnDown.TabIndex = 10;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(675, 188);
            this.btnRight.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(34, 36);
            this.btnRight.TabIndex = 11;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 472);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 54);
            this.button1.TabIndex = 12;
            this.button1.Text = "Beenden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpSteuerung
            // 
            this.grpSteuerung.Controls.Add(this.rdbSchläger);
            this.grpSteuerung.Controls.Add(this.rdbBall);
            this.grpSteuerung.Location = new System.Drawing.Point(590, 291);
            this.grpSteuerung.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.grpSteuerung.Name = "grpSteuerung";
            this.grpSteuerung.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.grpSteuerung.Size = new System.Drawing.Size(162, 119);
            this.grpSteuerung.TabIndex = 13;
            this.grpSteuerung.TabStop = false;
            this.grpSteuerung.Text = "Wahl der Steuerung";
            // 
            // rdbSchläger
            // 
            this.rdbSchläger.Location = new System.Drawing.Point(14, 69);
            this.rdbSchläger.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.rdbSchläger.Name = "rdbSchläger";
            this.rdbSchläger.Size = new System.Drawing.Size(146, 24);
            this.rdbSchläger.TabIndex = 14;
            this.rdbSchläger.Text = "Schlägersteuerung";
            this.rdbSchläger.UseVisualStyleBackColor = true;
            this.rdbSchläger.CheckedChanged += new System.EventHandler(this.rdbSchläger_CheckedChanged);
            this.rdbSchläger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdbSchläger_KeyDown);
            // 
            // rdbBall
            // 
            this.rdbBall.Location = new System.Drawing.Point(14, 29);
            this.rdbBall.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.rdbBall.Name = "rdbBall";
            this.rdbBall.Size = new System.Drawing.Size(146, 24);
            this.rdbBall.TabIndex = 0;
            this.rdbBall.Text = "Ballsteuerung";
            this.rdbBall.UseVisualStyleBackColor = true;
            this.rdbBall.CheckedChanged += new System.EventHandler(this.rdbBall_CheckedChanged);
            this.rdbBall.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdbBall_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(818, 571);
            this.Controls.Add(this.grpSteuerung);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vsbScrollbarrechts);
            this.Controls.Add(this.txtPunkte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlSpiel);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.picBall)).EndInit();
            this.pnlSpiel.ResumeLayout(false);
            this.grpSteuerung.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.RadioButton rdbSchläger;
        private System.Windows.Forms.RadioButton rdbBall;
        private System.Windows.Forms.GroupBox grpSteuerung;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.VScrollBar vsbScrollbarrechts;
        private System.Windows.Forms.TextBox txtPunkte;
        private System.Windows.Forms.Panel picSchlägerrechts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrSpiel;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Panel pnlSpiel;
    }
}