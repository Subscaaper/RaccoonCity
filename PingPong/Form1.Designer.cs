namespace Ping_Pong
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
            this.btnW = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
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
            this.picBall.Location = new System.Drawing.Point(166, 114);
            this.picBall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.pnlSpiel.Location = new System.Drawing.Point(27, 34);
            this.pnlSpiel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSpiel.Name = "pnlSpiel";
            this.pnlSpiel.Size = new System.Drawing.Size(498, 346);
            this.pnlSpiel.TabIndex = 1;
            // 
            // picSchlägerrechts
            // 
            this.picSchlägerrechts.BackColor = System.Drawing.Color.White;
            this.picSchlägerrechts.Location = new System.Drawing.Point(486, 94);
            this.picSchlägerrechts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picSchlägerrechts.Name = "picSchlägerrechts";
            this.picSchlägerrechts.Size = new System.Drawing.Size(11, 54);
            this.picSchlägerrechts.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(27, 472);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.label1.Location = new System.Drawing.Point(27, 402);
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
            this.txtPunkte.Location = new System.Drawing.Point(130, 402);
            this.txtPunkte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPunkte.Name = "txtPunkte";
            this.txtPunkte.Size = new System.Drawing.Size(95, 39);
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
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(529, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 116);
            this.label2.TabIndex = 7;
            this.label2.Text =
                "Steuerung\r\nW = horizontale Flugrichtung\r\nA = vertikale Flugrichtung\r\nP = Spiel Pa" +
                "usieren\r\nF = Spiel Fortfahren\r\n\r\n\r\n";
            // 
            // btnW
            // 
            this.btnW.ForeColor = System.Drawing.Color.Blue;
            this.btnW.Location = new System.Drawing.Point(648, 199);
            this.btnW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(30, 40);
            this.btnW.TabIndex = 8;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = true;
            // 
            // btnP
            // 
            this.btnP.Location = new System.Drawing.Point(610, 241);
            this.btnP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(30, 36);
            this.btnP.TabIndex = 9;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = true;
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(648, 276);
            this.btnS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(30, 38);
            this.btnS.TabIndex = 10;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            // 
            // btnF
            // 
            this.btnF.Location = new System.Drawing.Point(686, 241);
            this.btnF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(30, 36);
            this.btnF.TabIndex = 11;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 472);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.grpSteuerung.Location = new System.Drawing.Point(576, 344);
            this.grpSteuerung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSteuerung.Name = "grpSteuerung";
            this.grpSteuerung.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSteuerung.Size = new System.Drawing.Size(162, 119);
            this.grpSteuerung.TabIndex = 13;
            this.grpSteuerung.TabStop = false;
            this.grpSteuerung.Text = "Wahl der Steuerung";
            // 
            // rdbSchläger
            // 
            this.rdbSchläger.Location = new System.Drawing.Point(14, 69);
            this.rdbSchläger.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbSchläger.Name = "rdbSchläger";
            this.rdbSchläger.Size = new System.Drawing.Size(146, 24);
            this.rdbSchläger.TabIndex = 14;
            this.rdbSchläger.TabStop = true;
            this.rdbSchläger.Text = "Schlägersteuerung";
            this.rdbSchläger.UseVisualStyleBackColor = true;
            this.rdbSchläger.CheckedChanged += new System.EventHandler(this.rdbSchläger_CheckedChanged);
            this.rdbSchläger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdbSchläger_KeyDown);
            // 
            // rdbBall
            // 
            this.rdbBall.Location = new System.Drawing.Point(14, 29);
            this.rdbBall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbBall.Name = "rdbBall";
            this.rdbBall.Size = new System.Drawing.Size(147, 24);
            this.rdbBall.TabIndex = 0;
            this.rdbBall.TabStop = true;
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
            this.ClientSize = new System.Drawing.Size(963, 751);
            this.Controls.Add(this.grpSteuerung);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vsbScrollbarrechts);
            this.Controls.Add(this.txtPunkte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlSpiel);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.picBall)).EndInit();
            this.pnlSpiel.ResumeLayout(false);
            this.grpSteuerung.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlSpiel;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Timer tmrSpiel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel picSchlägerrechts;
        private System.Windows.Forms.TextBox txtPunkte;
        private System.Windows.Forms.VScrollBar vsbScrollbarrechts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpSteuerung;
        private System.Windows.Forms.RadioButton rdbBall;
        private System.Windows.Forms.RadioButton rdbSchläger;
    }
}