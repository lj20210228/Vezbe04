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
            Osoba o = new();
            o.Ime = txtIme.Text;
            o.Prezime = txtPrezime.Text;
            o.DatumRodjenja = DateTime.ParseExact(txtDatumRodjenja.Text, "dd.MM.yyyy. HH.mm",CultureInfo.InvariantCulture);
            MessageBox.Show("Uspesno");
        }
    }
}
