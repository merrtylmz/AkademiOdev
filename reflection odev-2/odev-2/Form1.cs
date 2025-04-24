using odev_2.interfaces;
using System.Reflection;

namespace odev_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Type> odemeYontemleri = Assembly.GetExecutingAssembly().
                GetTypes().Where(t => typeof(IOdemeYontemi).IsAssignableFrom(t) && t.IsClass).t.ToList();

            cmbOdemeYontemi.DataSource = odemeYontemleri;
            cmbOdemeYontemi.DisplayMember = "Name";




        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            if(decimal.TryParse(txtTutar.Text,out decimal tutar))
            {
                var secilenTip = cmbOdemeYontemi.SelectedItem as Type;
                if (secilenTip != null)
                {
                    var nesne = Activator.CreateInstance(secilenTip) as IOdemeYontemi;
                    if (nesne == null)
                    {
                        MessageBox.Show("Nesne oluþturulamadý.");
                        return;
                    } 
                    else 
                    {
                    MessageBox.Show("Ödeme yöntemi seçilmedi.");
                    }

                    
                }
               
            }
        }
    }
}
