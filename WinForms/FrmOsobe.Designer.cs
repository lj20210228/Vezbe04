namespace WinForms
{
    partial class FrmOsobe
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
            this.pnlOsoba = new System.Windows.Forms.Panel();
            this.btnDodajGrad = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbZenski = new System.Windows.Forms.RadioButton();
            this.rbMuški = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbGrad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatumRodjenja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.pnlTabela = new System.Windows.Forms.Panel();
            this.dgvLjudi = new System.Windows.Forms.DataGridView();
            this.btnIzbaci = new System.Windows.Forms.Button();
            this.pnlOsoba.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLjudi)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOsoba
            // 
            this.pnlOsoba.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlOsoba.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlOsoba.Controls.Add(this.btnDodajGrad);
            this.pnlOsoba.Controls.Add(this.btnDodaj);
            this.pnlOsoba.Controls.Add(this.panel3);
            this.pnlOsoba.Controls.Add(this.cmbGrad);
            this.pnlOsoba.Controls.Add(this.label4);
            this.pnlOsoba.Controls.Add(this.label3);
            this.pnlOsoba.Controls.Add(this.txtDatumRodjenja);
            this.pnlOsoba.Controls.Add(this.label2);
            this.pnlOsoba.Controls.Add(this.txtPrezime);
            this.pnlOsoba.Controls.Add(this.label1);
            this.pnlOsoba.Controls.Add(this.txtIme);
            this.pnlOsoba.Location = new System.Drawing.Point(124, 60);
            this.pnlOsoba.Name = "pnlOsoba";
            this.pnlOsoba.Size = new System.Drawing.Size(365, 420);
            this.pnlOsoba.TabIndex = 0;
            // 
            // btnDodajGrad
            // 
            this.btnDodajGrad.Location = new System.Drawing.Point(298, 175);
            this.btnDodajGrad.Name = "btnDodajGrad";
            this.btnDodajGrad.Size = new System.Drawing.Size(38, 23);
            this.btnDodajGrad.TabIndex = 11;
            this.btnDodajGrad.Text = "+";
            this.btnDodajGrad.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(61, 276);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(295, 29);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbZenski);
            this.panel3.Controls.Add(this.rbMuški);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(61, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 57);
            this.panel3.TabIndex = 9;
            // 
            // rbZenski
            // 
            this.rbZenski.AutoSize = true;
            this.rbZenski.Location = new System.Drawing.Point(84, 32);
            this.rbZenski.Name = "rbZenski";
            this.rbZenski.Size = new System.Drawing.Size(59, 19);
            this.rbZenski.TabIndex = 12;
            this.rbZenski.TabStop = true;
            this.rbZenski.Text = "Ženski";
            this.rbZenski.UseVisualStyleBackColor = true;
            // 
            // rbMuški
            // 
            this.rbMuški.AutoSize = true;
            this.rbMuški.Location = new System.Drawing.Point(84, 7);
            this.rbMuški.Name = "rbMuški";
            this.rbMuški.Size = new System.Drawing.Size(57, 19);
            this.rbMuški.TabIndex = 11;
            this.rbMuški.TabStop = true;
            this.rbMuški.Text = "Muski";
            this.rbMuški.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pol:";
            // 
            // cmbGrad
            // 
            this.cmbGrad.FormattingEnabled = true;
            this.cmbGrad.Location = new System.Drawing.Point(140, 175);
            this.cmbGrad.Name = "cmbGrad";
            this.cmbGrad.Size = new System.Drawing.Size(152, 23);
            this.cmbGrad.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Grad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum rođenja:";
            // 
            // txtDatumRodjenja
            // 
            this.txtDatumRodjenja.Location = new System.Drawing.Point(140, 127);
            this.txtDatumRodjenja.Name = "txtDatumRodjenja";
            this.txtDatumRodjenja.Size = new System.Drawing.Size(196, 23);
            this.txtDatumRodjenja.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(140, 85);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(196, 23);
            this.txtPrezime.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(140, 41);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(196, 23);
            this.txtIme.TabIndex = 0;
            // 
            // pnlTabela
            // 
            this.pnlTabela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTabela.Controls.Add(this.dgvLjudi);
            this.pnlTabela.Location = new System.Drawing.Point(511, 60);
            this.pnlTabela.Name = "pnlTabela";
            this.pnlTabela.Size = new System.Drawing.Size(485, 420);
            this.pnlTabela.TabIndex = 1;
            // 
            // dgvLjudi
            // 
            this.dgvLjudi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLjudi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLjudi.Location = new System.Drawing.Point(0, 0);
            this.dgvLjudi.Name = "dgvLjudi";
            this.dgvLjudi.Size = new System.Drawing.Size(485, 420);
            this.dgvLjudi.TabIndex = 0;
            // 
            // btnIzbaci
            // 
            this.btnIzbaci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzbaci.Location = new System.Drawing.Point(884, 31);
            this.btnIzbaci.Name = "btnIzbaci";
            this.btnIzbaci.Size = new System.Drawing.Size(112, 23);
            this.btnIzbaci.TabIndex = 2;
            this.btnIzbaci.Text = "Izbaci";
            this.btnIzbaci.UseVisualStyleBackColor = true;
            // 
            // FrmOsobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 591);
            this.Controls.Add(this.btnIzbaci);
            this.Controls.Add(this.pnlTabela);
            this.Controls.Add(this.pnlOsoba);
            this.Name = "FrmOsobe";
            this.Text = "Rad sa osobama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlOsoba.ResumeLayout(false);
            this.pnlOsoba.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlTabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLjudi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlOsoba;
        private Button btnDodajGrad;
        private Button btnDodaj;
        private Panel panel3;
        private RadioButton rbZenski;
        private RadioButton rbMuški;
        private Label label5;
        private ComboBox cmbGrad;
        private Label label4;
        private Label label3;
        private TextBox txtDatumRodjenja;
        private Label label2;
        private TextBox txtPrezime;
        private Label label1;
        private TextBox txtIme;
        private Panel pnlTabela;
        private DataGridView dgvLjudi;
        private Button btnIzbaci;
    }
}