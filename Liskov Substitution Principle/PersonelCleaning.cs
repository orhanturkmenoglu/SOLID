using System;

namespace Liskov_Substitution_Principle
{
    // Personel Cleaning :Temizlik Personeli
    public class PersonelCleaning : IPersonelCleaning
    {
        public void CleanUp()
        {
            Console.WriteLine("Temizlik yap");
        }
    }




}
