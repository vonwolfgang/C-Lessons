using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = new string[2] { "Ankara", "İstanbul" };
            cities = new string[3];
            Console.WriteLine(cities[0]);
            // yukarıda koleksiyon tanımlamadık koleksiyonun neden önemli olduğunu anlamaya çalıştık
            // yukarıda şöyle bişey oldu biz iki elemanlı bir dizi tanımladık. Sonrasında 3. bir elaman eklemek istedik
            // ve eski diziyi 3 elemanlı olarak tanımladık ama içine bişey koymadık
            // sonrasında ise bu dizinin 0. elemanını yazdırmak istediğimiz de ise karşımıza hiç bişe yazmıcak
            // sebebi ise referans tipinin değişmiş olması yani ilk baştaki dizinin içinde tanımlanan şeyden eser kalmadı
            // 3 elemana yükselttiğimiz dizinin ise içine bişey yazmadığımız için default olarak " " bu karakter geldi yani boşluk
            // böylece bişey yazdırmadı.

            //--------------------------------------------------------------------------------------

            // ARRAYLİST

            /*
            ArrayList cities_1 = new ArrayList();
            // ArrayList diye bişey var ama bende neden bulmadı anlamadım ona bakmam gerek
            // bu ArrayList özelliği ise şudur belli bir sınırı olmayan listedir içine istediğimiz kadar
            // eleman ekleyebiliriz.
            cities_1.Add("henlo");
            // Add metodunu kullanarak eleman ekleyebiliriz böyle.
            */
            // arraylist'ler tip güvenli değildirler yani ne atarsan at kabul eder.

            //--------------------------------------------------------------------------------------

            // TİP GÜVENLİKLİ LİSTELER
            /*
            List<string> cities_2 = new List<string>();
            // yukarıdaki olay da string tipinde bir koleksiyon tanımladık demek
            // gene bende neden altı çizili anlamadım bunlara bir bak 

            cities_2.Add("hello_friend");
            // bu koleksiyonda da istediğin kadar eleman ekleyebilirsin belirttiğin tipte olmak şartıyla

            List<Customer> customer = new List<Customer>();
            // yukarıda da Customer classı tipinde bir koleksiyon tanımladık
            customer.Add(new Customer {Id=1, name= "henlo" });
            customer.Add(new Customer { Id = 2, name = "friend" });
            // customer koleksiyonunun içine iki tane nesne tanımladık.
            */

            //-------------------------------------------------------------------------------------

            // KOLEKSİYON METOTLARI

            var count = koleksiyon_ismi.Count();
            // koleksiyonun eleman sayısını sayar
            koleksiyon_ismi.AddRange();
            // içerisine parametre olarak array felan alır bu aldığı listeyi de 
            // ilgili koleksiyon içine ekler.








        }
    }


    class Customer
    {
        public int Id { get; set; }
        public string name { get; set; }
    }
}
