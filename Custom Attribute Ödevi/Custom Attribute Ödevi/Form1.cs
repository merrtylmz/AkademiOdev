using System.ComponentModel.DataAnnotations;

namespace Custom_Attribute_Ödevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Bolum = txtBolum.Text
            };

            var hatalar = Validator.Dogrula(ogr);

            if (hatalar.Count == 0)
            {
                lblSonuc.Text = $"Ad: {ogr.Ad}, Soyad: {ogr.Soyad}, Bölüm: {ogr.Bolum}";
            }
            else
            {
                lblSonuc.Text = string.Join("\n", hatalar);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
