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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kreirajIgru
            // 
            this.kreirajIgru.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kreirajIgru.Location = new System.Drawing.Point(35, 37);
            this.kreirajIgru.Name = "kreirajIgru";
            this.kreirajIgru.Size = new System.Drawing.Size(75, 23);
            this.kreirajIgru.TabIndex = 0;
            this.kreirajIgru.Text = "Create game";
            this.kreirajIgru.UseVisualStyleBackColor = true;
            this.kreirajIgru.Click += new System.EventHandler(this.kreirajIgru_Click);
            // 
            // poveziSe
            // 
            this.poveziSe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.poveziSe.Location = new System.Drawing.Point(35, 172);
            this.poveziSe.Name = "poveziSe";
            this.poveziSe.Size = new System.Drawing.Size(75, 23);
            this.poveziSe.TabIndex = 1;
            this.poveziSe.Text = "Connect";
            this.poveziSe.UseVisualStyleBackColor = true;
            this.poveziSe.Click += new System.EventHandler(this.poveziSe_Click);
            // 
            // Ucitaj
            // 
            this.Ucitaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ucitaj.Location = new System.Drawing.Point(35, 76);
            this.Ucitaj.Name = "Ucitaj";
            this.Ucitaj.Size = new System.Drawing.Size(75, 23);
            this.Ucitaj.TabIndex = 2;
            this.Ucitaj.Text = "Load";
            this.Ucitaj.UseVisualStyleBackColor = true;
            this.Ucitaj.Click += new System.EventHandler(this.Ucitaj_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.SaddleBrown;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Location = new System.Drawing.Point(159, 37);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(161, 158);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(457, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(156, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // Pocetak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sah.Properties.Resources.sahbackground;
            this.ClientSize = new System.Drawing.Size(476, 307);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Ucitaj);
            this.Controls.Add(this.poveziSe);
            this.Controls.Add(this.kreirajIgru);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pocetak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pocetak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kreirajIgru;
        private System.Windows.Forms.Button poveziSe;
        private System.Windows.Forms.Button Ucitaj;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}