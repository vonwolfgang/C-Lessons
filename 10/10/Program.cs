using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Managers(),
                new Worker(),
                new Robot()
            };

            // yukarıdaki gibi hepsinde ortak olan interface üzerinden bir tane 
            // array oluşturduk hepsinde ortak olduğu için de bunları çağırdık.
            
            // eğer sadece yemek yiyenleri içinde bulunduran bir array tanımlamak isteseydik de 
            // bu sefer de IEat kullanırdık 

        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();   
    }

    interface ISalary
    {
        void GetSalary();
    }

    // yukarıdaki gibi birden fazla interface tanımlayabiliriz. 


    class Managers : IWorker, ISalary, IEat
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }


    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }

    }



    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    // yukarıda da görüldüğü gibi bir tane class' a birden fazla interface implament edebiliyoruz.












}
