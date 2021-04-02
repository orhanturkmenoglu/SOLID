namespace Dependency_Inversion_Principle
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // Dependency Inversion Principle : Bağımlılığı tersine çevirme

            // Tanım: Üst düzey modüller, kolayca yeniden kullanılabilir olmalı ve yardımcı program
            // özellikleri sağlayan düşük düzeyli modüllerdeki değişikliklerden etkilenmemelidir. Bunu başarmak için,
            // yüksek seviyeli ve düşük seviyeli modülleri birbirinden ayıran bir soyutlama sunmanız gerekir.

            // Yüksek seviyeli modüller, düşük seviyeli modüllere bağlı olmamalıdır.
            // Her ikisi de soyutlamalara bağlı olmalıdır.

            // Soyutlamalar ayrıntılara bağlı olmamalıdır. Detaylar soyutlamalara bağlı olmalıdır

            // Kısa özet:
            // Sınıflar arası bağımlılıklar olabildiğince az olmalıdır özellikle üst seviye sınıflar alt seviye sınıflara bağımlı olmamalıdır.
            // Bir alt sınıfta yapılan değişiklikler üst sınıfları etkilememelidir.

            // Çözümü her iki sınıfta soyutlama üzerinden yönetilmelidir.

            // Neden kullanılır : Amacımız gelişebilir kod yapısına devam ettirmek aynı zamanda bu sayede gelişime açık
            // değişime kapalı bir kod yapısı oluşturmamızı da sağlar.


            CustomerManager realCustomer = new CustomerManager(new RealCustomer());
            realCustomer.Add();

        }
    }
}
