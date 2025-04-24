using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace reflection_prs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKlasorSec_Click(object sender, EventArgs e)
        {
            //odev-1 

            using (var diolog = new FolderBrowserDialog())
            {
                if (diolog.ShowDialog()==DialogResult.OK)
                {
                    listBox1.Items.Clear();//eðer biþey listeliyorsak ilk önce bunu temizlemek gerekir
                    DosyaBul(diolog.SelectedPath);

                }

            }
            
        }
            
        public void DosyaBul(string dosyaYolu)
        {
            var klasorler = Directory.GetDirectories(dosyaYolu,"*",SearchOption.AllDirectories);
            foreach (var klasor in klasorler)
            {
                string klasorAdi = "Klasör:" + Path.GetFileName(klasor);
                listBox1.Items.Add(klasorAdi);

                string[]? csDosyalar = Directory.GetFiles(klasor, "*.cs");
                
                foreach (string dosya in csDosyalar)
                {
                    string[]? satirlar = File.ReadAllLines(dosya);
                    
                    foreach (var satir in satirlar)
                    {
                        if (satir.Trim().StartsWith("class "))
                        {
                            string classAdi = Regex.Match(satir, @"class\s+\(\w+)").Groups[1].Value;
                            if (!string.IsNullOrEmpty(classAdi))
                            {
                                listBox1.Items.Add( " -  " + classAdi);
                            }
                        }
                    }
                }
            }
        }
    }
}

//  \s boþluk karekteri
// \w alfanumerik karakter

