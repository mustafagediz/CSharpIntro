// See https://aka.ms/new-console-template for more information

namespace Interfaces

{
    class Program
    {
        static void Main(string[] args)
        {
            //interfaceler new lenemez
            //IPersonManager personManager= new IPersonManager();
            //personManager.Add();
            //IPersonManager customerManager = new CustomerManager();

            //IPersonManager employManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());



        }
    }

    interface IPersonManager
    {
        //unimplemented operation
        void Add();
        void Update();
    }

    //class PersonManager
    //{
    //    //implemented operation
    //    public void Add()
    //    {
    //        Console.WriteLine("Eklen");
    //    }
    //}

    //inherits -class------------implements - interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi");

        }
    }

    class InternManager:IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Personel Eklendi");

        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi");
        }
    }

    class ProjectManager
    {
                        //parametre interface
        public void Add(IPersonManager personManager)//implement edilen interface ikisininde (customer ve empyloyee) referansını tuttuğu için ben buraya bu değeri girdiğimde
                                                    //yukarıda her implement edilen class çalışacaktır
        {
            personManager.Add();
        }
    }


    //class Person
    //{

    //}

    //class Customer:Person
    //{

    //}
}