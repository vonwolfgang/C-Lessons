using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Customer
    {
        private int id;
        // private değişkenler sadece tanımlandığı blok içerisinde geçerlidir. Bu bloğun içerisinde 
        // alt bloklar var ise onlarda da geçerlidir. Bir değişken tanımladığımız da onun başına nerde olcağını yazmassak 
        // default olarak onun yeri private olur.

        protected int hey; 
        // protected özellik tipi aynı private benzer fakat private'dan farkı biz bi class'ın içinde tanımladığımız
        // protected olarak tanımladığımız veriyi başka bir class'a inheritance olarak verdiğimizde
        // o veriyi inheritance verilen classda da kullanabilirsin ama private erişim şeyinde böyle bişey yapamazsın.


    }

    internal class Student
    // internal belirteci istediğimiz aynı proje içerisinde istediğimiz yerde çağırabileceğimiz bir belirteçtir ve class'ların default belirtecidir.
    { 
        public void Save()
        {

        }
    }
    // normal bir class tanımlanırken asla private ya da protected olamaz ama eğer class içinde class tanımlarsak o zaman classın başına private felan yazabiliriz.


    public class Free
    {
        // public ise heryerde kullanabileceğini belirten belirteçtir referans verildiği zaman başka projelerde de kullanılabilir.
    }


}
