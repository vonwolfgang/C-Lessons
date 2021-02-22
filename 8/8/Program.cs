using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            // yukarıda yazdığımız PersonManager sınıfından manager isimli bir obje tanımladık.
            manager.Add(new Kali { Id = 1, Name = "anonymous", Nick = "hack" });
            // burda ise o objenin içindeki Add() fonksiyonunu kullandık bu fonksiyon parametre olarak obje alıyordu bir klastan biz Kali sınıfından 
            // obje almasını sağladık yukarıdaki yöntemle aldığı objenin özelliklerini verdiko objeye

            //**********************************************

            PersonManager manager_1 = new PersonManager();
            Kali kali_1 = new Kali 
            {
                Id = 2,
                Name = "anonymous_2",
                Nick = "hack_1"
            };
            manager_1.Add(kali_1);
            // yukarıda tek tek yaptığımız işlemi böyle de yapabilirdik.

            //***********************************************

            manager.Add(new Anonymous {Id=3,Name="hello", Nick="where" });
            // yukarıda da interface parametresi verdiğimiz için o interface ile tanımlanan tüm claslardan obje alabiliyor.

        }
    }

    // INTERFACE

    interface IDark
    {
        int Id { get; set; }
        string Name { get; set; }
        string Nick { get; set; }
        // interface lere özellik tanımlarken public private gibi imza konulmaz başlarına

    }
    // interface böyle bir şeydir ve soyut nesne denir
    // interface ler tanımlanırken büyük I ile başla genel yazım kültürü bu
    // interfacelerin amacı interface'in içine bir özellik tanımladık diyelim sonrasında
    // sonra bu interface'i tanımladığımız herhangi bir class'a eşitlersek o class da interface'in özelliklerine
    // otomatik olarak sahip olmuş oluyor.

    class Anonymous : IDark
    {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Nick { get; set; }
    }

    class Kali:IDark
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nick { get; set; }

        // interface tanımladığımız zaman böyle de atama yapmamız gerek tekrardan 
    }

    // class lar ise somut nesnelerdir

    //-------------------------------------------------------------------

    class PersonManager
    {
        public void Add(IDark weeb) // yandaki fonksiyona yukarıdaki bir class tan obje olarak parametre verdik
        {
            Console.WriteLine(weeb.Id);
            // yukarıda yaptığımız şey ise aldığımız objeyi ıd 'sini aldık 
            // yukarıda sadece Kali sınıfından bir obje alabilcek şekilde bir parametre vermiş olsaydık sadece Kali sınıfından bir parametre alabilirdi
            // diğer sınıfların objesini kabul etmezdi o yüzden Interface şeklinde vericez. Böylece aynı ınterface ile tanımlanmış diğer sınıflarında objesini parametre
            // olarak verebilicez.
        }
    }

    //------------------------------------------------------------------


}
