using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlserver = new SqlServer();
            MySql mySql = new MySql();
            // objeler oluşturduk
            sqlserver.Add();
            mySql.Add();




        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default ");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("sql wait you");
            // base.Add(); bu Add() fonksiyonunu aldığımız yeri base alarak aldığımızı söylüyor
            // fakat override yaptığımız için ve base aldığımız yerin metotlarına virtual eklediğimiz için şöyle bişe yapabiliriz gene 
            // Database'in add metodunu kullanıcaz ama yaptığı işlemi değiştirebiliriz yani üzerine yazabiliriz.
            // base.Add() ile consolewriteline 'ı aynı anda da çalıştırabiliriz bunu interface'de yapamayız.




        }
    }

    class MySql : Database
    {

    }







}
