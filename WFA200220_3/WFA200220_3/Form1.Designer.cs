namespace WFA200220_3
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
            this.gomb = new System.Windows.Forms.Button();
            this.cimke = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gomb
            // 
            this.gomb.BackColor = System.Drawing.Color.Khaki;
            this.gomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gomb.Location = new System.Drawing.Point(12, 80);
            this.gomb.Name = "gomb";
            this.gomb.Size = new System.Drawing.Size(410, 200);
            this.gomb.TabIndex = 0;
            this.gomb.Text = "Fight Club";
            this.gomb.UseVisualStyleBackColor = false;
            this.gomb.Click += new System.EventHandler(this.button1_Click);
            this.gomb.MouseEnter += new System.EventHandler(this.gomb_MouseEnter);
            this.gomb.MouseLeave += new System.EventHandler(this.gomb_MouseLeave);
            this.gomb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gomb_MouseMove);
            // 
            // cimke
            // 
            this.cimke.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cimke.Location = new System.Drawing.Point(12, 9);
            this.cimke.Name = "cimke";
            this.cimke.Size = new System.Drawing.Size(410, 68);
            this.cimke.TabIndex = 1;
            this.cimke.Text = "#####";
            this.cimke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 292);
            this.Controls.Add(this.cimke);
            this.Controls.Add(this.gomb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gomb;
        private System.Windows.Forms.Label cimke;
    }
}

