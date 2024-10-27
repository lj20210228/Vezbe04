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
            pnlOsoba = new Panel();
            greskeDatum = new Label();
            greskePrezime = new Label();
            greskeIme = new Label();
            btnDodajGrad = new Button();
            btnDodaj = new Button();
            panel3 = new Panel();
            rbZenski = new RadioButton();
            rbMuški = new RadioButton();
            label5 = new Label();
            cmbGrad = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtDatumRodjenja = new TextBox();
            label2 = new Label();
            txtPrezime = new TextBox();
            label1 = new Label();
            txtIme = new TextBox();
            pnlTabela = new Panel();
            dgvLjudi = new DataGridView();
            btnIzbaci = new Button();
            datumGreska = new Label();
            pnlOsoba.SuspendLayout();
            panel3.SuspendLayout();
            pnlTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLjudi).BeginInit();
            SuspendLayout();
            // 
            // pnlOsoba
            // 
            pnlOsoba.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlOsoba.BackColor = SystemColors.ActiveCaption;
            pnlOsoba.Controls.Add(datumGreska);
            pnlOsoba.Controls.Add(greskeDatum);
            pnlOsoba.Controls.Add(greskePrezime);
            pnlOsoba.Controls.Add(greskeIme);
            pnlOsoba.Controls.Add(btnDodajGrad);
            pnlOsoba.Controls.Add(btnDodaj);
            pnlOsoba.Controls.Add(panel3);
            pnlOsoba.Controls.Add(cmbGrad);
            pnlOsoba.Controls.Add(label4);
            pnlOsoba.Controls.Add(label3);
            pnlOsoba.Controls.Add(txtDatumRodjenja);
            pnlOsoba.Controls.Add(label2);
            pnlOsoba.Controls.Add(txtPrezime);
            pnlOsoba.Controls.Add(label1);
            pnlOsoba.Controls.Add(txtIme);
            pnlOsoba.Location = new Point(142, 80);
            pnlOsoba.Margin = new Padding(3, 4, 3, 4);
            pnlOsoba.Name = "pnlOsoba";
            pnlOsoba.Size = new Size(417, 560);
            pnlOsoba.TabIndex = 0;
            pnlOsoba.Paint += pnlOsoba_Paint;
            // 
            // greskeDatum
            // 
            greskeDatum.AutoSize = true;
            greskeDatum.ForeColor = Color.Lime;
            greskeDatum.Location = new Point(162, 204);
            greskeDatum.Name = "greskeDatum";
            greskeDatum.Size = new Size(0, 20);
            greskeDatum.TabIndex = 14;
            // 
            // greskePrezime
            // 
            greskePrezime.AutoSize = true;
            greskePrezime.Location = new Point(161, 144);
            greskePrezime.Name = "greskePrezime";
            greskePrezime.Size = new Size(0, 20);
            greskePrezime.TabIndex = 13;
            // 
            // greskeIme
            // 
            greskeIme.AutoSize = true;
            greskeIme.Location = new Point(161, 84);
            greskeIme.Name = "greskeIme";
            greskeIme.Size = new Size(0, 20);
            greskeIme.TabIndex = 12;
            greskeIme.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnDodajGrad
            // 
            btnDodajGrad.Location = new Point(341, 233);
            btnDodajGrad.Margin = new Padding(3, 4, 3, 4);
            btnDodajGrad.Name = "btnDodajGrad";
            btnDodajGrad.Size = new Size(43, 31);
            btnDodajGrad.TabIndex = 11;
            btnDodajGrad.Text = "+";
            btnDodajGrad.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(70, 368);
            btnDodaj.Margin = new Padding(3, 4, 3, 4);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(337, 39);
            btnDodaj.TabIndex = 10;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(rbZenski);
            panel3.Controls.Add(rbMuški);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(70, 284);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(337, 76);
            panel3.TabIndex = 9;
            // 
            // rbZenski
            // 
            rbZenski.AutoSize = true;
            rbZenski.Location = new Point(96, 43);
            rbZenski.Margin = new Padding(3, 4, 3, 4);
            rbZenski.Name = "rbZenski";
            rbZenski.Size = new Size(72, 24);
            rbZenski.TabIndex = 12;
            rbZenski.TabStop = true;
            rbZenski.Text = "Ženski";
            rbZenski.UseVisualStyleBackColor = true;
            // 
            // rbMuški
            // 
            rbMuški.AutoSize = true;
            rbMuški.Location = new Point(96, 9);
            rbMuški.Margin = new Padding(3, 4, 3, 4);
            rbMuški.Name = "rbMuški";
            rbMuški.Size = new Size(68, 24);
            rbMuški.TabIndex = 11;
            rbMuški.TabStop = true;
            rbMuški.Text = "Muski";
            rbMuški.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 5);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 10;
            label5.Text = "Pol:";
            // 
            // cmbGrad
            // 
            cmbGrad.FormattingEnabled = true;
            cmbGrad.Location = new Point(160, 233);
            cmbGrad.Margin = new Padding(3, 4, 3, 4);
            cmbGrad.Name = "cmbGrad";
            cmbGrad.Size = new Size(173, 28);
            cmbGrad.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 235);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 7;
            label4.Text = "Grad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 176);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 5;
            label3.Text = "Datum rođenja:";
            // 
            // txtDatumRodjenja
            // 
            txtDatumRodjenja.Location = new Point(160, 169);
            txtDatumRodjenja.Margin = new Padding(3, 4, 3, 4);
            txtDatumRodjenja.Name = "txtDatumRodjenja";
            txtDatumRodjenja.Size = new Size(223, 27);
            txtDatumRodjenja.TabIndex = 4;
            txtDatumRodjenja.TextChanged += txtDatumRodjenja_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 120);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 3;
            label2.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(160, 113);
            txtPrezime.Margin = new Padding(3, 4, 3, 4);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(223, 27);
            txtPrezime.TabIndex = 2;
            txtPrezime.TextChanged += txtPrezime_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 61);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 1;
            label1.Text = "Ime:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(160, 55);
            txtIme.Margin = new Padding(3, 4, 3, 4);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(223, 27);
            txtIme.TabIndex = 0;
            txtIme.TextChanged += txtIme_TextChanged;
            // 
            // pnlTabela
            // 
            pnlTabela.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlTabela.Controls.Add(dgvLjudi);
            pnlTabela.Location = new Point(584, 80);
            pnlTabela.Margin = new Padding(3, 4, 3, 4);
            pnlTabela.Name = "pnlTabela";
            pnlTabela.Size = new Size(554, 560);
            pnlTabela.TabIndex = 1;
            // 
            // dgvLjudi
            // 
            dgvLjudi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLjudi.Dock = DockStyle.Fill;
            dgvLjudi.Location = new Point(0, 0);
            dgvLjudi.Margin = new Padding(3, 4, 3, 4);
            dgvLjudi.Name = "dgvLjudi";
            dgvLjudi.RowHeadersWidth = 51;
            dgvLjudi.Size = new Size(554, 560);
            dgvLjudi.TabIndex = 0;
            // 
            // btnIzbaci
            // 
            btnIzbaci.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIzbaci.Location = new Point(1010, 41);
            btnIzbaci.Margin = new Padding(3, 4, 3, 4);
            btnIzbaci.Name = "btnIzbaci";
            btnIzbaci.Size = new Size(128, 31);
            btnIzbaci.TabIndex = 2;
            btnIzbaci.Text = "Izbaci";
            btnIzbaci.UseVisualStyleBackColor = true;
            // 
            // datumGreska
            // 
            datumGreska.AutoSize = true;
            datumGreska.Location = new Point(165, 198);
            datumGreska.Name = "datumGreska";
            datumGreska.Size = new Size(0, 20);
            datumGreska.TabIndex = 15;
            // 
            // FrmOsobe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 788);
            Controls.Add(btnIzbaci);
            Controls.Add(pnlTabela);
            Controls.Add(pnlOsoba);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmOsobe";
            Text = "Rad sa osobama";
            WindowState = FormWindowState.Maximized;
            pnlOsoba.ResumeLayout(false);
            pnlOsoba.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnlTabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLjudi).EndInit();
            ResumeLayout(false);
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
        private Label greskeDatum;
        private Label greskePrezime;
        private Label greskeIme;
        private Label datumGreska;
    }
}