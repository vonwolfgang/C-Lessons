using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Console.WriteLine(Add_1(3, 6));
            Console.WriteLine(Add_2(3));
            // console içinde çağırmamızın sebebi biz sadece return ettik yana döndürülebilir dedik.
            // ama döndürmedik console ile döndürdük.

            //-----------------------------------------------------------------------------

            int number_3 = 20, number_4 = 100;
            var result = Add_3(number_3, number_4);
            Console.WriteLine("x + y = {0}",result);
            Console.WriteLine("number_3 = {0}",number_3);
            // yukarıda Add_3 için number_3 ve number_4'u tanımlayıp verdik
            // sonrasında Add_3 sonucunu result'a atadık ama şöle bişe daha yaptık
            // Add_3 metodu için number_3'e 30 değerini atadık sonrasında result'ı yazdırdık
            // ve sonuç 130 çıktı, ama sonrasında number_3'ü tekrar yazdırdığımızda number_3= 20 
            // çıktı çünkü biz Add_3'ün içine sadece number_3 int'inin değerini atadık sonra Add_3 içinde bu değer
            // değişti ama değişen şey number_3 değildi.

            //----------------------------------------------------------------------------

            // REF KEYWORD

            int number_5 = 20, number_6 = 100;
            var result_1 = Add_4(ref number_5, number_6);
            Console.WriteLine("x + y = {0}", result_1);
            Console.WriteLine("number_5 = {0}", number_5);
            // eğer bu atama işlemi yapıldığında atanan şeyi de değiştirmek istiyorsak 
            // ref keyword'unu kullanırız ama ref'i kullanırken metotda kullandığımız için metodu
            // çağırırdığımız da parametre verdiğimizde de yazmamız gerekir.

            //----------------------------------------------------------------------------

            // OUT KEYWORD

            int number_7 = 34, number_8 = 100;
            var result_2 = Add_5(out number_7, number_8);
            Console.WriteLine("x + y = {0}", result_2);
            Console.WriteLine("number_5 = {0}", number_7);
            // yukarıdaki gibi out 'da ref ile aynı görevi yapar
            // ama out'da şöyle bişey var yukarıdaki number_7'ye değer atamadan fonksiyon parametresi olarak
            // versek bişey olmaz ama eğer metodun içinde number_7'yi tanımlamamışsak sıkıntı çıkarır.

            //-----------------------------------------------------------------------------

            // METOT OVERLOADİNG

            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2,4,6));

            //-----------------------------------------------------------------------------

            // PARAMS KEYWORD

            Console.WriteLine(Add_6(2,3,4,5));




        }

        //----------------------------------------------------

        static void Add()
        {
            Console.WriteLine("Added!");
        }
        // void metotlar return yapamaz yani sadece ekrana bişey yazdırabilir.

        //---------------------------------------------------
        
        static int Add_1(int number_1, int number_2)
        {
            return number_1 + number_2;
        }
        // eğer ekrana bişey return etmek istiyorsak return etmek istediğimiz şeyin tipinde
        // bir metot tanımlamalıyız, ve ayrıca metotlara yukarıdaki gibi parametre atayabiliriz.

        //--------------------------------------------------
        static int Add_2(int number_1, int number_2=30)
        {
            return number_1 + number_2;
        }
        // yukarıda int number_2=30 diyerek eğer number_2 için bir parametre verilmezse default olarak
        // bu 30 'u kullan dedik. Bi de default değerler en son da verilmesi gerekiyor. Eğer number_1 default verip
        // number_2 vermeseydik bize kızardı.

        //--------------------------------------------------

        static int Add_3(int x, int y)
        {
            x = 30;
            return x + y;
        }
        
        //-------------------------------------------------
        
        // REF KEYWORD
        
        static int Add_4(ref int x, int y)
        {
            x = 30;
            return x + y;
        }

        //-------------------------------------------------
        
        // OUT KEYWORD
        
        static int Add_5(out int x, int y)
        {
            x = 30;
            return x + y;
        }
        //--------------------------------------------------

        // METOT OVERLOADİNG

        static int Multiply( int num_1, int num_2)
        {

            return num_1*num_2;
        }
        static int Multiply( int num_1, int num_2, int num_3)
        {

            return num_1*num_2*num_3;
        }
        // yukarıda şey yaptık aynı isimde aynı parametrelerle aynı türde iki metot yazdık
        // bu iki metodun farkı biri iki parametre diğeri üç parametre aldı bu sayede ister iki parametreli halini
        // ister üç parametreli halini kullanabiliyoruz bu işleme de overloading deniyor.
        
        //--------------------------------------------------------

        // PARAMS KEYWORD

        static int Add_6(params int[] numbers)
        {
            return numbers.Sum();
        }
        // Sum() FONKSİYONUNDA Bİ SORUN VAR DİKKAT ET

        // burda yaptığımız şey overload etmeden direk metoda dizi parametresi veriyoruz
        // bu sayede kullanıcı istediği kadar sayı girerek toplama yapabiliyor. Sum() ise
        // hazır bir fonksiyon sayıları toplayan bir fonksiyon

        //---------------------------------------------------------







    }
}
