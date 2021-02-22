using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            // ARRAYLER (DİZİLER)

            string[] students = new string[3];
            // string array'i böle tanımalnıyor

            students[0] = "engin";
            students[1] = "derin";
            students[2] = "salih";
            // string array'inin içini böle doldurduk.

            string[] students_1 = new string[3] {"engin", "derin", "salih"};
            // yukarıdaki array'i böyle de tanımlayabilirdik.

            //---------------------------------------------------------------

            // ÇOK BOYUTLU DİZİLER
            
            string[,] name = new string[2,2];
            name[0, 0] = "veli";
            name[0,1] = "ali";
            name[1, 0] = "ahmet";
            name[1, 1] = "memet";
                      
            // yukarıda çok boyutlu bir dizi tanımladık bu aslında bir matrix olmuş oluyor
            // yukarıdaki gibi herbir matrixin içine bişeler atayabiliriz.

            string[,] nickname = new string[3, 3]
            {

                {"angel","demon","amadeus" },
                {"phone","izo","neo" },
                {"matrix","martin","glass" }

            };
            // çok boyutlu dizileri yani matrixleri yukarıdaki gibi de tanımlayabilirsin.
            for (int i=0; i<=nickname.GetUpperBound(0); i++)
            {
                for (int j=0; j <=nickname.GetUpperBound(1); j++)
                {
                    Console.WriteLine(nickname[i,j]);
                }
                Console.WriteLine("****************");

            }
            // yukarıdaki GetUpperBound(0) olarak kullandığımız fonksiyon tanımladığımız 
            // matrixin 0. indexine verdiğimiz sayıyı aldı biz burda matrixi tanımlarken 3 verdiğimiz için 3 aldı
            
        }
    }
}
