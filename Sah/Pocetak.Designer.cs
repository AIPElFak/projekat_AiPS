namespace Sah
{
    partial class Pocetak
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
            this.kreirajIgru = new System.Windows.Forms.Button();
            this.poveziSe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kreirajIgru
            // 
            this.kreirajIgru.Location = new System.Drawing.Point(73, 62);
            this.kreirajIgru.Name = "kreirajIgru";
            this.kreirajIgru.Size = new System.Drawing.Size(75, 23);
            this.kreirajIgru.TabIndex = 0;
            this.kreirajIgru.Text = "Kreiraj igru";
            this.kreirajIgru.UseVisualStyleBackColor = true;
            this.kreirajIgru.Click += new System.EventHandler(this.kreirajIgru_Click);
            // 
            // poveziSe
            // 
            this.poveziSe.Location = new System.Drawing.Point(73, 124);
            this.poveziSe.Name = "poveziSe";
            this.poveziSe.Size = new System.Drawing.Size(75, 23);
            this.poveziSe.TabIndex = 1;
            this.poveziSe.Text = "Povezi se";
            this.poveziSe.UseVisualStyleBackColor = true;
            this.poveziSe.Click += new System.EventHandler(this.poveziSe_Click);
            // 
            // Pocetak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.poveziSe);
            this.Controls.Add(this.kreirajIgru);
            this.Name = "Pocetak";
            this.Text = "Pocetak";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kreirajIgru;
        private System.Windows.Forms.Button poveziSe;
    }
}