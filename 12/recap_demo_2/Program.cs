using System;

namespace recap_demo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customermanager = new CustomerManager();
            customermanager.Logger = new DatabaseLogger();
            customermanager.Add();
            // obje oluşturup bu objenin içindeki metodu çağırdığımız zaman eklediğimiz sınıftaki
            // metod'da çalışıcak.

        }
    }

    class CustomerManager
    {

        public  ILogger Logger { get; set; }
        public void Add()
        {
            Logger.Log();
            // böyle de yapabiliriz çünkü interface olarak tanımladık log'u.
            DatabaseLogger logger = new DatabaseLogger();
            logger.Log_1();
            Console.WriteLine("Customer added!");
            // böyle yaparak biz bir sınıfın içindeki bir metodu başka bir sınıfın içindeki
            // başka bir metodun içinde çağırabiliriz.
        }

    }

    class DatabaseLogger : ILogger
    {   
        public void Log_1()
        {
            Console.WriteLine("heyo man");
        }
    }
    interface ILogger
    {
        public void Log()
        {
            Console.WriteLine("logger man");
        }
    }





    // yukarıda yaptığımız şekilde yaparsak eğer sürekli başka yerlerde de çağırmak için new'lemek gerekir 
    // onun yerine biz bundan kurtulmak için interface' leri kullanırız.








}
