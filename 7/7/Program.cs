using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            // SINIF TANIMLAMA

            CustomerManager customerManager = new CustomerManager();
            // aşağıda oluşturduğumuz sınıftan bir tane customerManager isminde bir
            // obje oluşturduk. Class isimleri büyükharflerle başlar objesi ise küçük harfle
            customerManager.Add();
            customerManager.Update();
            // oluşturduğumuz obje sınıfın özelliklerini de taşıyor.

            Product product = new Product();
            product.Add();
            // yeni bir sınıf yazıp yeniden obje tanımldık.

            //---------------------------------------------------------

            // CLASS PROPERTY

            Anonymous anonymous = new Anonymous();
            anonymous.Id = 10234;
            anonymous.Name = "anonymous";
            anonymous.Where = "in hell";
            // yukarıda bu değişkenlere sahip olan objemizin içini doldurduk.

            Anonymous anonymous_1 = new Anonymous
            {
                Id = 123123, Name= "anonymous", Where = "in heaven"
                // biz burdaki gibi eşitlemeleri yaptığımızda property'nin set bloğu çalışıyor
            };
            // yukarıda değişkenlere sahip objeye ozellik atama işlemini böylede yapabiliriz.
           
            Console.WriteLine(anonymous_1.Name);
            // böle de ekrana yazdırabilirsin.
            // böle yazdırdığımız da ise property'nin get bloğu çalışıyor.

            //------------------------------------------------------------




        }
    }

    // SINIF TANIMLAMA

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated");
        }
    }


    class Product
    {
        public void Add()
        {
            Console.WriteLine("please add a product");
        }
    
    
    }
    //----------------------------------------------------

    // CLASS PROPERTY

    class Anonymous
    {
        public int Id { get; set; }
        public string Where { get; set; }
        public string Name { get; set; }
        // yukarıda yaptığımız şey sınıftan bir obje oluşturduğumuz takdirde 
        // o objede bu değişkenlere sahip olmuş oluyo ve bu değişkenlerin içine bişeyler atayabiliyoruz.

    }
    
    //------------------------------------------------------






}


