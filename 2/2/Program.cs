using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            // NORMAL İF 

            var number = 10;
            if (number==10)
            {
                Console.WriteLine("number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("number is 20");
            }
            else
            {
                Console.WriteLine("number is not 10 or 20");
            }
            
            //----------------------------------------------------------------------------

            // SİNGLE LİNE İF
            
            Console.WriteLine(number==10 ? "number is 10" : "number is not 10");
            // yukarıda ki şey ise single line if denen bişey yukarıda şöle oldu
            // eğer number 10'a eşit ise number is 10 yazdır değil ise number is not 10 
            // yazdır dedik.

            //-----------------------------------------------------------------------------

            // SWİTCH CASE

            switch (number)
            {
                case 10 :
                    Console.WriteLine("number is 10");
                    break;
                case 20:
                    Console.WriteLine("number is 20");
                    break;
                default:
                    Console.WriteLine("number is not 10 or 20");
                    break;
            }
            // yukarıda switch case tanımladık switch case ler de böle tanımlanıyor
            // yukarıda number için dedik eğer 10 ise case 10 çalışır 20 ise case 20 çalışır gibisinden
            // break koymayı unutma bunlarda. En son ise bunlardan hiçbirisi değil ise default seçenek çalışır.

            //-------------------------------------------------------------------------------

            if (number >= 0 && number<=100)
            {
                Console.WriteLine("number is between 0-100");
            }
            else if (number>100 && number <=200)
            {
                Console.WriteLine("number is between 100-200");
            }
            else if (number>200 || number <0)
            {
                Console.WriteLine("number is less than 0 or greater than 200 ");
            }
            else
            {
                Console.WriteLine("number is weird");
            }

            // yukarıda şart blokları ile bişeler yaptık yukarıda kullandığımız && işareti ve demek 
            // || bu işaret ise veya demek.

            //---------------------------------------------------------------------------------

            if (number < 100)
            {
                if (number>=90 && number < 95)
                {
                    Console.WriteLine("number is between 95-90");
                }
            }
            // yukarıda iç içe if felan yaptık.







        }
    }
}
