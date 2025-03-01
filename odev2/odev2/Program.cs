using odev2.Abstracts;
using odev2.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2
{
    class Program
    {
        static void Main(string[] args)
        {

            //ödev1---------
            BMW b = new BMW();
            b.bilgiYazdir("BMW");
            b.hiz();
            b.yuz();
            b.uc();
            
            mercedes m = new mercedes();
            m.bilgiYazdir("Mercedes");
            m.yuz();
            m.uc();
            
            

            porche p = new porche();
            p.bilgiYazdir("Porche");
            p.uc();




            //ödev2---------
            genelMudur gm = new genelMudur();
            gm.maasinizNeKadar();
            Mudur m1 = new  Mudur();
            m1.maasinizNeKadar();
            programci pr = new programci();
            pr.maasinizNeKadar();

            stajyer st = new stajyer();
            st.maasinizNeKadar();

            double toplammaas = 0;

            toplammaas += gm.maasinizNeKadar();
            toplammaas += m1.maasinizNeKadar();
            toplammaas += pr.maasinizNeKadar();
            toplammaas += st.maasinizNeKadar();
            Console.WriteLine("toplam maaş: " + toplammaas);


            //ÖDEV3----------------
            bmwYakit by = new bmwYakit();
            by.yakitHesaplama();
            mercedesyakit my = new mercedesyakit();
            my.yakitHesaplama();
            porcheryakit py = new porcheryakit();
            py.yakitHesaplama();

            double toplamyakit = 0;

            toplamyakit += by.yakitHesaplama();
            toplamyakit += my.yakitHesaplama();
            toplammaas += py.yakitHesaplama();
            Console.WriteLine("toplam yakıt: " + toplamyakit);



//Soru4--------
/*Dizi(dizi), aynı veri türünden çok sayıda değişken anlamına gelir. Diziye ait değişkenler, sıra numarası verilmiş bir liste gibidir. Bu listeye ait olan ilerlemelere de sıra numarasıyla erişilir.
Array'ler üç başlık altında incelenebilir.
1.Tek Boyutlu Arrayler: “Vektör” olarak sunulan ve tek satırdan oluşan dizi sistemidir.
2.İki Boyutlu Arrayler: “Matris” olarak sunulan ve satır-sütun ilişkisi bulunan dizi sistemidir.
3.Çok Boyutlu Arrayler: Üç veya daha fazla boyutlu arrayler.
*/

            Console.ReadKey();
        }
    }
}
