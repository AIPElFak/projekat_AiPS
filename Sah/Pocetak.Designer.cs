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
            this.Ucitaj = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // kreirajIgru
            // 
            this.kreirajIgru.Location = new System.Drawing.Point(73, 29);
            this.kreirajIgru.Name = "kreirajIgru";
            this.kreirajIgru.Size = new System.Drawing.Size(75, 23);
            this.kreirajIgru.TabIndex = 0;
            this.kreirajIgru.Text = "Kreiraj igru";
            this.kreirajIgru.UseVisualStyleBackColor = true;
            this.kreirajIgru.Click += new System.EventHandler(this.kreirajIgru_Click);
            // 
            // poveziSe
            // 
            this.poveziSe.Location = new System.Drawing.Point(73, 180);
            this.poveziSe.Name = "poveziSe";
            this.poveziSe.Size = new System.Drawing.Size(75, 23);
            this.poveziSe.TabIndex = 1;
            this.poveziSe.Text = "Povezi se";
            this.poveziSe.UseVisualStyleBackColor = true;
            this.poveziSe.Click += new System.EventHandler(this.poveziSe_Click);
            // 
            // Ucitaj
            // 
            this.Ucitaj.Location = new System.Drawing.Point(73, 75);
            this.Ucitaj.Name = "Ucitaj";
            this.Ucitaj.Size = new System.Drawing.Size(75, 23);
            this.Ucitaj.TabIndex = 2;
            this.Ucitaj.Text = "Ucitaj";
            this.Ucitaj.UseVisualStyleBackColor = true;
            this.Ucitaj.Click += new System.EventHandler(this.Ucitaj_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(241, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Pocetak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 261);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Ucitaj);
            this.Controls.Add(this.poveziSe);
            this.Controls.Add(this.kreirajIgru);
            this.Name = "Pocetak";
            this.Text = "Pocetak";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kreirajIgru;
        private System.Windows.Forms.Button poveziSe;
        private System.Windows.Forms.Button Ucitaj;
        private System.Windows.Forms.ListView listView1;
    }
}