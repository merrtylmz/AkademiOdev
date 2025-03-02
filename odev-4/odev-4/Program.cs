using sınıf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_4
{
    class Program
    {
        static void Main(string[] args)
        {
            user kullanıucı = new user();
            kullanıucı.AdSoyad = "Mert YILMAZ";
            kullanıucı.Yaş = 23;
            kullanıucı.Email = "mertyilmaz5702@gmail.com";
            kullanıucı.BilgiGoster();
        }
    }
}
namespace sınıf   
{
    class user 
    {
        private string adSoyad;
        private int yas;
        public string Email{ get; set; }
        public string AdSoyad
        {
            get { return adSoyad; }
            set { adSoyad = value; }
        }

        public int Yaş
        {
            get { return yas; }
            set { yas= value; }
        }
        public void BilgiGoster()
        {
            Console.WriteLine("Ad Soyad: " + adSoyad);
            Console.WriteLine("Yaş: " + yas);
            Console.WriteLine("Email: " + Email);
        }
    }


    /*1. Araştırma Kısmı:
        C# dilinde kullanılan erişim belirleyiciler (public, private, protected, internal) nelerdir? Her birini gerçek hayattan bir örnekle açıklayın.
        Erişim belirleyicilerin nesne yönelimli programlamadaki(OOP) rolü nedir?

         C# dilinde kullanılan erişim belirleyiciler:
        1. public: Herhangi bir yerden erişilebilir. 
        2. private: Sadece tanımlandığı sınıf içerisinden erişilebilir.
        3. protected: Sadece tanımlandığı sınıf içerisinden ve bu sınıftan türetilen sınıflardan erişilebilir.
        4. internal: Sadece tanımlandığı proje içerisinden erişilebilir.
    
   Gerçek hayattan örnek:
        1. public:  Bir kütüphanede bulunan kitapların içeriği herkes tarafından görülebilir.
        2. private: Bir kütüphanede bulunan kitapların içeriği sadece kütüphane çalışanları tarafından görülebilir.
        3. protected: Bir kütüphanede bulunan kitapların içeriği sadece kütüphane çalışanları ve bu çalışanlardan türetilen kişiler tarafından görülebilir.
        4. internal: Bir kütüphanede bulunan kitapların içeriği sadece o kütüphanede çalışan kişiler tarafından görülebilir.
    
   Erişim belirleyicilerin nesne yönelimli programlamadaki(OOP) rolü:
        Erişim belirleyiciler, nesne yönelimli programlamada sınıfların ve nesnelerin erişimini kontrol etmek için kullanılır. 
        Bu sayede sınıfların ve nesnelerin erişimini kontrol ederek, programın daha güvenli ve düzenli olmasını sağlar.
    */


}