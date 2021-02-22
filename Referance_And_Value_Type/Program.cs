using System;

namespace Referance_And_Value_Type
{
    class Program
    {

         
        static void Main(string[] args)
        {
            // REFERANS VE DEĞER TİPLERİ

            int number_1 = 10;
            int number_2 = 20;

            string[] cities_1 = new string[] { "Ankara", "Adana", "Afyon" };
            // biz yukarıdaki gibi bişe yaptığımızda bellekte cities_1'in 
            // yerini tutan bir yer oluyor bir de cities_1 'in değerini tutan bir yer oluyor
            string[] cities_2 = new string[] { "Bursa", "Bolu", "Balıkesir" };
            cities_2 = cities_1;
            // yukarıdaki gibi bişe yaptığımız da ise bunların değerlerinin atandığı referansları atamış oluyoruz
            // yani şöyle cities_1'in değerinin referansını cities_2'ye atıyoruz.
            cities_1[0] = "İstanbul";
            // eğer böyle bişey yapar isek cities_1'in referans değerini cities_2'nin referans değerine eşitlediğimiz
            // için cities_2'in 0. elemanı da değişecek çünkü cities_2'in ilk değerini tutan bir referans ortada kalmadı.
            Console.WriteLine(cities_2[0]);
            
            //------------------------------------------------------------------------------------------

           




 


        }
    }
}
