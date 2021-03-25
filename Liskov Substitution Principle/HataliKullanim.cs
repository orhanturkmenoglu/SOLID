using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov_Substitution_Principle
{
    class HataliKullanim
    {
        static void Main(string[] args)
        {
            // Hatalı Kullanım.
            // nedeni alt sınıflar üst sınıftan türedikleri zaman üst sınıfın methodlarını aynen kullanmak zorunda kalacaktır.
            // işte bu yüzden üst sınıftaki methodları özellikleri birbirlerinin yerine kullanmalıdırlar.
            // Bu örnekte tam tersi durum söz konusudur.Türedikleri sınıfın yerine kullanılamamaktadırlar.gereksiz kullanım vardır.
        }
    }
   

    //public interface IPersonel
    // {
    //     void SatisYap();
    //     void TemizlikYap();
    //     void KasayaBak();
    //     void MusteriIleIlgilen();
    //     void MagazaYonet();
    // }

    // public class Yonetici : IPersonel
    // {
    //     public void KasayaBak()
    //     {
    //         Console.WriteLine("?");
    //     }

    //     public void MagazaYonet()
    //     {
    //         Console.WriteLine("Mağazayı yönetir.");
    //     }

    //     public void MusteriIleIlgilen()
    //     {
    //         Console.WriteLine("?");
    //     }

    //     public void SatisYap()
    //     {
    //         Console.WriteLine("?");
    //     }

    //     public void TemizlikYap()
    //     {
    //         Console.WriteLine("?");
    //     }
    // }

    // public class SatisDanişmani : IPersonel
    // {
    //     public void KasayaBak()
    //     {
    //         throw new NotImplementedException();
    //     }
    //     public void MagazaYonet()
    //     {
    //         throw new NotImplementedException();
    //     }

    //     public void MusteriIleIlgilen()
    //     {
    //         Console.WriteLine("Müşteri ile ilgilenir.");
    //     }

    //     public void SatisYap()
    //     {
    //         Console.WriteLine("Satış Yapar.");
    //     }

    //     public void TemizlikYap()
    //     {
    //         Console.WriteLine("?");
    //     }
    // }

    // public class TemizlikPersoneli : IPersonel
    // {
    //     public void KasayaBak()
    //     {
    //         Console.WriteLine("?");
    //     }
    //     public void MagazaYonet()
    //     {
    //         Console.WriteLine("?");
    //     }

    //     public void MusteriIleIlgilen()
    //     {
    //         Console.WriteLine("?");
    //     }

    //     public void SatisYap()
    //     {
    //         Console.WriteLine("?");
    //     }

    //     public void TemizlikYap()
    //     {
    //         Console.WriteLine("Temizlik Yapar");
    //     }
    // }
}
