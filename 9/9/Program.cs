using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            // "IPerson person = new IPerson();"  yandaki kod hatalı çünkü bir interface'in objesi oluşturulmaz

            IPerson person = new Customer();
            // ama böyle yaparak Customer sınıfından bir person objesi oluşturabiliriz çünkü
            // Customer sınıfı aynı zamanda bir IPerson. 

            CustomerManager_1 customerManager_1 = new CustomerManager_1();
            // interface parametresi verdiğimiz sınıftan obje oluşturduk
            customerManager_1.Add(new OracleCustomerDal());
            customerManager_1.Add(new SqlCustomerDal());
            // içindeki fonksiyonu da interface'li sınıflarımızda kullandık.

            //----------------------------------------------------------------

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                 new SqlCustomerDal(),
                 new OracleCustomerDal()

            };
            // yukarıda bir tane interface array'i tanımladık bu array 2 tane obje alsın dedik
            // içine de aynı interface ile tanımlanmış classlar atadık

            foreach (var i in customerDals)
            {
                i.Add();

            }
            // foreach döngüsü ile yukarıda tanımladığımız interface array'ini çağırdık.

            //----------------------------------------------------------------




        }
    }


    // Interface
    interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        string Nick { get; set; }
        // interface lere özellik tanımlarken public private gibi imza konulmaz başlarına

    }
    // 2 tane class interface ile bağlantılı
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nick { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nick { get; set; }

        // interface tanımladığımız zaman böyle de atama yapmamız gerek tekrardan 
    }
   //--------------------------------------------------------------




}
