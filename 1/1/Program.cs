using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            // İNT VERİ TİPİ

            int number_1 = 10, number_2 = 20;
            // yukarıda iki tane int sayı tanımladık.
            Console.WriteLine("Number 1 is {0} \nnumber 2 is {1} ", number_1, number_2);
            // yukarıda hangi rakamın nereye geleceğini belirtmek için format kullandık. \n ile bir alt satır geçirdim.

            //------------------------------------------------------------------------

            // LONG VERİ TİPİ

            long number_3 = 1032, number_4 = 24120;
            // yukarıda iki tane long sayı tanımladık.
            Console.WriteLine("Number 3 is {0} \nnumber 4 is {1} ", number_3, number_4);
            // yukarıda hangi sayının nereye geleceğini belirtmek için format kullandık. \n ile bir alt satır geçirdim.

            // long ile int farkı long çok daha büyük verileri depolamak için kullanılır haliyle bellekte 
            // çok fazla yer kaplar

            //------------------------------------------------------------------------
            
            // SHORT VERİ TİPİ

            short number_5 = 1032, number_6 = 24120;
            // yukarıda iki tane short sayı tanımladık.
            Console.WriteLine("Number 5 is {0} \nnumber 6 is {1} ", number_5, number_6);
            // yukarıda hangi sayının nereye geleceğini belirtmek için format kullandık. \n ile bir alt satır geçirdim.

            // short küçük verileri depolamak için kullanılır haliyle bellekte 
            // az yer kaplar

            //------------------------------------------------------------------------


            // BYTE VERİ TİPİ 

            byte number_7 = 12, number_8 = 3;
            // yukarıda iki tane byte sayı tanımladık.
            Console.WriteLine("Number 7 is {0} \nnumber 8 is {1} ", number_7, number_8);
            // yukarıda hangi sayının nereye geleceğini belirtmek için format kullandık. \n ile bir alt satır geçirdim.

            // byte çok küçük verileri depolamak için kullanılır haliyle bellekte 
            // çok az yer kaplar

            //------------------------------------------------------------------------

            // BOOL VERİ TİPİ

            // tuttuğu veri true veya false 'dur 

            bool conditions = false;
            // böle tanımlanır.

            //---------------------------------------------------------------------------

            // CHAR VERİ TİPİ

            char character = 'a';
            // character veri tipidi bunu tek tırnakla tanımlarız ve string değildir bu.

            Console.WriteLine((int)character);
            // yukarıda karakter olan bi veri tipini int veri tipine dönüştürdük 
            // c sharp da dönüştürme yukarıdaki gibi yapılıyor biz bunu bastırınca karşımıza
            // atadığımız karkaterin aski tablosundaki sayısal değerini görürüz.

            //---------------------------------------------------------------------------

            // DOUBLE VERİ TİPİ

            // bu veri tipi ondalıklı sayıları tutabilir

            double number_9 = 10.4;
            // böle tanımlanır.

            //---------------------------------------------------------------------------

            // DECİMAL VERİ TİPİ

            // decimal veri tipi double dan daha uzun ondalıklı sayılar için decimal kullanılır

            decimal number_10 = 10.5m;
            // decimal de ondalıklı değerler tanımlarken yanına böle ya küçük m ya da büyük M koymamız gerekir, ama değer ondalıklı değilse
            // direk atama yapılabilir.

            //---------------------------------------------------------------------------

            // ENUM VERİ TİPİ

            // enum veri tipini aşağıda sınıf gibi tanımladık 
            Console.WriteLine(Days.Friday);
            // bunu yazdırınca bize Friday yazdırcak
            Console.WriteLine((int)Days.Friday);
            // bunu yazdırınca ise int e dönüştürdüğümüz için Days enum'ının içindeki
            // index değerini yazdırcak bize.

            //---------------------------------------------------------------------------

            // VAR KEYWORD 

            // var bir değişken değil keyword dur bu keyword sayesinde değişkenimize hangi değeri atarsak
            // var o tipe bürünür

            var number_11 = 10;
            // örneğin yukarıda number_11 'e int değer atadık var artık int oldu
            
            number_11 = 'A';
            // eğer böle bişe yaparsak bize A char ının aski tablosundaki değerini yazdırır.

            //number_11 = "A";
            // böle bişe ise yapamayız çünkü çift tırnak ile string değerler tanımlanır ve 
            // stringlerin aski tablosunda sayısal değerleri yoktur.



            













        }
    }

    //---------------------------------------------------------------------------

    // ENUM VERİ TİPİ
    enum Days
    {
        Monday=10, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday 
        // enum böle tanımlanıyor aynı sınıf gibi
        // eğer enum veri tipine böle 10 felan eşitlersek diğerleri de ona göre sıralanır
        // istersek herbirine de bu şekilde değerler atayabiliriz.

    }
}
