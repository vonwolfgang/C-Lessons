using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);
            customerManager.Add();

            Product product = new Product(2, "computer");
            // yukarıda direk böyle verebilmemizin sebebi constructor tanımlamış olmamız.

            Product product_1 = new Product() { Id = 2, Name = "laptop" };
            // constructor tanımlamadan önce böyle tanımlamamız gerekiyordu.

            WorkManager workManager = new WorkManager(new DatabaseLogger());
            workManager.Add();
            // parametre olarak interface verdiğimiz için interface'i eşitlediğimiz sınıflardan birini atadık.

            //---------------------------------------------------------------------

            // Statik Nesneler.

            Teacher.Number = 10;
            // static nesneleri böle kullanırız. Static nesneler ortak kullanılan nesnelerdir
            // yani bir yerde değiştiğinde her yerde değişir.

            Manager.Do_Something();
            // static olmayan bir class'ın içindeki static metodu direk böyle çağırırız.

            Manager manager = new Manager();
            manager.Do_Something_2();
            // aynı class'ın içindeki static olmayan nesneyi ise böyle new'leyerek çağırırız.

        }
    }
    //---------------
    class CustomerManager
    {
        private int _count=15; // yanda default parametre verdik 
        public CustomerManager(int count)
        {
            _count = _count;
        }
        // bu constructors'lara parametre vermeye yarıyor  
        public CustomerManager()
        {

        }

        public void List()
        {
            Console.WriteLine("Listed!");
        }

        public void Add()
        {
            Console.WriteLine("Added! {0}", _count );
        }
    }
    //---------------
    class Product
    {
        public Product()
        {
           
        }

        private int _id;
        private string _name;

        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
    //---------------

    interface ILogger
    {
        void Log();
    }

    //---------------

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Database Logged!!!");
        }
    }

    //---------------

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("File Logged!!!");
        }
    }

    //---------------

    class WorkManager
    {
        private ILogger _logger;
        public WorkManager(ILogger logger) // biz yanda constructors yaparken parametre olarak interface verdik.
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Database Logged!!!");
        }
    }

    //---------------

    class BaseClass
    {

        private string _entity;  // bitane baseclass tanımladık baseclass'lar genellikle diğer tanımlayacağın classların
                                 // ortak sahip olacağı özellikler tanımlanır. Biz bunun içine bi tane constructors verdik   
                                 //
        public BaseClass(string entity)
        {
            _entity = entity;
        }



        public void Message()
        {

            Console.WriteLine("{0} message", _entity);
        }

    }

    //---------------

    class PersonManager : BaseClass
    {
        public PersonManager(string entity): base(entity)
        {
            // bu yaptığım ne işe yarıyor anlamadım barış abi sor bunu 
        }

        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
            // tanımladığımız fonksiyonun içine baseclasstan fonksiyon atadık ama constructors ile sanırsam
            // classtan classa parametre verdik tam anlamadım.
    }

    //----------------

    // STATİK NESNE
    static class Teacher
    {
        public static int Number { get; set; }
    }
    // static nesnelerin aldığı şeylerde static olmak zorundadır bu bir sınıfmış
    // gibi görünse de aslında bir sınıf değil bir nesnedir ve sınıf gibi kullanılamaz.
    // statik nesneler genel olarak her yerde aynı şeyi kullanma durumunda kullanılır. 

    //--------------

    class Manager
    {

        public static void Do_Something()
        {
            Console.WriteLine("Done");
        }

        public void Do_Something_2()
        {
            Console.WriteLine("Done 2");
        }
    }

    // class'ı static yapmadan da içindeki fonksiyonları static yapabilirsin.

    //----------------

    static class Customer_1
    {
        static Customer_1()
        {

        }
        public static void Validate()
        {
            Console.WriteLine("hello again");
        }
    }
    // aynı şekilde static olan constructors'da tanımlanabilir.













}
