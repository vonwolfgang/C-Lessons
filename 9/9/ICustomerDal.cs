using System;
using System.Collections.Generic;
using System.Text;

namespace _9
{

    // biz burda aşağıdaki şeyde yani bitane daha interface oluşturduk bu interface
    // den sonra iki tane sınıf oluşturduk bu sınıflara oluşturduğumuz interfaceleri enjekte ettik
    // bunu yapmamızın sebebi ise interface 'de tanımladığımız özellikleri başka sınıflarada eşitleyerek kullanılabilmesi
    // örneğin sen sql serverda bişey yazdın sonra oracle 'de yazdın tek bir interface ile belli özellikleri 
    // iki ayrı server'a atayabilirsin. seni bağımlılıktan kurtarır.

    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated");
        }
    }


    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }

    }

    class CustomerManager_1
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
            // yukarıda yaptığımız şey sayesinde belli bir server'a bağlı kalmadan 
            // interface'i tanımladığımız her server'da kullanabiliriz çünkü biz bu sınıfa parametre olarak bir interface verdik.
        }

    }









}
