namespace AB_03_Events
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
            this.txtausgabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtausgabe
            // 
            this.txtausgabe.BackColor = System.Drawing.Color.Gray;
            this.txtausgabe.Enabled = false;
            this.txtausgabe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtausgabe.Location = new System.Drawing.Point(105, 79);
            this.txtausgabe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtausgabe.Multiline = true;
            this.txtausgabe.Name = "txtausgabe";
            this.txtausgabe.Size = new System.Drawing.Size(496, 406);
            this.txtausgabe.TabIndex = 0;
            this.txtausgabe.Click += new System.EventHandler(this.txtausgabe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.txtausgabe);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtausgabe;
    }
}