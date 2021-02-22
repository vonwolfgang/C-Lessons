using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {

            //  STRİNG TANIMLAMA FELAN

            string nick = "anonymous";
            // string ifadeler böle tanımlanır
            
            foreach (var item in nick)
            {
                Console.WriteLine(item);
                // burda ise foreach döngüsünde tanımladığımız stringin her bir harfini
                // yazdırcak
            }

            Console.WriteLine("\n");

            string nick_1 = "hello_anonymous";
            
            string result = nick_1 + " " + nick;
            Console.WriteLine(result);
            // yukarıda bir tane daha değişken açıp o değişkene atadık
            // ve string topladık

            Console.WriteLine("\n");
            Console.WriteLine(String.Format("{0} {1}", nick, nick_1));
            // yeni bir değişken oluşturmadan da yukarıdaki gibi de yapabilirdik

            //---------------------------------------------------------------

            // STRİNG İLE KULLANILAN METOTLAR

            string sentence = "bullet doesn't hurt the ideas";
            
            var result_1 = sentence.Length;
            Console.WriteLine(result_1);
            Console.WriteLine("\n");
            // cümledeki karakter sayısını sayar boşluk da bir karakterdir

            var result_2 = sentence.Clone();
            Console.WriteLine(result_2);
            Console.WriteLine("\n");
            // yukarıdaki Clone() şeysine klonladık ama asıl cümleyi değiştirsekde
            // result_2 değişmez.

            var result_3 = sentence.EndsWith("s");
            Console.WriteLine(result_3);
            Console.WriteLine("\n");
            // yukarıdaki şeyde EndsWith("s") ile kastettiğimiz bu cümle s ilemi bitiyor gibisinden 
            // s yerine direk kelimede yazabilirdik bunun sonucu bool olarak döner.

            var result_4 = sentence.StartsWith("gdf");
            Console.WriteLine(result_4);
            Console.WriteLine("\n");
            // yukarıda da StartsWith("gdf") ile bu cümle gdf ile mi başlıyor diye sorduk 
            // gene bunun sonucuda bool olarak döner.

            var result_5 = sentence.IndexOf("name");
            Console.WriteLine(result_5);
            Console.WriteLine("\n");
            // yukarıda yaptığımız şey cümlemizin içinden arıyor yani "name" dedikya
            // bunun sonucunda o fonksiyon bize "name"' in başladığı karakterin indexini döndürür
            // eğer verdiğimiz şeyi içinde bulamassa -1 döndürür eğer aradığımız şey cümlenin
            // içinde birden fazla var ise ilk bulduğu indexin numarasını döndürür.

            var result_6 = sentence.LastIndexOf(" ");
            Console.WriteLine(result_6);
            Console.WriteLine("\n");
            // buda aramaya sondan başlar gene özellikleri aynı ama farkı aramaya sondan başlaması
            // bulduğunda ise indexlemeye baştan başlayarak index no sunu döndürür

            var result_7 = sentence.Insert(0,"hello anonymous, ");
            Console.WriteLine(result_7);
            Console.WriteLine("\n");
            // Insert(0,"hello") yaptığımızda ise cümlenin 0. indexinden sonra hello eklicek 
            // yani bişe eklemeye yarıyor.

            var result_8 = sentence.Substring(3,4);
            Console.WriteLine(result_8);
            Console.WriteLine("\n");
            // yukarıdaki metot ise cümlemizi 3. indexden sonra 4 karakter al demek 

            var result_9 = sentence.ToLower();
            Console.WriteLine(result_9);
            Console.WriteLine("\n");
            // bu ise tüm karakterleri küçük harf yapar

            var result_10 = sentence.ToUpper();
            Console.WriteLine(result_10);
            Console.WriteLine("\n");
            // bu ise tüm karakterleri büyük harf yapar

            var result_11 = sentence.Replace(" ","-");
            Console.WriteLine(result_11);
            Console.WriteLine("\n");
            // bu ise şu demek cümledeki boşluk karakterlerine "-" karkaterini koy demek
            // yani yer değiştiriyor

            var result_12 = sentence.Remove(2);
            Console.WriteLine(result_12);
            Console.WriteLine("\n");
            // bu ise belli bi indexden sonrasını atmaya yarar yani 2. indexden sonrasını silicek

            var result_13 = sentence.Remove(2,5);
            Console.WriteLine(result_13);
            Console.WriteLine("\n");
            // bu ise 2. indexden sonra 5 karakter siler








        }
    }
}
