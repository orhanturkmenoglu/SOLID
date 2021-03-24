namespace Interface_Segregation_Principle
{
    

    // Çözüm : tek bir interface oluşturmak yerine birden fazla özelleştirilmiş interface oluşturulmalıdır.İhtiyacı olan 
    // istedigini kullanmalıdır.

    // Doğru kullanım.
    public interface IWorker
    {
        void Work();
    }
}
