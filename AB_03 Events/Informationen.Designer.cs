using System.ComponentModel;

namespace AB_03_Events
{
    partial class Informationen
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
            this.btnschliessen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnschliessen
            // 
            this.btnschliessen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnschliessen.Location = new System.Drawing.Point(328, 421);
            this.btnschliessen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnschliessen.Name = "btnschliessen";
            this.btnschliessen.Size = new System.Drawing.Size(215, 78);
            this.btnschliessen.TabIndex = 0;
            this.btnschliessen.Text = "Schliessen";
            this.btnschliessen.UseVisualStyleBackColor = true;
            this.btnschliessen.Click += new System.EventHandler(this.btnschliessen_Click);
            // 
            // Informationen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 552);
            this.Controls.Add(this.btnschliessen);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Informationen";
            this.Text = "Informationen";
            this.Resize += new System.EventHandler(this.Informationen_Resize);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnschliessen;
    }
}