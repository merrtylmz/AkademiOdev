using System.Text.Json;
using System.IO;
using Serialization___Deserialization___PRS.CLASS;

namespace Serialization___Deserialization___PRS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void jsonOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                string jsonDosyaYolu = "C:\\Users\\merty\\OneDrive\\Desktop\\Serialization & Deserialization - PRS\\urunler.json";
                string jsonIcerik = File.ReadAllText(jsonDosyaYolu);
                List<URUN> urunler = JsonSerializer.Deserialize<List<URUN>>(jsonIcerik);

                listBox1.Items.Clear();
                foreach (var urun in urunler)
                {
                    listBox1.Items.Add($"{urun.UrunAdi} - {urun.Fiyat} TL");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluþtu: " + ex.Message);
            }
        }
    }
}
