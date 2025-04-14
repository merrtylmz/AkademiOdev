namespace Windows_Form_Uygulaması_ile_Araba_Bilgi_Formu___PRS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, string[]> arabaModelleri = new Dictionary<string, string[]>()
        {
            {"BMW",new[]{"X5","M4","M5","F30"} },
            {"MERCEDES",new[]{"AMG","CLA180","GLC","A250" } },
            {"TOYOTA",new[]{"COROLLA","YARİS","HILUX" } }
        };
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Marka:{cmbMarka.Text} Model:{cmbModel.Text} " +
                $"Renk :{cmbRenk.Text} Pencere Sayısı :{cmbPencereSayisi.Text} " +
                $"Kapı sayısı :{cmbKapiSayisi.Text} 100 km’de Yaktığı Yakıt (Litre):{cmbTotal.Text}" +
                MessageBoxButtons.OK+MessageBoxIcon.Asterisk);
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbModel.Items.Clear();

            foreach (string marka in arabaModelleri.Keys)
            {
                cmbMarka.Items.Add(marka);
            }
            cmbModel.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMarka.Items.Clear();
            foreach (string marka in arabaModelleri.Keys)
            {
                cmbMarka.Items.Add(marka);
            }
        }


        private void cmbMarka_MouseHover(object sender, MouseEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.BackColor = Color.Aqua;
        }



        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbMarka.Text) && string.IsNullOrEmpty(cmbModel.Text) && string.IsNullOrEmpty(cmbRenk.Text) &&
                string.IsNullOrEmpty(cmbKapiSayisi.Text) && string.IsNullOrEmpty(cmbPencereSayisi.Text) && string.IsNullOrEmpty(mtbtotal.Text))
            {
                button1.Visible = true;
            }
        }

        private void cmbRenk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kontrol())
            {
                button1.Visible = true;
            }
        }

        private void cmbKapiSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kontrol())
            {
                button1.Visible = true;
            }
        }

        private void cmbPencereSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kontrol())
            {
                button1.Visible = true;
            }
        }

        private void mtbtotal_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbMarka.Text) && string.IsNullOrEmpty(cmbModel.Text) && string.IsNullOrEmpty(cmbRenk.Text) &&
              string.IsNullOrEmpty(cmbKapiSayisi.Text) && string.IsNullOrEmpty(cmbPencereSayisi.Text) && string.IsNullOrEmpty(mtbtotal.Text))
            {
                button1.Visible = true;
            }
        }
        private bool kontrol()
        {
            if (string.IsNullOrEmpty(cmbMarka.Text) && string.IsNullOrEmpty(cmbModel.Text) && string.IsNullOrEmpty(cmbRenk.Text) &&
              string.IsNullOrEmpty(cmbKapiSayisi.Text) && string.IsNullOrEmpty(cmbPencereSayisi.Text) && string.IsNullOrEmpty(mtbtotal.Text))
            {
               return  true;
            }
            return false;
        }
    }
}
