using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            // FOR DÖNGÜSÜ
            
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //------------------------------------

            // WHİLE DÖNGÜSÜ
            
            int number = 10;
            
            while (number>0)
            {
                Console.WriteLine(number);
                number--;
            }

            //------------------------------------

            // DO WHİLE DÖNGÜSÜ

            int number_1 = 10;
            do
            {
                Console.WriteLine(number_1);
                number_1--;
            } while (number_1>0);
            //do while döngüsüde böyle önce do çalışır sonra şart sağlanır
            // yani şart sağlanmazsa bile do bikere de olsa çalışırz

            //------------------------------------

            // FOREACH DÖNGÜSÜ

            string[] students = new string[3] { "anonymous", "hello", "whereismymind" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            // foreach döngüsü ile ilgili bişey daha foreach döngüsü içerisinde dizinin elamanını değiştiremezsin.

            //----------------------------------------------------------------

            // ASAL SAYI BERLİRLEYEN GARİP ALGORİTMA

            IsPrime(10);

        }


        // ASAL SAYI BELİRLEYEN ALGORİTMA

        private static void IsPrime(int number)
        {
            bool x = true;

            for (int i = 2; i < number; i++)
            {
                if (number%i==0)
                {
                    x = false;
                } 

            }

            if (x == true)
            {
                Console.WriteLine("this number is prime {0}", number);
            }
            else
            {
                Console.WriteLine("this number is not prime {0}", number);
            }
        }

    }
}
