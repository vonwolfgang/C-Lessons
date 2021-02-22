using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Database  database = new Oracle(); // interface'ler gibi abstract class 'lardan da kendi içinde obje tanımlayamayız.
            // yukarıda Database özelliklerine sahip Oracle() sınıfından database objesi tanımladık
            database.Add();
            database.Delete();
            
            Database database_1 = new SqlServer(); // interface'ler gibi abstract class 'lardan da kendi içinde obje tanımlayamayız.
            // yukarıda Database özelliklerine sahip Oracle() sınıfından database objesi tanımladık
            database_1.Add();
            database_1.Delete();



        }
    }

    abstract class Database // abstract class'lar içlerine absstract metot alabilen class'lardır 
    {                      
        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete();
        // bir tane abstract metot tanımladık bu metot sayesinde istediğimiz yerde istediğimiz şekilde tanımlayabiliriz içini.
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by sql"); // örnekteki gibi override olarak geldi yani içini değiştirebiliriz abstract metotların.
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by oracle"); // örnekteki gibi override olarak geldi yani içini değiştirebiliriz abstract metotların.
        }
    }

    // abstract classlardan birinden bir classı inheritance ettiğimiz zaman başka bir class veya abstract class ile
    // o sınıfı tekrar inheritance edemeyiz.



}
