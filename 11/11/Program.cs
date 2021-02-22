using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[3]
            {
                new Customer
                { 
                    FirstName = "anonymous_1"
                },
                new Student
                {
                    FirstName = "anonymous_2"
                }, 
                new Person
                {
                    FirstName = "anonymous_3"
                }
                // yukarıda Person clası'nın özelliklerine bune anlamadım.
            };

            foreach (var person_1 in person)
            {
                Console.WriteLine(person_1.FirstName);
            }


        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer : Person // yandaki gibi bişe yaptığımız zaman Person class'ındaki tüm özellikleri 
    {                       // Customer class'ına da aktarmış oluyoruz. Buna inheritance deniyor. 

    }

    class Student : Person  // buna da Person özelliklerini atadık. ayrıca başka değişken daha ekledik.
    {
        public string Departman { get; set; }
    }

    // bu bir class' a başka bir class verme şeysi interface'den farkı bir class'a başka bir class verdikten sonra
    // bidaha başka bir class veremessin. Interface 'de verebilirsin ama.




}
