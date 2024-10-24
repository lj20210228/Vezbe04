using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.utils;

namespace WinForms
{
    public partial class FrmOsobe : Form
    {
        

        public FrmOsobe()
        {
            InitializeComponent();
            cmbGrad.DataSource =GradUtil.gradovi;
            cmbGrad.DisplayMember = "Naziv";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txtIme.Text)||string.IsNullOrEmpty(txtPrezime.Text))
                {
                    MessageBox.Show("Nisu uneti svi podaci");
                    return;
                }
                Osoba o = new();
                o.Ime = txtIme.Text;
                o.Prezime = txtPrezime.Text;
                o.DatumRodjenja = DateTime.ParseExact(txtDatumRodjenja.Text, "dd.MM.yyyy. HH.mm", CultureInfo.InvariantCulture);
                o.Grad = (Grad)cmbGrad.SelectedItem;
                if (rbMuški.Checked)
                {
                    o.Pol = Pol.Muski;
                }
                else if (rbZenski.Checked) { o.Pol = Pol.Zenski; }
                DialogResult result = MessageBox.Show("Da li ste sigurni da zelite da sacuvate?", "Sacuvaj korisnika",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Console.WriteLine("Uspesno sacuvano");
                } else
                {
                    Console.WriteLine("Nije sacuvano");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
