using System.Configuration.Provider;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Hasta_Randevu_Sistemi___PRS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            SaatDoldur();
            BransDoldur();
        }

        private void SaatDoldur()
        {
            cmbSaat.Items.Clear();
            cmbSaat.Items.AddRange(new string[]
            {
                "09:00",
                "09:30",
                "10:00",
                "10:30",
                "11:00",
                "11:30",
                "13:00",
                "13:30",
                "14:00",
                "14:30",
                "15:00",
                "15:30",
                "16:00",
                "16:30"
            });
            cmbSaat.SelectedIndex = 0;
            cmbSaat.IntegralHeight = false; // DropDownList'in boyutunu otomatik olarak ayarlama
            cmbSaat.MaxDropDownItems = 5; // Tüm öðeleri göstermek için maksimum açýlýr öðe sayýsýný ayarla

        }

        private void BransDoldur()
        {
            try
            {
                dbHelper db = new();

                DataTable dt = db.ExecuteSelectQuery("select ID BransAdi from Branslar");
                DataRow dr = dt.NewRow();
                dr["ID"] = 0;
                dr["BransAdi"] = "Seçiniz";
                dt.Rows.InsertAt(dr, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Hata: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void cmbBrans_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbBrans.SelectedIndex == 0)
            {
                cmbDoktor.Items.Clear();
                cmbDoktor.Enabled = false;
            }
            else
            {
                cmbDoktor.Enabled = true;
                cmbDoktor.Items.Clear();
                dbHelper db = new();
                DataTable dt = db.ExecuteSelectQuery("select ID, Ad + ' ' + Soyad as Doktor from Doktorlar where BransID = " + cmbBrans.SelectedValue);
                DataRow dr = dt.NewRow();
                dr["ID"] = 0;
                dr["Doktor"] = "Seçiniz";
                dt.Rows.InsertAt(dr, 0);
                cmbDoktor.DataSource = dt;
                cmbDoktor.DisplayMember = "Doktor";
                cmbDoktor.ValueMember = "ID";
            }

        }
        private void DoktorlariYükle(int bransID)
        {
            dbHelper db = new();
            String query = "select ID, Ad + ' ' + Soyad as Doktor from Doktorlar where BransID = @BransID";
            DataTable dt = db.ExecuteSelectQuery(query, new SqlParameter("@BransID", bransID));
            DataRow dr = dt.NewRow();
            dr["ID"] = 0;
            dr["Doktor"] = "Seçiniz";
            dt.Rows.InsertAt(dr, 0);
            cmbDoktor.DataSource = dt;
            cmbDoktor.DisplayMember = "Doktor";
            cmbDoktor.ValueMember = "ID";

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            
            FormVerileriGecerliMi();
            string ad = txtAD.Text;
            string soyad = txtSoyad.Text;
            int bransID = Convert.ToInt32(cmbBrans.SelectedValue);
            int doktorID = Convert.ToInt32(cmbDoktor.SelectedValue);
            DateTime tarih = dtpTarih.Value.Date;
            TimeSpan saat = TimeSpan.Parse(cmbSaat.SelectedItem.ToString());
            if (DoktorCakismaVarMi(doktorID, tarih, saat)) return;
            RandevuKaydet(ad, soyad, bransID, doktorID, tarih,saat);
            MessageBox.Show("Randevunuz baþarýyla kaydedildi.", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void RandevuKaydet(string ad, string soyad, int bransID, int doktorID, DateTime tarih, TimeSpan saat)
        {
            string query = "INSERT INTO Randevular (Ad, Soyad, BransID, DoktorID, Tarih, Saat) VALUES (@Ad, @Soyad, @BransID, @DoktorID, @Tarih, @Saat)";
           
            
            new dbHelper().ExecuteInsertQuery(query,
                new SqlParameter("@Ad", ad),
                new SqlParameter("@Soyad", soyad),
                new SqlParameter("@BransID", bransID),
                new SqlParameter("@DoktorID", doktorID),
                new SqlParameter("@Tarih", tarih),
                new SqlParameter("@Saat", saat));
        
        }
        private bool DoktorCakismaVarMi(int doktorID, DateTime tarih, TimeSpan saat)
        {
            string sql = "SELECT COUNT(*) FROM Randevular WHERE DoktorID = @DoktorID AND Tarih = @Tarih AND Saat = @Saat";
            int sonuc = (int)new dbHelper().ExecuteScalar(sql,
                new SqlParameter("@DoktorID", doktorID),
                new SqlParameter("@Tarih", tarih),
                new SqlParameter("@Saat", saat));
            if (sonuc > 0)
            {
                MessageBox.Show("Seçtiðiniz doktorun bu tarihte randevusu var. Lütfen baþka bir saat seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool FormVerileriGecerliMi()
        {
            if (string.IsNullOrEmpty(txtAD.Text))
            {
                MessageBox.Show("Lütfen adýnýzý giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbBrans.SelectedIndex == 0)
            {
                MessageBox.Show("Lütfen bir branþ seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbDoktor.SelectedIndex == 0)
            {
                MessageBox.Show("Lütfen bir doktor seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(cmbSaat.Text))
            {
                MessageBox.Show("Lütfen bir saat seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}

