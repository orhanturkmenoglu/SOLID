namespace Open___Closed_Principle
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // Open Closed : Yazılım varlıkları değişime kapalı gelişime açık bir varlık olmalıdır.
            // Yani mevcut kodu değiştirmeden yeni işlevler ekleyebilmemizi sağlar.

            // Bu prensip yapıca sürdürülebilir ve tekrar kullanılabilirliğin temelini oluşturur.


            // Yeni gelecek özellikler için varolan kodu değiştirmeden, varolan yapıyı bozmadan
            // esnek bir geliştirme modeli uygulayarak, önü açık ve gelecekten gereksinimlere kolayca
            // adapte olup, ayak uydurabilen bir model uygulamalıyız.


            // Nezaman uygulamalıyız ? :
            //  gereksinimler değişmeye başladığında açık / kapalı
            // ilkesine uymak için kesinlikle çaba sarf etmemiz gerekmektedir.


            // Kullanimi 

            DatabaseManager sqlServer = new DatabaseManager(new SqlServer());
            sqlServer.Log();

            // Yeni gelen gereksinim olduğunu varsayarsak
            // sadece constructor parametresini değiştirmemiz yeterli olacaktır.
            DatabaseManager oracle = new DatabaseManager(new Oracle());
            oracle.Log();

            DatabaseManager mySql = new DatabaseManager(new MySql());
            mySql.Log();
        }


    }

}
