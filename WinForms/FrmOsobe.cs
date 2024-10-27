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
using System.Linq;

namespace WinForms
{
    public partial class FrmOsobe : Form
    {


        public FrmOsobe()
        {
            InitializeComponent();
            cmbGrad.DataSource = GradUtil.gradovi;
            cmbGrad.DisplayMember = "Naziv";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {



                Osoba o = new();
                o.Ime = txtIme.Text;
                o.Prezime = txtPrezime.Text;
                if (!DateTime.TryParseExact(txtDatumRodjenja.Text, "dd.MM.yyyy. HH.mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime datum))
                {
                    throw new FormatException("Datum nije u odgovarajućem formatu! Unesite datum kao dd.MM.yyyy. HH.mm");
                }
                o.Grad = (Grad)cmbGrad.SelectedItem;
                if (string.IsNullOrEmpty(txtIme.Text) || !txtIme.Text.All(char.IsLetter) || !char.IsLetter(txtIme.Text[0]) || !char.IsUpper(txtIme.Text[0]))
                {
                    throw new Exception("Unesite ime u odgovarajucem formatu!");
                }
                if (string.IsNullOrEmpty(txtPrezime.Text) || !txtPrezime.Text.All(char.IsLetter) || !char.IsLetter(txtPrezime.Text[0]) || !char.IsUpper(txtPrezime.Text[0]))
                {
                    throw new Exception("Unesite prezime u odgovarajucem formatu!");
                }
                if (!rbMuški.Checked && !rbZenski.Checked)
                {
                    throw new Exception("Unesite pol");
                }
                o.Pol = rbMuški.Checked ? Pol.Muski : Pol.Zenski;
                DialogResult result = MessageBox.Show("Da li ste sigurni da zelite da sacuvate?", "Sacuvaj korisnika",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Console.WriteLine("Uspesno sacuvano");
                }
                else
                {
                    Console.WriteLine("Nije sacuvano");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Datum nije u odgovarajućem formatu!");
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
            
        }
        private static void Greske(TextBox t, Label l)
        {
            string tekst = null;
            if (t.Name == "txtIme")
            {
                tekst = "Ime";
            }
            else
            {
                tekst = "Prezime";
            }
            if (!string.IsNullOrEmpty(t.Text) && !char.IsUpper(t.Text[0]) && char.IsLetter(t.Text[0]))
            {
                l.Text = $"Prvo slovo {tekst.ToLower() + "na"} mora biti veliko!";
                return;
            }
            else if (!t.Text.All(char.IsLetter))
            {
                l.Text = $"{tekst} ne sme sadrzati broj!";
                return;
            }
            else if (t.Text.Length < 2 && t.Text.Length > 0)
            {
                l.Text = $"{tekst} mora da sadrzi barem 2 slova!";
                return;
            }
            else
            {
                l.Text = "";
            }






        }
        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            Greske(txtIme, greskeIme);
            greskeIme.ForeColor = Color.Red;
        }

        private void pnlOsoba_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            Greske(txtPrezime, greskePrezime);
            greskePrezime.ForeColor = Color.Red;
        }

        private void txtDatumRodjenja_TextChanged(object sender, EventArgs e)
        {
            DateTime parsedDate;
            greskeDatum.ForeColor = Color.Red;
            bool isvalid = DateTime.TryParseExact(txtDatumRodjenja.Text, "dd.MM.yyyy. HH.mm ", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate);
            if(!isvalid)
            {
                greskeDatum.Text = "Unesite datum u formatu dd.MM.yyyy. HH.mm";
                return;
            }
            
        }
    }
}
