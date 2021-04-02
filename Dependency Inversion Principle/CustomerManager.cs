namespace Dependency_Inversion_Principle
{
    partial class Program
    {
        public class CustomerManager
        {
            // Bagımlılıgı olabildiğince en aza constructor injection la indirdik.Veya method injection da tercih edilebilirdi.
            private ICustomer _musteri;
            public CustomerManager(ICustomer musteri)
            {
                _musteri = musteri;
            }
            public void Add()
            {
                _musteri.Add();
            }
        }
    }
}
