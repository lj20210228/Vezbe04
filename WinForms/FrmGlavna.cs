namespace WinForms
{
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
        }

        

        private void radSaOsobamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOsobe osobe = new FrmOsobe();
            osobe.Show();
        }
    }
}
