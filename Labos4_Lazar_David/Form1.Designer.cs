namespace Labos4_Lazar_David
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
            this.LabNaziv = new System.Windows.Forms.Label();
            this.LabOcjena = new System.Windows.Forms.Label();
            this.TxtNaziv = new System.Windows.Forms.TextBox();
            this.TxtOcjena = new System.Windows.Forms.TextBox();
            this.BtnUnesi = new System.Windows.Forms.Button();
            this.TxtIspisSvih = new System.Windows.Forms.TextBox();
            this.TxtIspisNaj = new System.Windows.Forms.TextBox();
            this.ProvjeraIspisa = new System.Windows.Forms.Timer(this.components);
            this.LabIspisSvih = new System.Windows.Forms.Label();
            this.LabIspisNaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabNaziv
            // 
            this.LabNaziv.AutoSize = true;
            this.LabNaziv.Location = new System.Drawing.Point(12, 28);
            this.LabNaziv.Name = "LabNaziv";
            this.LabNaziv.Size = new System.Drawing.Size(73, 13);
            this.LabNaziv.TabIndex = 0;
            this.LabNaziv.Text = "Naziv kolegija";
            // 
            // LabOcjena
            // 
            this.LabOcjena.AutoSize = true;
            this.LabOcjena.Location = new System.Drawing.Point(12, 76);
            this.LabOcjena.Name = "LabOcjena";
            this.LabOcjena.Size = new System.Drawing.Size(41, 13);
            this.LabOcjena.TabIndex = 1;
            this.LabOcjena.Text = "Ocjena";
            // 
            // TxtNaziv
            // 
            this.TxtNaziv.Location = new System.Drawing.Point(88, 25);
            this.TxtNaziv.Name = "TxtNaziv";
            this.TxtNaziv.Size = new System.Drawing.Size(100, 20);
            this.TxtNaziv.TabIndex = 2;
            // 
            // TxtOcjena
            // 
            this.TxtOcjena.Location = new System.Drawing.Point(88, 76);
            this.TxtOcjena.Name = "TxtOcjena";
            this.TxtOcjena.Size = new System.Drawing.Size(100, 20);
            this.TxtOcjena.TabIndex = 3;
            // 
            // BtnUnesi
            // 
            this.BtnUnesi.Location = new System.Drawing.Point(44, 125);
            this.BtnUnesi.Name = "BtnUnesi";
            this.BtnUnesi.Size = new System.Drawing.Size(121, 25);
            this.BtnUnesi.TabIndex = 4;
            this.BtnUnesi.Text = "Unesi";
            this.BtnUnesi.UseVisualStyleBackColor = true;
            this.BtnUnesi.Click += new System.EventHandler(this.BtnUnesi_Click);
            // 
            // TxtIspisSvih
            // 
            this.TxtIspisSvih.Location = new System.Drawing.Point(23, 179);
            this.TxtIspisSvih.Multiline = true;
            this.TxtIspisSvih.Name = "TxtIspisSvih";
            this.TxtIspisSvih.Size = new System.Drawing.Size(174, 106);
            this.TxtIspisSvih.TabIndex = 5;
            this.TxtIspisSvih.TextChanged += new System.EventHandler(this.TxtIspisSvih_TextChanged);
            // 
            // TxtIspisNaj
            // 
            this.TxtIspisNaj.Location = new System.Drawing.Point(23, 304);
            this.TxtIspisNaj.Multiline = true;
            this.TxtIspisNaj.Name = "TxtIspisNaj";
            this.TxtIspisNaj.Size = new System.Drawing.Size(174, 49);
            this.TxtIspisNaj.TabIndex = 6;
            // 
            // ProvjeraIspisa
            // 
            this.ProvjeraIspisa.Tick += new System.EventHandler(this.ProvjeraIspisa_Tick);
            // 
            // LabIspisSvih
            // 
            this.LabIspisSvih.AutoSize = true;
            this.LabIspisSvih.Location = new System.Drawing.Point(12, 163);
            this.LabIspisSvih.Name = "LabIspisSvih";
            this.LabIspisSvih.Size = new System.Drawing.Size(89, 13);
            this.LabIspisSvih.TabIndex = 7;
            this.LabIspisSvih.Text = "Ispis svih kolegija";
            // 
            // LabIspisNaj
            // 
            this.LabIspisNaj.AutoSize = true;
            this.LabIspisNaj.Location = new System.Drawing.Point(12, 288);
            this.LabIspisNaj.Name = "LabIspisNaj";
            this.LabIspisNaj.Size = new System.Drawing.Size(108, 13);
            this.LabIspisNaj.TabIndex = 8;
            this.LabIspisNaj.Text = "Ispis najboljih kolegija";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 365);
            this.Controls.Add(this.LabIspisNaj);
            this.Controls.Add(this.LabIspisSvih);
            this.Controls.Add(this.TxtIspisNaj);
            this.Controls.Add(this.TxtIspisSvih);
            this.Controls.Add(this.BtnUnesi);
            this.Controls.Add(this.TxtOcjena);
            this.Controls.Add(this.TxtNaziv);
            this.Controls.Add(this.LabOcjena);
            this.Controls.Add(this.LabNaziv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabNaziv;
        private System.Windows.Forms.Label LabOcjena;
        private System.Windows.Forms.TextBox TxtNaziv;
        private System.Windows.Forms.TextBox TxtOcjena;
        private System.Windows.Forms.Button BtnUnesi;
        private System.Windows.Forms.TextBox TxtIspisSvih;
        private System.Windows.Forms.TextBox TxtIspisNaj;
        private System.Windows.Forms.Timer ProvjeraIspisa;
        private System.Windows.Forms.Label LabIspisSvih;
        private System.Windows.Forms.Label LabIspisNaj;
    }
}

