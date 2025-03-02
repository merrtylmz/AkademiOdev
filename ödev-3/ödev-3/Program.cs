using matematikislemleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_3
{
    class ProgramTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Hesaplama hesap = new Hesaplama();
            hesap.Topla(sayi, sayi2);
            hesap.Carp(sayi, sayi2);




            Console.ReadLine();
        }
    }
}

namespace matematikislemleri
{
    class Hesaplama
    {
        public void Topla(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
        public void Carp(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 * sayi2);
        }
    }

    //soru1: Namespace nedir? Namespace ne işe yarar?
    /*
     -Ad Çakışmalarını Önler: Farklı geliştiriciler aynı projede çalışırken aynı isimleri kullanabilirler.
     * Namespace'ler, ad çakışmalarını önlemek için kullanılır ve aynı isme sahip sınıfların birlikte sorunsuz bir şekilde var olmasına olanak tanır. 
     -Kod Organizasyonu: Kodunuzu mantıksal bölümlere ayırarak daha düzenli bir hale getirir.
     * Bu sayede kodunuzu daha kolay yönetebilir ve sürdürülebilir hale getirebilirsiniz.
    -Yeniden Kullanılabilirlik: Belirli işlevler için oluşturduğunuz sınıfları ve metodları, farklı projelerde aynı namespace içinde kullanarak kodunuzu yeniden kullanabilirsiniz.
    *Bu, geliştirme sürecini hızlandırır ve tekrar eden kod yazma ihtiyacını azaltır.
    -Güvenlik ve Erişim Kontrolü: Namespace'ler, belirli kod bölümlerini gizli tutmanıza ve sadece belirli bölümlerin erişimine izin vermenize yardımcı olabilir.

    //soru2:Genişletilebilirlik (Extensibility) nedir ve bir yazılımın genişletilebilir olmasını nasıl sağlarız?
    
    -Modülerlik: Yazılımı bağımsız ve işlevsel modüllere ayırmak, her modülün ayrı ayrı geliştirilip test edilmesine olanak tanır. 
    *Böylece, bir modül üzerinde yapılan değişiklikler diğer modülleri etkilemez.
    -Arayüzler ve Abstraksiyon: Soyutlama (abstraction) ve arayüzler (interfaces) kullanarak, yazılımın farklı bölümleri arasında gevşek bağlanmış (loosely coupled) bir yapı oluşturabilirsiniz. Bu, bir bileşenin diğerinden bağımsız olarak genişletilebilmesini sağlar.
    -Eklenti Mimarisini Kullanma (Plugin Architecture): Eklenti sistemleri, yazılıma yeni özellikler eklemek için harika bir yoldur. 
    *Eklentiler, ana uygulamadan bağımsız olarak geliştirilip eklenebilir.
    -Tasarımsal Kalıplar (Design Patterns): Genişletilebilirlik için kullanılan belirli tasarım kalıpları vardır. 
    *Örneğin, Factory Pattern, Strategy Pattern ve Observer Pattern gibi kalıplar, kodun genişletilebilir olmasını sağlayan yapı ve stratejiler sunar.
    -Test Edilebilirlik:Yazılımın genişletilebilir olması için, yeni eklenen özelliklerin kolayca test edilebilmesi gerekir.
    *Bu nedenle, birim testleri (unit tests) ve entegrasyon testleri (integration tests) yazılımın genişletilebilirliğini destekler.
 */

}

