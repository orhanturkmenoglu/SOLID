using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Inversion_Principle
{
   public class Misuse
    {
        static void Main(string[] args)
        {
            // Hatalı kullanım.
        }


        // Hatalı kullanım

        //public interface Musteri
        //{
        //    void Add();
        //}

        //public class GercekMusteri : Musteri
        //{
        //    public void Add()
        //    {
        //        Console.WriteLine("Gerçek Müşteri eklendi");
        //    }
        //}

        //public class TuzelMusteri : Musteri
        //{
        //    public void Add()
        //    {
        //        Console.WriteLine("Tüzel Müşteri eklendi");
        //    }
        //}

        //public class MusteriManager
        //{
        //    // Ust seviye bir sınıf alt seviye bir sınıfa bagımlı hale geldi.
        //    // Gereksinim arttıkça koda mudahale artacaktır.Bunu en aza indirmemiz gerek.
        //    public void Add(GercekMusteri gercekMusteri)
        //    {
        //        gercekMusteri.Add();
        //    }
        //}

    }
}
