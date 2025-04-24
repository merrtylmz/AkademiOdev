using System.Text.RegularExpressions;

namespace REFLECTION_PRS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnklasorsec_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                string rootPath = dialog.SelectedPath;
                TaramayaBasla(rootPath);
            }
        }

        private void TaramayaBasla(string klasorYolu)
        {
            string[] altKlasorler = Directory.GetDirectories(klasorYolu, "*", SearchOption.TopDirectoryOnly);

            foreach (string altKlasor in altKlasorler)
            {
                string klasorAdi = Path.GetFileName(altKlasor);
                listBox1.Items.Add(klasorAdi); // Ana klasör adý

                string[] csDosyalari = Directory.GetFiles(altKlasor, "*.cs", SearchOption.TopDirectoryOnly);

                foreach (string dosya in csDosyalari)
                {
                    try
                    {
                        string icerik = File.ReadAllText(dosya);

                        // Sadece class tanýmlarý (dilersen enum, interface de ekleriz)
                        var classlar = Regex.Matches(icerik,
                            @"\b(?:public|private|internal|protected|abstract|sealed|static|partial)?\s*class\s+([a-zA-Z_][a-zA-Z0-9_]*)",
                            RegexOptions.Multiline);

                        foreach (Match match in classlar)
                        {
                            listBox1.Items.Add("   ? " + match.Groups[1].Value);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Dosya okunamadý: " + dosya + "\n" + ex.Message);
                    }
                }
            }
        }
    }
}
